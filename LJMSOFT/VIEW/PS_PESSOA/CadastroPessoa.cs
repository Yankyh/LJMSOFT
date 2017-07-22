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
        static private String nomePessoa;
        static private String CPFCNPJ;
        static private String RG;
        static private String fone;
        static private String email;
        static private String observacao;
        static private int juridica;


        public CadastroPessoa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
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

        private void Cadastrarbutton_Click_1(object sender, EventArgs e)
        {
            conexao.Conectar();
            nomePessoa = NomePessoatextBox.Text;
            CPFCNPJ = CNJPCPFtextBox.Text;
            RG = RGtextBox.Text;
            fone = FonetextBox.Text;
            email = EmailtextBox.Text;
            observacao = ObservacaoTextBox.Text;


            if (EhjuridicacheckBox.Checked)
            {
                juridica = 1;
            }
            else
            {
                juridica = 0;
            }

            String query = "SELECT HANDLE FROM PS_PESSOA WHERE CPFCNPJ = '" + CPFCNPJ + "' OR RG = '" + RG + "'";

            SqlDataReader VerificaCPF = conexao.Pesquisa(query);

            if (VerificaCPF != null)
            {
                MessageBox.Show("CPF OU RG JA CADASTRADOS");
            }
            else
            {
                String query1 = "INSERT INTO PS_PESSOA VALUES(" + "'" + nomePessoa + "'," + "'" + fone + "'," + "'" + email + "'," + "'" + CPFCNPJ + "'," + "'" + observacao + "'," + "'" + RG + "'," + "'" + juridica + "'" + ")";
                conexao.Inserir(query1);
            }

            conexao.Desconectar();
        }
    }
}
