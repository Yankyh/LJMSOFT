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
namespace LJMSOFT.VIEW.PD_PRODUTO
{
    public partial class ListaProduto : Form
    {
        Conexao conexao = new Conexao();
        private static String row = "";
        public static int itemHandle = -1;

        public ListaProduto()
        {
            InitializeComponent();
            this.Refresh();
          
           
        }


        //metodo refresh
        public void Refresh()
        {
            //Mostra a tabela
            conexao.Conectar();

            BindingSource Binding = new BindingSource();
            String query = "SELECT A.HANDLE CÓDIGO, A.NOME, A.VALORUNITARIO VALOR, A.UNIDADEMEDIDA UN, C.NOME FAMÍLIA, B.NOME FORNECEDOR, A.OBSERVACAO OBSERVAÇÃO " +
                "FROM CX_ITEM A " +
                " INNER JOIN PS_PESSOA B ON B.HANDLE = A.FORNECEDOR" +
                " INNER JOIN PD_FAMILIA C ON C.HANDLE = A.FAMILIA";

            Binding.DataSource = conexao.DataTable(query);

            itemDataGridView.DataSource = Binding;
            itemDataGridView.Columns[0].Width = 100;
            itemDataGridView.Columns[1].Width = 300;
            itemDataGridView.Columns[2].Width = 100;
            itemDataGridView.Columns[3].Width = 75;
            itemDataGridView.Columns[4].Width = 150;
            itemDataGridView.Columns[5].Width = 300;
            itemDataGridView.Columns[6].Width = 300;
            itemDataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            itemDataGridView.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            itemDataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            itemDataGridView.AllowUserToResizeRows = false;

            conexao.Desconectar();

        }



        private void ListaProduto_Load(object sender, EventArgs e)
        {

        }

        private void selecionaRow(object sender, DataGridViewCellMouseEventArgs e)
        {
            row = itemDataGridView.Columns[e.ColumnIndex].HeaderText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexao.Conectar();

            String pesquisa = pesquisaBox.Text;
            String query = "";

            if(pesquisa == "")
            {
                query = "SELECT A.HANDLE CÓDIGO, A.NOME, A.VALORUNITARIO VALOR, A.UNIDADEMEDIDA UN, C.NOME FAMÍLIA, B.NOME FORNECEDOR, A.OBSERVACAO OBSERVAÇÃO " +
               "FROM CX_ITEM A " +
               " INNER JOIN PS_PESSOA B ON B.HANDLE = A.FORNECEDOR" +
               " INNER JOIN PD_FAMILIA C ON C.HANDLE = A.FAMILIA";
            }
            else
            {

          

            if (row == "NOME")
            {
                row = "A.NOME";
                pesquisa = "'" + pesquisa + "'";

            }
            else
            {
                row = "A.HANDLE";
            }
            query = "SELECT A.HANDLE CÓDIGO, A.NOME, A.VALORUNITARIO VALOR, A.UNIDADEMEDIDA UN, C.NOME FAMÍLIA, B.NOME FORNECEDOR, A.OBSERVACAO OBSERVAÇÃO " +
"FROM CX_ITEM A " +
" INNER JOIN PS_PESSOA B ON B.HANDLE = A.FORNECEDOR" +
" INNER JOIN PD_FAMILIA C ON C.HANDLE = A.FAMILIA" +
" WHERE " + row + " = " + pesquisa;
            }
          

            BindingSource Binding = new BindingSource();
            Binding.DataSource = conexao.DataTable(query);
            itemDataGridView.DataSource = Binding;
            itemDataGridView.Columns[0].Width = 100;
            itemDataGridView.Columns[1].Width = 300;
            itemDataGridView.Columns[2].Width = 100;
            itemDataGridView.Columns[3].Width = 75;
            itemDataGridView.Columns[4].Width = 150;
            itemDataGridView.Columns[5].Width = 300;
            itemDataGridView.Columns[6].Width = 300;
            itemDataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            itemDataGridView.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            itemDataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            itemDataGridView.AllowUserToResizeRows = false;


            conexao.Desconectar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroItem cadastroItem = new CadastroItem();
            cadastroItem.ShowDialog();
        }

        private void cellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            itemHandle  = Convert.ToInt32(itemDataGridView.CurrentRow.Cells[0].Value);
            CadastroItem cadastroItem = new CadastroItem();
            cadastroItem.ShowDialog();
        }

        //Passar o handle
        public static int getItemHandle()
        {
            return itemHandle;
        }

        private void ListaProduto_Activated(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
