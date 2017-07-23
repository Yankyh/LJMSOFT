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

        public void limparCampos()
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EnderecoTextBox_TextChanged(object sender, EventArgs e)
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

            verificaJuridica(EhjuridicacheckBox);

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
                        int valida = validaCPF(CPFCNPJ); 
                        if (valida == 1)
                        {
                            String query1 = "INSERT INTO PS_PESSOA VALUES(" + "'" + nomePessoa + "'," + "'" + fone + "'," + "'" + email + "'," + "'" + CPFCNPJ + "'," + "'" + observacao + "'," + "'" + RG + "'," + "'" + juridica + "'" + ")";
                            conexao.Inserir(query1);

                            this.Hide();
                            BotoesGerais bg = new BotoesGerais();
                            bg.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("CPF não contem 11 digitos");
                        }
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

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuTela mt = new MenuTela();
            mt.ShowDialog();
            this.Close();

        }

        private void Limparbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroPessoa cp = new CadastroPessoa();
            cp.ShowDialog();
            this.Close();
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

        private int validaCPF(String cpf)
        {
            long cpfInteiro = 0;
            cpfInteiro = Convert.ToInt64(cpf);

            if (cpf.Length != 11)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private void verificaJuridica(CheckBox ehjuridica)
        {
            if (ehjuridica.Checked)
            {
                juridica = 1;
            }
            else
            {
                juridica = 0;
            }
            
        }

    }
}
