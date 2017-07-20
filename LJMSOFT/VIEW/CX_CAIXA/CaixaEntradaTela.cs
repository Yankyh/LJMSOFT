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

namespace LJMSOFT.VIEW.CX_CAIXA
{
    public partial class CaixaEntradaTela : Form
    {
        Conexao conexao = new Conexao();
        public CaixaEntradaTela()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarItem listarItem = new ListarItem();
            listarItem.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listarCliente(object sender, EventArgs e)
        {
            conexao.Conectar();
            //Limpa a combo box
            pessoaCombo.Items.Clear();

            //Lista os tipos
            String query1 = "SELECT NOME FROM US_TIPO";
            query1 = MetodoQuery.StatusNotIn(query1);


            SqlDataReader reader = conexao.Pesquisa(query1);


            while (reader.Read())
            {
                pessoaCombo.Items.Add((reader["NOME"].ToString()));
            }

            reader.Close();
            conexao.Desconectar();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
