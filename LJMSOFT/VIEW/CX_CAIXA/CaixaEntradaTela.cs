﻿using System;
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
        static int quantidadeItem = 1, count = 0;
        String item, valorTotal = "";

        public CaixaEntradaTela()
        {
            InitializeComponent();
            quantidadeItem = 1;
            count = 0;
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
            conexao.Conectar();

            quantidadeItem.ToString();
            String item = itensCombo.Text;
            int quantidade = Convert.ToInt32(quantidadeBox.Text);
            valorTotal = valorTotalBox.Text.Replace(',','.');

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

            while (reader3.Read())
            {
                pessoaNome = reader3["HANDLE"].ToString();
            }
            reader3.Close();
            String codigoPedido = codigoBox.Text;

            if (count == 0)
            {
                pessoaCombo.Enabled = false;
                formaPagamentoCombo.Enabled = false;
                
                //Cria um pedido
                String query1 = "INSERT INTO CX_PEDIDO (ATIVO) VALUES (1)";
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
               String query6 = "INSERT INTO CX_ITEMPEDIDO (ITEM, QUANTIDADE, VALORTOTAL, PESSOA, PEDIDO, ITEMNOME) VALUES ("+item+", "+quantidadeItem+", "+valorTotal+", "+pessoaNome+", "+codigoBox.Text+", '"+nomeItem+"')";
                MessageBox.Show(query6);
                conexao.Inserir(query6);
            }
            else
            {
                String query6 = "INSERT INTO CX_ITEMPEDIDO (ITEM, QUANTIDADE, VALORTOTAL, PESSOA, PEDIDO, ITEMNOME) VALUES (" + item + ", " + quantidadeItem + ", '" + valorTotal + "', " + pessoaNome + ", " + codigoBox.Text + ", '" + nomeItem + "')";
                conexao.Inserir(query6);
            }

           
            BindingSource Binding = new BindingSource();
           // itemDataGridView.AutoGenerateColumns = true;
            String query = "SELECT ITEMNOME ITEM, QUANTIDADE, VALORTOTAL VALOR FROM CX_ITEMPEDIDO WHERE PEDIDO = "+codigoBox.Text;
           
            Binding.DataSource = conexao.DataTable(query);
      
            itemDataGridView.DataSource = Binding;
            itemDataGridView.Columns[0].Width = 507;
            itemDataGridView.Columns[1].Width = 200;
            itemDataGridView.Columns[2].Width = 250;
            itemDataGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            itemDataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            itemDataGridView.AllowUserToResizeRows = false;






            String query8 = "SELECT SUM(VALORTOTAL) VALORTOTAL FROM CX_ITEMPEDIDO WHERE PEDIDO = " + codigoBox.Text;
            SqlDataReader reader4 = conexao.Pesquisa(query8);

            while (reader4.Read())
            {
                valorTotalPedidoBox.Text = reader4["VALORTOTAL"].ToString();
            }
            


             
            //Adiciona o primeiro item 


            /*BindingSource Binding = new BindingSource();
            itemDataGridView.AutoGenerateColumns = true;
            String query = "SELECT * FROM US_PESSOA";
            Binding.DataSource = conexao.DataTable(query);
            itemDataGridView.DataSource = Binding;
            itemDataGridView.AllowUserToResizeRows = false;*/

            conexao.Desconectar();

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
            quantidadeBox.Text = "1";
            //Lista os tipos
            String query1 = "SELECT VALOR FROM CX_ITEM WHERE NOME = '"+item+"'";

            SqlDataReader reader = conexao.Pesquisa(query1);
            float teste = 0;
            while (reader.Read())
            {
                String valorItemAntes = "";
                valorTotalBox.Text = reader["VALOR"].ToString();
                valorItem = float.Parse(valorTotalBox.Text);
                valorItemAntes = reader["VALOR"].ToString();
                valorItemAntes = valorItemAntes.Replace(',','.');
            }
            

            reader.Close();
            conexao.Desconectar();

        }

        private void recalcularValor(object sender, EventArgs e)
        {
  
        }

        private void recalcularValorr(object sender, EventArgs e)
        {
            if(quantidadeBox.Text == "")
            {

            }
            else
            {
                int quantidade = Convert.ToInt32(quantidadeBox.Text);
                //faz a conta
                float total = valorItem * quantidade;
                //Adiciona na text box
                valorTotalBox.Text = total.ToString();
            }
    
        }

        private void itemDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void informarValorCheck(object sender, EventArgs e)
        {
           if(checkBox1.Checked == true)
            {
                valorTotalBox.Enabled = true;
            }
            else
            {
                valorTotalBox.Enabled = false;
            }
        }
    }
}
