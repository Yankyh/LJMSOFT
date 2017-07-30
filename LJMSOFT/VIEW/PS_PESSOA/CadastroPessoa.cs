using LJMSOFT.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LJMSOFT.VIEW.PS_PESSOA
{
    public partial class CadastroPessoa : Form
    {
        Conexao conexao = new Conexao();

        static private Boolean validaCPFCNPJ = true;
        static private int juridica; // Juridica = 1 e Física = 0
        static private Boolean ok = true; // 1 = CPF/CNPJ ja cadastrado; 2 = Campo obrigatório não preenchido NOME; 3 = Campo obrigatório não preenchido CNPJ/CPF; 4 = Erro não especificado
        static private String nomeIgual;
        static private int controleStatus;



      
        public CadastroPessoa()
        {
            InitializeComponent();
        }

        // Métodos referente aos botões
        private void Cadastrarbutton_Click_1(object sender, EventArgs e)
        {
            conexao.Conectar();
            int x = existeCNPJCPF();

            if (x == 1)
            {
                MessageBox.Show("CPF/CNPJ ou RG já cadastrados para outra Pessoa"
                               + "\n Pessoa que possui estes dados: " + nomeIgual);
                x = 0;
            }
            else
            {

                Boolean teste = campoVazio();
                if (teste = false) { 
                        if (EhjuridicacheckBox.Checked)
                        {
                            onzeDigitosCNPJ();
                            juridica = 1;
                        }
                        else
                        {
                            onzeDigitosCPF();
                            juridica = 0;
                        }

                    if (validaCPFCNPJ != false)
                    {
                        String query1 = "INSERT INTO PS_PESSOA VALUES(" + "'" + NomePessoatextBox.Text + "'," + "'" + FonetextBox.Text + "'," + "'" + EmailtextBox.Text + "'," + "'" + CNJPCPFtextBox.Text + "'," + "'" + ObservacaoTextBox.Text + "'," + "'" + RGtextBox.Text + "'," + "'" + juridica + "'" + ")";

                        conexao.Inserir(query1);

                        this.Hide();
                        BotoesGerais bg = new BotoesGerais();
                        bg.ShowDialog();
                    }                
                }
                else
                {
                    MessageBox.Show("Campo obrigatório");
                }
            }
            conexao.Desconectar();
        }
        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();

        }
        private void Limparbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroPessoa cp = new CadastroPessoa();
            cp.ShowDialog();
            this.Close();
        }

        // Métodos de validações
        private void onzeDigitosCPF()
        {
            String CPF = CNJPCPFtextBox.Text;

            if (CPF.Length != 11)
            {
                MessageBox.Show("CPF inválido, não possui 11 caracteres");
                validaCPFCNPJ = false;

            }

        }
        private void onzeDigitosCNPJ()
        {
            String cnpj = CNJPCPFtextBox.Text;

            if (cnpj.Length != 14)
            {
                MessageBox.Show("CNPJ inválido, não possui 14 caracteres");
                validaCPFCNPJ = false;
            }


        }
        private int    existeCNPJCPF()
        {
            String query = "SELECT HANDLE, NOME FROM PS_PESSOA WHERE CPFCNPJ = '" + CNJPCPFtextBox.Text + "'";
            SqlDataReader reader = conexao.Pesquisa(query);

            while (reader.Read())
            {
                nomeIgual = reader["NOME"].ToString();
                reader.Close();
                return 1;
            }
            reader.Close();
            return 0;

        }
        private void EhjuridicacheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EhjuridicacheckBox.Checked)
            {
                RGtextBox.Enabled = false;

            }
            else
            {
                RGtextBox.Enabled = true;

            }
        }
        private Boolean campoVazio()
        {
            if (NomePessoatextBox is null || CNJPCPFtextBox is null)
            {
                return true;
            }
            else
                return false;


        }
        private void resetStatus()
        {
            controleStatus = 0;
        }

        // Métodos não utilizados mas obrigatórios p/ o FORM //
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxNomePessoa_TextChanged(object sender, EventArgs e)
        {

        }
        private void CPFCNPJlabel_Click(object sender, EventArgs e)
        {

        }
        private void Cadastrarbutton_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void EnderecoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    }

}
