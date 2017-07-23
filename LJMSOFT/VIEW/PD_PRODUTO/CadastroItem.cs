using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LJMSOFT.VIEW.PD_PRODUTO;
using LJMSOFT.DAL;
using System.Data.SqlClient;

namespace LJMSOFT.VIEW.PD_PRODUTO
{
    public partial class CadastroItem : Form
    {
        Conexao conexao = new Conexao();
        public static int ehNovo = 0;
        public CadastroItem()
        {
            InitializeComponent();
            conexao.Conectar();

            //Preenche o combo box fornecedor
            String query = "SELECT NOME FROM PS_PESSOA";
            SqlDataReader reader1 = conexao.Pesquisa(query);
            while (reader1.Read())
            {
                fornecedorCombo.Items.Add((reader1["NOME"].ToString()));
            }
            reader1.Close();

            query = "SELECT NOME FROM PD_FAMILIA";
            SqlDataReader reader2 = conexao.Pesquisa(query);
            while (reader2.Read())
            {
                familiaCombo.Items.Add((reader2["NOME"].ToString()));
            }
            reader2.Close();



            int itemHandle = ListaProduto.getItemHandle();
            if(itemHandle > -1)
            {
                ehNovo = 1;
                 query = "SELECT A.HANDLE CÓDIGO, A.NOME NOME, A.VALORUNITARIO VALOR, A.UNIDADEMEDIDA UN, C.NOME FAMÍLIA, B.NOME FORNECEDOR, A.OBSERVACAO OBSERVAÇÃO " +
"FROM CX_ITEM A " +
" INNER JOIN PS_PESSOA B ON B.HANDLE = A.FORNECEDOR" +
" INNER JOIN PD_FAMILIA C ON C.HANDLE = A.FAMILIA" +
" WHERE A.HANDLE = " + itemHandle;
                SqlDataReader reader = conexao.Pesquisa(query);

                while (reader.Read())
                {
                    nomeBox.Text = reader["NOME"].ToString();
                    fornecedorCombo.Text = reader["FORNECEDOR"].ToString();
                    valorUnitarioBox.Text = reader["VALOR"].ToString();
                    familiaCombo.Text = reader["FAMÍLIA"].ToString();
                    unidadeMedidaCombo.Text = reader["UN"].ToString();
                    observacaoBox.Text = reader["OBSERVAÇÃO"].ToString();
                    codigoBox.Text = reader["CÓDIGO"].ToString(); 
                }

                cadastrarButton.Visible = false;
                editarButton.Visible = true;
                nomeBox.Enabled = false;
                fornecedorCombo.Enabled = false;
                valorUnitarioBox.Enabled = false;
                familiaCombo.Enabled = false;
                unidadeMedidaCombo.Enabled = false;
                observacaoBox.Enabled = false;
             


                reader.Close();
                conexao.Desconectar();
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void tipoPagamentoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void f3event(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                
                CadastroFamilia cadastroFamilia = new CadastroFamilia();
                cadastroFamilia.ShowDialog();

            }
        }

        private void CadastroItem_Load(object sender, EventArgs e)
        {

        }

        private void listarFamilia(object sender, EventArgs e)
        {
            familiaCombo.Items.Clear();
            conexao.Conectar();
            String query = "SELECT NOME FROM PD_FAMILIA";
            SqlDataReader reader = conexao.Pesquisa(query);

            while (reader.Read())
            {
                familiaCombo.Items.Add((reader["NOME"].ToString()));

            }
            reader.Close();
            conexao.Desconectar();
        }

        private void pessoaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listarFornecedor(object sender, EventArgs e)
        {
            conexao.Conectar();
            //Limpa a combo box
            fornecedorCombo.Items.Clear();

            //Lista os tipos
            String query1 = "SELECT NOME FROM PS_PESSOA";
            SqlDataReader reader = conexao.Pesquisa(query1);

            while (reader.Read())
            {
                fornecedorCombo.Items.Add((reader["NOME"].ToString()));
            }

            reader.Close();
            conexao.Desconectar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cadastrar novo item
            //VALIDAÇÕES
            int familiaHandle = 0, fornecedorHandle = 0;
            if(nomeBox.Text != "")
            {
                if(familiaCombo.Text != "")
                {
                    if(valorUnitarioBox.Text != "")
                    {
                        if(unidadeMedidaCombo.Text != "")
                        {
                            conexao.Conectar();
                            String query = "SELECT HANDLE FROM PD_FAMILIA WHERE NOME = '"+familiaCombo.Text+"'";
                            SqlDataReader reader = conexao.Pesquisa(query);
                            while (reader.Read())
                            {
                                familiaHandle = Convert.ToInt32(reader["HANDLE"]);
                            }
                            reader.Close();

                            query = "SELECT HANDLE FROM PS_PESSOA WHERE NOME = '" + fornecedorCombo.Text + "'";
                            reader = conexao.Pesquisa(query);
                            while (reader.Read())
                            {
                                fornecedorHandle = Convert.ToInt32(reader["HANDLE"]);
                            }
                            reader.Close();
                            String valorUnitario = valorUnitarioBox.Text.Replace(",", ".");
                            if(ehNovo == 1)
                            {
                                query = "UPDATE CX_ITEM SET NOME = '" + nomeBox.Text + "', FAMILIA = "+familiaHandle+", VALORUNITARIO = "+valorUnitario+", FORNECEDOR = '"+fornecedorHandle+"', UNIDADEMEDIDA = '"+unidadeMedidaCombo.Text+ "', OBSERVACAO = '"+observacaoBox.Text+"' WHERE HANDLE = "+codigoBox.Text;
                                MessageBox.Show(query);
                                conexao.Inserir(query);
                            }
                            else
                            {
                                query = "INSERT INTO CX_ITEM (NOME, FAMILIA, VALORUNITARIO, FORNECEDOR, UNIDADEMEDIDA, OBSERVACAO) VALUES ('" + nomeBox.Text + "', " + familiaHandle + ", " + valorUnitario + ", '" + fornecedorHandle + "', '" + unidadeMedidaCombo.Text + "', '" + observacaoBox.Text + "')";
                                conexao.Inserir(query);
                                MessageBox.Show("Item cadastrado com sucesso");
                                String query3 = "SELECT MAX(HANDLE) HANDLE FROM CX_ITEM";
                                SqlDataReader reader2 = conexao.Pesquisa(query3);
                                while (reader2.Read())
                                {
                                    codigoBox.Text = reader2["HANDLE"].ToString();
                                }
                                reader2.Close();
                            }
                        

                            nomeBox.Enabled = false;
                            familiaCombo.Enabled = false;
                            valorUnitarioBox.Enabled = false;
                            unidadeMedidaCombo.Enabled = false;
                            fornecedorCombo.Enabled = false;
                            observacaoBox.Enabled = false;
                            cadastrarButton.Visible = false;
                            editarButton.Visible = false;




                            conexao.Desconectar();
                        }
                        else
                        {
                            MessageBox.Show("Preencha o campo valor unidade de medida");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Preencha o campo valor unitário");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha o campo familia");
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo nome");
            }


        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            cadastrarButton.Visible = true;
            editarButton.Visible = false;

            nomeBox.Enabled = true;
            familiaCombo.Enabled = true;
            valorUnitarioBox.Enabled = true;
            unidadeMedidaCombo.Enabled = true;
            fornecedorCombo.Enabled = true;
            observacaoBox.Enabled = true;

        }
    }
}
