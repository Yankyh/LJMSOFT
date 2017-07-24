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
            String query = "SELECT TOP 100 A.NOME, A.CPFCNPJ 'CPF OU CNPJ', A.TELEFONE, A.EMAIL, A.RG, B.BAIRRO, B.CEP FROM PS_PESSOA A " +
                                "LEFT JOIN PS_PESSOAENDERECO B ON B.PESSOA = A.HANDLE";

            Binding.DataSource = conecta.DataTable(query);

            dataGridView1.DataSource = Binding;
            dataGridView1.Columns[0].Width = 300;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 250;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 180;
            dataGridView1.Columns[6].Width = 102;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.AllowUserToResizeRows = false;

            conecta.Desconectar();
        }
    }
}
