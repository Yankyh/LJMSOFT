using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LJMSOFT.DAL;
using System.Data.SqlClient;
using LJMSOFT.VIEW.PD_PRODUTO;

namespace LJMSOFT.VIEW.CX_CAIXA
{
    public partial class CaixaEntradaTela : Form
    {
        Conexao conexao = new Conexao();

        //VARIAVEIS
        static float valorItem = 0;
        public static int itemHandle = -1, count = 0;
        public int tipoPagamentoHandle = 0;
        String valorTotal = "";
        //
        public CaixaEntradaTela()
        {
            InitializeComponent();
            //Inicializa os elementos
            quantidadeBox.Text = "1";
            count = 0;
            deletarButton.Enabled = false;
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexao.Conectar();
            
            String item = itensCombo.Text;
            int quantidade = Convert.ToInt32(quantidadeBox.Text);
            valorTotal = valorTotalBox.Text.Replace(',', '.').Replace('R', ' ').Replace('$', ' ');

            //Busca o handle pelo nome
            String query3 = "SELECT HANDLE, NOME FROM CX_ITEM WHERE NOME = '" + item + "'";
            String nomeItem = "";
            SqlDataReader reader2 = conexao.Pesquisa(query3);

            while (reader2.Read())
            {
                item = reader2["HANDLE"].ToString();
                nomeItem = reader2["NOME"].ToString();
            }
            reader2.Close();
            //Pega handle da pessoa
            String pessoaNome = pessoaCombo.Text;

            String query4 = "SELECT HANDLE FROM PS_PESSOA WHERE NOME = '" + pessoaNome + "'";
            SqlDataReader reader3 = conexao.Pesquisa(query4);
            int pessoaHandle = -1;
            while (reader3.Read())
            {
                pessoaHandle = Convert.ToInt32(reader3["HANDLE"]);
            }
            reader3.Close();

            //SELECIONA O TIPO DE PAGAMENTO
            String tipoPagamento = tipoPagamentoCombo.Text;
            int quantidadeParcela = 0;

            String query5 = "SELECT * FROM CX_TIPOPAGAMENTO WHERE NOME = '" + tipoPagamento + "'";
            SqlDataReader reader5 = conexao.Pesquisa(query5);

            while (reader5.Read())
            {
                tipoPagamento = reader5["NOME"].ToString();
                quantidadeParcela = Convert.ToInt32(reader5["NUMEROPARCELA"]);
            }
            reader5.Close();

            String codigoPedido = codigoBox.Text;

            if (count == 0)
            {
                if (tipoMovimentacaoCombo.Text != "")
                {
                    if (pessoaCombo.Text != "" || (tipoMovimentacaoCombo.Text == "SIMPLES"))
                    {
                        if (formaPagamentoCombo.Text != "")
                        {
                            if (tipoPagamentoCombo.Text != "")
                            {
                                if (itensCombo.Text != "")
                                {
                                    if (quantidadeBox.Text != "")
                                    {
                                        this.Text = "Pedido - Cadastrado";

                                        pessoaCombo.Enabled = false;
                                        formaPagamentoCombo.Enabled = false;

                                        //Cria um pedido
                                        String query1 = "INSERT INTO CX_PEDIDO (ATIVO, STATUS, PESSOA) VALUES (1,1, "+ pessoaHandle + ")";
                                        conexao.Inserir(query1);
                                        //Busca o handle e atualiza o código do pedido
                                        String query2 = "SELECT MAX(HANDLE) HANDLE FROM CX_PEDIDO";
                                        SqlDataReader reader = conexao.Pesquisa(query2);

                                        while (reader.Read())
                                        {
                                            codigoBox.Text = reader["HANDLE"].ToString();
                                        }
                                        reader.Close();

                                        count++;

                                        //Pega handle do item
                                        String query6 = "INSERT INTO CX_ITEMPEDIDO (ITEM, QUANTIDADE, VALORTOTAL, PEDIDO, ITEMNOME) VALUES (" + item + ", " + quantidade + ", " + valorTotal + ", " + codigoBox.Text + ", '" + nomeItem + "')";
                                        conexao.Inserir(query6);

                                        //Atualiza a tabela de itens
                                        this.RefreshDataGrid();

                                        //Seleciona a soma dos itens no banco
                                        String query8 = "SELECT SUM(VALORTOTAL) VALORTOTAL FROM CX_ITEMPEDIDO WHERE PEDIDO = " + codigoBox.Text;
                                        SqlDataReader reader4 = conexao.Pesquisa(query8);
                                        decimal valorTotalPedido = 0;
                                        while (reader4.Read())
                                        {
                                            valorTotalPedido = Convert.ToDecimal(reader4["VALORTOTAL"]);
                                            valorTotalPedidoBox.Text = "R$ " + reader4["VALORTOTAL"].ToString();
                                        }
                                        reader4.Close();

                                        //Atualiza o valor da parcela
                                        this.AtualizaValorParcela(valorTotalPedido, quantidadeParcela);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Preencha o campo unidade");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Preencha o campo item");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Preencha o campo tipo de pagamento");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Preencha o campo forma de pagamento");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Preencha o campo cliente");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha o campo tipo de movimentação");
                }
            }
            else
            {
                if (quantidadeBox.Text != "")
                {
                    String query6 = "INSERT INTO CX_ITEMPEDIDO (ITEM, QUANTIDADE, VALORTOTAL, PEDIDO, ITEMNOME) VALUES (" + item + ", " + quantidade + ", '" + valorTotal + ", " + codigoBox.Text + ", '" + nomeItem + "')";
                    conexao.Inserir(query6);

                    //Atualiza a tabela de itens
                    this.RefreshDataGrid();

                    //Seleciona a soma dos itens no banco
                    String query8 = "SELECT SUM(VALORTOTAL) VALORTOTAL FROM CX_ITEMPEDIDO WHERE PEDIDO = " + codigoBox.Text;
                    SqlDataReader reader4 = conexao.Pesquisa(query8);
                    decimal valorTotalPedido = 0;
                    while (reader4.Read())
                    {
                        valorTotalPedido = Convert.ToDecimal(reader4["VALORTOTAL"]);
                        valorTotalPedidoBox.Text = "R$ " + reader4["VALORTOTAL"].ToString();
                    }
                    reader4.Close();

                    //Atualiza o valor da parcela
                    this.AtualizaValorParcela(valorTotalPedido, quantidadeParcela);
                }
                else
                {
                    MessageBox.Show("Preencha o campo unidade");
                }
            }
            conexao.Desconectar();
        }

        private void listarCliente(object sender, EventArgs e)
        {
            conexao.Conectar();
            //Limpa a combo box
            pessoaCombo.Items.Clear();

            //Lista os tipos
            String query1 = "SELECT NOME FROM PS_PESSOA";
            SqlDataReader reader = conexao.Pesquisa(query1);

            while (reader.Read())
            {
                pessoaCombo.Items.Add((reader["NOME"].ToString()));
            }
            reader.Close();

            conexao.Desconectar();
        }

        private void listarFormaPagamento(object sender, EventArgs e)
        {
            conexao.Conectar();
            //Limpa a combo box
            formaPagamentoCombo.Items.Clear();

            //Lista os tipos
            String query1 = "SELECT NOME FROM CX_FORMAPAGAMENTO";
            SqlDataReader reader = conexao.Pesquisa(query1);

            while (reader.Read())
            {
                formaPagamentoCombo.Items.Add((reader["NOME"].ToString()));
            }
            reader.Close();

            conexao.Desconectar();
        }

        private void listarTipoPagamento(object sender, EventArgs e)
        {
            conexao.Conectar();
            //Limpa a combo box
            tipoPagamentoCombo.Items.Clear();

            //Lista os tipos
            String query1 = "SELECT NOME FROM CX_TIPOPAGAMENTO";
            SqlDataReader reader = conexao.Pesquisa(query1);

            while (reader.Read())
            {
                tipoPagamentoCombo.Items.Add((reader["NOME"].ToString()));
            }
            reader.Close();

            conexao.Desconectar();
        }

        private void listarItens(object sender, EventArgs e)
        {
            conexao.Conectar();
            //Limpa a combo box
            itensCombo.Items.Clear();

            //Lista os tipos
            String query1 = "SELECT * FROM CX_ITEM";
            SqlDataReader reader = conexao.Pesquisa(query1);

            while (reader.Read())
            {
                itensCombo.Items.Add((reader["NOME"].ToString()));
            }

            reader.Close();
            conexao.Desconectar();
        }

        private void itensCombo_DropDownClosed(object sender, EventArgs e)
        {
            String item = "";

            Object selectedItem = itensCombo.SelectedItem;
            if ((selectedItem != null || checkBox.Checked))
            {
                //Transforma o item selecionado em String
                item = selectedItem.ToString();
                conexao.Conectar();

                //Limpa a combo box
                valorTotalBox.Text = "R$ 0,00";
                quantidadeBox.Text = "1";

                //Lista os tipos
                String query1 = "SELECT VALORUNITARIO FROM CX_ITEM WHERE NOME = '" + item + "'";
                SqlDataReader reader = conexao.Pesquisa(query1);

                while (reader.Read())
                {
                    String valorItemAntes = "";
                    valorTotalBox.Text = "R$ " + reader["VALORUNITARIO"].ToString();
                    valorItem = float.Parse(reader["VALORUNITARIO"].ToString());
                    valorItemAntes = reader["VALORUNITARIO"].ToString();
                    valorItemAntes = valorItemAntes.Replace(',', '.');
                }

                reader.Close();
                conexao.Desconectar();
            }
        }

        private void recalcularValorr(object sender, EventArgs e)
        {
            if (quantidadeBox.Text == "")
            {

            }
            else
            {
                if (checkBox.Checked)
                {
                    int quantidade = Convert.ToInt32(quantidadeBox.Text), valor = Convert.ToInt32(valorTotalBox.Text); ;
                    //faz a conta

                    float total = valor * quantidade;
                    //Adiciona na text box
                    valorTotalBox.Text = "R$ " + total.ToString();
                }
                else
                {
                    int quantidade = Convert.ToInt32(quantidadeBox.Text);
                    //faz a conta
                    float total = valorItem * quantidade;
                    //Adiciona na text box
                    valorTotalBox.Text = "R$ " + total.ToString();
                }
            }

        }

        private void atualizarTipoPagamento(object sender, EventArgs e)
        {
            conexao.Conectar();
            //SELECIONA O TIPO DE PAGAMENTO
            String tipoPagamento = tipoPagamentoCombo.Text;
            int quantidadeParcela = 0;
            String query5 = "SELECT * FROM CX_TIPOPAGAMENTO WHERE NOME = '" + tipoPagamento + "'";

            SqlDataReader reader9 = conexao.Pesquisa(query5);

            while (reader9.Read())
            {
                tipoPagamentoHandle = Convert.ToInt32(reader9["HANDLE"]);
                tipoPagamento = reader9["NOME"].ToString();
                quantidadeParcela = Convert.ToInt32(reader9["NUMEROPARCELA"]);
            }
            reader9.Close();
            if (valorTotalPedidoBox.Text == "")
            {

            }
            else
            {
                String query8 = "SELECT SUM(VALORTOTAL) VALORTOTAL FROM CX_ITEMPEDIDO WHERE PEDIDO = " + codigoBox.Text;
                SqlDataReader reader11 = conexao.Pesquisa(query8);
                decimal valorTotalPedido = 0;
                while (reader11.Read())
                {
                    valorTotalPedido = Convert.ToDecimal(reader11["VALORTOTAL"]);
                    valorTotalPedidoBox.Text = "R$ " + reader11["VALORTOTAL"].ToString();
                }

                valorTotalPedido = valorTotalPedido / quantidadeParcela;

                valorParcelaBox.Text = "R$ " + valorTotalPedido.ToString();
                reader11.Close();
            }
            conexao.Desconectar();
        }

        private void tipoMovimentacaoDrop(object sender, EventArgs e)
        {
            if (tipoMovimentacaoCombo.Text == "SIMPLES")
            {
                pessoaCombo.Enabled = false;
            }
            else
            {
                pessoaCombo.Enabled = true;
            }
        }

        private void keyDownf3Tipo(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F3)
            {
                CadastroItem cadastroItem = new CadastroItem();
                cadastroItem.ShowDialog();
            }
        }

        private void checkEvent(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                valorTotalBox.Enabled = true;
            }
            else
            {
                valorTotalBox.Enabled = false;
            }
        }

        //METODOS

        //REFRESH DATAGRIDVIEW
        public void RefreshDataGrid()
        {
            //Mostra a tabela
            BindingSource Binding = new BindingSource();
            // itemDataGridView.AutoGenerateColumns = true;
            String query = "SELECT ITEMNOME ITEM, QUANTIDADE, VALORTOTAL VALOR FROM CX_ITEMPEDIDO WHERE PEDIDO = " + codigoBox.Text;

            Binding.DataSource = conexao.DataTable(query);

            itemDataGridView.DataSource = Binding;
            itemDataGridView.Columns[0].Width = 845;
            itemDataGridView.Columns[1].Width = 200;
            itemDataGridView.Columns[2].Width = 250;
            itemDataGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            itemDataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            itemDataGridView.AllowUserToResizeRows = false;
        }
        //
        //Atualiza o valor da parcela
        public void AtualizaValorParcela(decimal valorTotalPedido, int quantidadeParcela)
        {
            valorTotalPedido = valorTotalPedido / quantidadeParcela;
            valorParcelaBox.Text = "R$ " + valorTotalPedido.ToString();
            checkBox.Checked = false;
            valorTotalBox.Enabled = false;
        }

        private void informarValorCheck(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                valorTotalBox.Enabled = true;
            }
            else
            {
                valorTotalBox.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(itemHandle != -1)
            {
                var result = MessageBox.Show("Você realmente deseja excluir este item?", "Excluir Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DeletarItem(itemHandle);
                    itemHandle = -1;
                    this.RefreshDataGrid();
                    //FALTA ATUALIZAR OS VALORES
                }
            }
            else
            {
                MessageBox.Show("Selecione um item para deletar");
            }
        }
       
        private void itemHandleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            conexao.Conectar();
            String itemNome = (itemDataGridView.CurrentRow.Cells[0].Value).ToString();
            int itemQuantidade = Convert.ToInt32(itemDataGridView.CurrentRow.Cells[1].Value);
            decimal itemValorTotal = Convert.ToDecimal(itemDataGridView.CurrentRow.Cells[2].Value);

            //Busca o handle do item pelo nome
            String query = "SELECT A.HANDLE, B.NOME FROM CX_ITEMPEDIDO A INNER JOIN CX_ITEM B ON B.HANDLE = A.ITEM AND A.VALORTOTAL = "+itemValorTotal+" AND A.PEDIDO = "+codigoBox.Text+" AND A.QUANTIDADE = "+itemQuantidade;
            SqlDataReader reader = conexao.Pesquisa(query);
            while (reader.Read())
            {
                itemHandle = Convert.ToInt32(reader["HANDLE"]);
            }
            //
            deletarButton.Enabled = true;
            conexao.Desconectar();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Você realmente deseja cancelar este pedido? Se você cancelar não será possível retorná-lo!", "Cancelar Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                conexao.Conectar();
                //Desabilita o form e encerra o pedido
                pessoaCombo.Enabled = false;
                formaPagamentoCombo.Enabled = false;
                tipoMovimentacaoCombo.Enabled = false;
                quantidadeBox.Enabled = false;
                valorTotalBox.Enabled = false;
                itensCombo.Enabled = false;
                checkBox.Enabled = false;
                adicionarItemButton.Enabled = false;
                deletarButton.Enabled = false;
                finalizarButton.Enabled = false;
                cancelarButton.Enabled = false;
                itemDataGridView.Enabled = false;
                //Cancela pedido
                String query1 = "UPDATE CX_PEDIDO SET STATUS = 2 WHERE HANDLE = "+codigoBox.Text;
                conexao.Inserir(query1);
                conexao.Desconectar();
                //ENCERA O FORM
                this.Text = "Pedido - Cancelado";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexao.Conectar();
            //Desabilita o form e encerra o pedido
            pessoaCombo.Enabled = false;
            formaPagamentoCombo.Enabled = false;
            tipoMovimentacaoCombo.Enabled = false;
            quantidadeBox.Enabled = false;
            valorTotalBox.Enabled = false;
            itensCombo.Enabled = false;
            checkBox.Enabled = false;
            adicionarItemButton.Enabled = false;
            deletarButton.Enabled = false;
            finalizarButton.Enabled = false;
            cancelarButton.Enabled = false;
            itemDataGridView.Enabled = false;

            String query1;

            query1 = "UPDATE CX_PEDIDO SET STATUS = 3, TIPOPAGAMENTO = "+tipoPagamentoHandle+", VALORTOTAL = "+ valorTotalPedidoBox.Text.Replace(',','.').Replace('R', ' ').Replace('$', ' ') +" WHERE HANDLE = "+codigoBox.Text;
            conexao.Inserir(query1);
            this.Text = "Pedido - Encerrado";
            conexao.Desconectar();
        }

        public void DeletarItem(int itemHandle)
        {
            conexao.Conectar();
            String query = "DELETE CX_ITEMPEDIDO WHERE HANDLE = " + itemHandle;
            conexao.Inserir(query);
            conexao.Desconectar();
        }
    }
}
