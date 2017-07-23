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
        static private String nomeIgual;
        

        // 1 = CPF/CNPJ ja cadastrado; 2 = Campo obrigatório não preenchido NOME; 3 = Campo obrigatório não preenchido CNPJ/CPF; 4 = Erro não especificado
        static private Boolean ok = true;

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

            String handlePessoa;



            if (EhjuridicacheckBox.Checked)
            {
                juridica = 1;
            }
            else
            {
                juridica = 0;
            }

            String query = "SELECT HANDLE, NOME FROM PS_PESSOA WHERE CPFCNPJ = '" + CPFCNPJ + "' OR RG = '" + RG + "'";
            SqlDataReader reader = conexao.Pesquisa(query);

            while (reader.Read())
            {
                ok = false;
                nomeIgual = reader["NOME"].ToString();
            }

            if (ok.Equals(false))
            {
                MessageBox.Show("CPF/CNPJ ou RG já cadastrados para outra Pessoa"
                               + "\n Pessoa que possui estes dados: " + nomeIgual);  
            }
            else
            {
                reader.Close();
                if (nomePessoa != "")
                {
                    if (CPFCNPJ != "")
                    {
                        String query1 = "INSERT INTO PS_PESSOA VALUES(" + "'" + nomePessoa + "'," + "'" + fone + "'," + "'" + email + "'," + "'" + CPFCNPJ + "'," + "'" + observacao + "'," + "'" + RG + "'," + "'" + juridica + "'" + ")";
                        conexao.Inserir(query1);

                        //Inserindo o endereço
                        String query2 = "SELECT MAX(HANDLE) FROM PS_PESSOA";
                        conexao.Pesquisa(query2);

                        SqlDataReader reader1 = conexao.Pesquisa(query);
                        handlePessoa = reader1["HANDLE"].ToString();
                        reader1.Close();

                        Convert.ToInt32(handlePessoa);

                        

                        String endereco = EnderecoTextBox.Text;
                        String cep = CEPTextBox.Text;
                        String bairro = BairroTextBox3.Text;
                        String cidade = CidadeTextBox3.Text;
                        String referencia = ReferenciaTextBox.Text;
                        String num = NumeroEnderecoTextBox.Text;

                        String query3= "INSERT INTO PS_PESSOAENDERECO VALUES(" + "'" + bairro + "'," + "'" + cidade + "'," + "'" + cep + "'," + "'" + handlePessoa + "'," + "'" + referencia + "'," + "'" + num + ")";
                        conexao.Inserir(query3);

                        

                    }
                    else
                    {
                        MessageBox.Show("Campo Obrigatório não preenchido:  CPF/CNPJ ");
                    }
                }
                else
                {
                    MessageBox.Show("Campo obrigatório não preenchido: NOME ");
                }
            }










                
            

            conexao.Desconectar();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EnderecoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
