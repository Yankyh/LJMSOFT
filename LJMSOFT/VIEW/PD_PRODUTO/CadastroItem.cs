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
        public CadastroItem()
        {
            InitializeComponent();
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
                            query = "INSERT INTO CX_ITEM (NOME, FAMILIA, VALORUNITARIO, FORNECEDOR, UNIDADEMEDIDA, OBSERVACAO) VALUES ('"+nomeBox.Text+"', "+familiaHandle+", " + valorUnitario + ", '"+fornecedorHandle+"', '"+unidadeMedidaCombo.Text+"', '"+ observacaoBox.Text+"')";
                            conexao.Inserir(query);
                            MessageBox.Show("Item cadastrado com sucesso");

                            nomeBox.Enabled = false;
                            familiaCombo.Enabled = false;
                            valorUnitarioBox.Enabled = false;
                            unidadeMedidaCombo.Enabled = false;
                            fornecedorCombo.Enabled = false;
                            observacaoBox.Enabled = false;
                            cadastrarButton.Enabled = false;
                            cancelarButton.Enabled = false;
                            

                            String query3 = "SELECT MAX(HANDLE) HANDLE FROM CX_ITEM";
                            SqlDataReader reader2 = conexao.Pesquisa(query3);
                            while (reader2.Read())
                            {
                                codigoBox.Text = reader2["HANDLE"].ToString();
                            }
                            reader2.Close();
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
    }
}
