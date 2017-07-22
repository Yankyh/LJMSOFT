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
            if(nomeBox.Text != "")
            {
                if(familiaCombo.Text != "")
                {
                    if(valorUnitarioBox.Text != "")
                    {
                        if(unidadeMedidaCombo.Text != "")
                        {

                            String query = "INSERT INTO CX_ITEM (NOME";



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
