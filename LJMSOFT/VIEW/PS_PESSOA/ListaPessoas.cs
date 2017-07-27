using LJMSOFT.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LJMSOFT.VIEW.PS_PESSOA
{
    public partial class ListaPessoas : Form
    {
        private static int handlePessoa = -1;
        private static String row = "";
        Conexao conecta = new Conexao();
        public ListaPessoas()
        {
            InitializeComponent();
            refresh();
        }

        public void refresh()
        {
            //Mostra a tabela
            conecta.Conectar();

            BindingSource Binding = new BindingSource();
            String query = "SELECT TOP 100 A.HANDLE CODIGO, A.NOME, A.CPFCNPJ 'CPF OU CNPJ', A.TELEFONE, A.EMAIL, A.RG FROM PS_PESSOA A ";
                                

            Binding.DataSource = conecta.DataTable(query);

            PessoadataGridView1.DataSource = Binding;
            PessoadataGridView1.Columns[0].Width = 300;
            PessoadataGridView1.Columns[1].Width = 120;
            PessoadataGridView1.Columns[2].Width = 100;
            PessoadataGridView1.Columns[3].Width = 250;
            PessoadataGridView1.Columns[4].Width = 172;
            PessoadataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            PessoadataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PessoadataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            PessoadataGridView1.AllowUserToResizeRows = false;

            conecta.Desconectar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CadastroPessoa cp = new CadastroPessoa();
            cp.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ListaPessoas_doubleClick(object sender, DataGridViewCellEventArgs e)
        {
            handlePessoa = Convert.ToInt32(PessoadataGridView1.CurrentRow.Cells[0].Value);
            CadastroPessoa cp = new CadastroPessoa();
            cp.ShowDialog();
        }

        private void selecionaRow(object sender, DataGridViewCellMouseEventArgs e)
        {
            row = PessoadataGridView1.Columns[e.ColumnIndex].HeaderText;
        }

        public static int getHandlePessoa()
        {
            return handlePessoa;
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            this.refresh();
        }
    }
}
