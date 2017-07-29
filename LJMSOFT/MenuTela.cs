using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LJMSOFT.VIEW.CX_CAIXA;
using LJMSOFT.VIEW.AG_AGENDA;
using LJMSOFT.VIEW.PS_PESSOA;
using LJMSOFT.VIEW.PD_PRODUTO;
using LJMSOFT.VIEW.RL_RELATORIO;
using LJMSOFT.DAL;
using LJMSOFT.VIEW;
using System.Globalization;

namespace LJMSOFT
{
    public partial class MenuTela : Form
    {
        Conexao conexao = new Conexao();
        public MenuTela()
        {
            InitializeComponent();
            menuPanel.Visible = false;
            CreateDashBoard1();
            CreateDashBoard2();
        }

        public void CreateDashBoard1()
        {
            conexao.Conectar();
            //Cria o dashboard1
            String query = "SELECT B.NOME PESSOA, A.VALORTOTAL VALOR, C.NOME TIPO, D.NOME FORMA, A.DATAPEDIDO DATA" +
                             " FROM CX_PEDIDO A " +
                            " LEFT JOIN PS_PESSOA B ON B.HANDLE = A.PESSOA" +
                            " INNER JOIN CX_TIPOPAGAMENTO C ON C.HANDLE = A.TIPOPAGAMENTO" +
                            " INNER JOIN CX_FORMAPAGAMENTO D ON D.HANDLE = A.FORMAPAGAMENTO";

            BindingSource Binding = new BindingSource();
            Binding.DataSource = conexao.DataTable(query);
            dashBoard1.DataSource = Binding;
            dashBoard1.Columns[0].Width = 250;
            dashBoard1.Columns[2].Width = 123;
            dashBoard1.Columns[3].Width = 130;
            dashBoard1.Columns[4].Width = 170;
            dashBoard1.AllowUserToResizeRows = false;
            dashBoard1.AllowUserToAddRows = false;

            conexao.Desconectar();
        }
        public void CreateDashBoard2()
        {
            conexao.Conectar();
            //Cria o dashboard1
            String query = "SELECT SUM(A.VALORTOTAL) HOJE" +
                " FROM CX_PEDIDO A WHERE A.DATAPEDIDO LIKE FORMAT(GETDATE(), 'yyyy-MM-dd', 'en-us') + '%'";
            String query2 = "SELECT SUM(A.VALORTOTAL) ONTEM " +
                " FROM CX_PEDIDO A WHERE A.DATAPEDIDO LIKE FORMAT(GETDATE() - 1, 'yyyy-MM-dd', 'en-us') + '%'";

            BindingSource Binding = new BindingSource();
            Binding.DataSource = conexao.DataTable(query);
            dashBoard2.DataSource = Binding;
            dashBoard2.AllowUserToResizeRows = false;
            dashBoard2.AllowUserToAddRows = false;
            dashBoard2.Columns[0].Width = 243;
            dashBoard2.RowTemplate.Height = 46;
            dashBoard2.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dashBoard2.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            BindingSource Binding2 = new BindingSource();
            Binding2.DataSource = conexao.DataTable(query2);
            dashBoard3.DataSource = Binding2;
            dashBoard3.AllowUserToResizeRows = false;
            dashBoard3.AllowUserToAddRows = false;
            dashBoard3.Columns[0].Width = 240;
            dashBoard3.RowTemplate.Height = 46;
            dashBoard3.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dashBoard3.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            conexao.Desconectar();
        }




        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaixaTela caixaTela = new CaixaTela();
            caixaTela.ShowDialog();
        }


        private void treeView1_Click(object sender, EventArgs e)
        {
            MenuControl menuControl = new MenuControl();
            if (menuTreeView.SelectedNode == null)
            {

            }
            else
            {
                String node = menuTreeView.SelectedNode.Text;
                menuControl.Menu(node);
            }


        }

        private void menuTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (menuTreeView.Visible == false)
            {
                menuTreeView.Visible = true;
                menuPanel.Visible = true;
            }
            else
            {
                menuTreeView.Visible = false;
                menuPanel.Visible = false;
            }

        }

        private void Provisoriobutton_Click(object sender, EventArgs e)
        {
            CadastroPessoa cp = new CadastroPessoa();
            cp.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formOrcamentoRelatorio orcamento = new formOrcamentoRelatorio();
            orcamento.ShowDialog();
        }

        private void refreshDashboards(object sender, EventArgs e)
        {
            CreateDashBoard1();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MenuTela_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashBoard2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
