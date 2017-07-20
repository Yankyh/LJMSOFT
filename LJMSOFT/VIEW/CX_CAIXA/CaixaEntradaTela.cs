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
       static float valorItem = 0;
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
            String query1 = "SELECT NOME FROM PS_PESSOA";
           


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

        private void selecionarItem(object sender, EventArgs e)
        {
          
        }

        private void itensCombo_DropDownClosed(object sender, EventArgs e)
        {
          
            String item = "";


            Object selectedItem = itensCombo.SelectedItem;
            if (selectedItem == null)
            {

            }
            else
            {
                item = selectedItem.ToString();
            }

            conexao.Conectar();
            //Limpa a combo box

            valorTotalBox.Text = "";
            quantidadeRoll.Value = 1;
            //Lista os tipos
            String query1 = "SELECT VALOR FROM CX_ITEM WHERE NOME = '"+item+"'";

            SqlDataReader reader = conexao.Pesquisa(query1);

            while (reader.Read())
            {
                valorTotalBox.Text = reader["VALOR"].ToString();
                valorItem = float.Parse(reader["VALOR"].ToString());
            }
            

            reader.Close();
            conexao.Desconectar();

        }

        private void recalcularValor(object sender, EventArgs e)
        {
            String valor2 = "";


            decimal valor = quantidadeRoll.Value;
            valor2 = valor.ToString();
            int valor3 = Convert.ToInt32(valor2);
            float total = valorItem * valor3;
            valorTotalBox.Text = total.ToString();
        }
    }
}
