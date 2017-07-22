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

namespace LJMSOFT.VIEW.PD_PRODUTO
{
    public partial class CadastroFamilia : Form
    {
        Conexao conexao = new Conexao();
        public CadastroFamilia()
        {
            InitializeComponent();
        }

        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            nomeBox.Enabled = false;
            cadastrarButton.Enabled = false;
            cancelarButton.Enabled = false;

            if(nomeBox.Text != "")
            {
                
                conexao.Conectar();

                String query = "INSERT INTO PD_FAMILIA (NOME) VALUES ('"+nomeBox.Text+"')";
                conexao.Inserir(query);

                MessageBox.Show("Cadastrado");
                conexao.Desconectar();
                conexao.Conectar();
                String query2 = "SELECT MAX(HANDLE) FROM PD_FAMILIA";
                conexao.Pesquisa(query2);
                SqlDataReader reader12 = conexao.Pesquisa(query2);

                while (reader12.Read())
                {
                    codigoBox.Text = reader12["HANDLE"].ToString();
                  
                }
                reader12.Close();

                conexao.Desconectar();

            }
          




        }
    }
}