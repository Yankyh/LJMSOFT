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
            this.CreateDashBoard1();
            this.CreateDashBoard2();
        }

        public void CreateDashBoard1()
        {
            conexao.Conectar();
            //Cria o dashboard1

            String query = "SELECT B.NOME PESSOA, A.VALORTOTAL VALOR, C.NOME TIPO, D.NOME FORMA, FORMAT(A.DATAPEDIDO, 'dd/MM/yy') DATA, E.NOME TIP  " +
                             " FROM CX_PEDIDO A" +
                            " LEFT JOIN PS_PESSOA B ON B.HANDLE = A.PESSOA" +
                            " INNER JOIN CX_TIPOPAGAMENTO C ON C.HANDLE = A.TIPOPAGAMENTO" +
                            " INNER JOIN CX_FORMAPAGAMENTO D ON D.HANDLE = A.FORMAPAGAMENTO" +
                            " INNER JOIN CX_TIPOMOVIMENTACAO E ON E.HANDLE = A.TIPOMOVIMENTACAO" +
                            " ORDER BY DATAPEDIDO DESC";

            BindingSource Binding = new BindingSource();
            Binding.DataSource = conexao.DataTable(query);

            dashBoard1.DataSource = Binding;
            dashBoard1.Columns[0].Width = 300;
            dashBoard1.Columns[2].Width = 90;
            dashBoard1.Columns[3].Width = 130;
            dashBoard1.Columns[4].Width = 90;
            dashBoard1.AllowUserToResizeRows = false;

            conexao.Desconectar();
        }
        public void CreateDashBoard2()
        {
            conexao.Conectar();
            //Cria o dashboard1
            String query = "SELECT SUM(A.VALORTOTAL) HOJE" +
                " FROM CX_PEDIDO A WHERE A.DATAPEDIDO LIKE FORMAT(GETDATE(), 'yyyy-MM-dd', 'en-us') + '%'" +
                " AND A.TIPOMOVIMENTACAO = 1";
            String query2 = "SELECT SUM(A.VALORTOTAL) ONTEM " +
                " FROM CX_PEDIDO A WHERE A.DATAPEDIDO LIKE FORMAT(GETDATE() - 1, 'yyyy-MM-dd', 'en-us') + '%'" +
                " AND A.TIPOMOVIMENTACAO = 1";
            String query3 = "SELECT SUM(A.VALORTOTAL) MÊS " +
             " FROM CX_PEDIDO A WHERE 1=2" +
             " AND A.TIPOMOVIMENTACAO = 1";
            String query4 = "SELECT SUM(A.VALORTOTAL) HOJE " +
             " FROM CX_PEDIDO A WHERE A.DATAPEDIDO LIKE FORMAT(GETDATE(), 'yyyy-MM-dd', 'en-us') + '%'" +
             " AND A.TIPOMOVIMENTACAO = 2";
            String query5 = "SELECT SUM(A.VALORTOTAL) ONTEM " +
            " FROM CX_PEDIDO A WHERE A.DATAPEDIDO LIKE FORMAT(GETDATE() - 1, 'yyyy-MM-dd', 'en-us') + '%'" +
            " AND A.TIPOMOVIMENTACAO = 2";
            String query6 = "SELECT SUM(A.VALORTOTAL) MÊS " +
            " FROM CX_PEDIDO A WHERE 1=2" +
            " AND A.TIPOMOVIMENTACAO = 2";

            //DASHBOARD 1
            BindingSource Binding1 = new BindingSource();
            Binding1.DataSource = conexao.DataTable(query);
            dashBoard2.DataSource = Binding1;
            dashBoard2.AllowUserToResizeRows = false;
            dashBoard2.AllowUserToAddRows = false;
            dashBoard2.Columns[0].Width = 243;
            dashBoard2.RowTemplate.Height = 46;
            dashBoard2.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dashBoard2.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //DASHBOARD 2
            BindingSource Binding2 = new BindingSource();
            Binding2.DataSource = conexao.DataTable(query2);
            dashBoard3.DataSource = Binding2;
            dashBoard3.AllowUserToResizeRows = false;
            dashBoard3.AllowUserToAddRows = false;
            dashBoard3.Columns[0].Width = 240;
            dashBoard3.RowTemplate.Height = 46;
            dashBoard3.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dashBoard3.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //DASHBOARD 3
            BindingSource Binding3 = new BindingSource();
            Binding3.DataSource = conexao.DataTable(query3);
            dashBoard4.DataSource = Binding3;
            dashBoard4.AllowUserToResizeRows = false;
            dashBoard4.AllowUserToAddRows = false;
            dashBoard4.Columns[0].Width = 240;
            dashBoard4.RowTemplate.Height = 46;
            dashBoard4.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dashBoard4.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //DASHBOARD 4
            BindingSource Binding4 = new BindingSource();
            Binding4.DataSource = conexao.DataTable(query4);
            dashBoard5.DataSource = Binding4;
            dashBoard5.AllowUserToResizeRows = false;
            dashBoard5.AllowUserToAddRows = false;
            dashBoard5.Columns[0].Width = 240;
            dashBoard5.RowTemplate.Height = 46;
            dashBoard5.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dashBoard5.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //DASHBOARD 5
            BindingSource Binding5 = new BindingSource();
            Binding5.DataSource = conexao.DataTable(query5);
            dashBoard6.DataSource = Binding5;
            dashBoard6.AllowUserToResizeRows = false;
            dashBoard6.AllowUserToAddRows = false;
            dashBoard6.Columns[0].Width = 240;
            dashBoard6.RowTemplate.Height = 46;
            dashBoard6.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dashBoard6.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //DASHBOARD 6
            BindingSource Binding6 = new BindingSource();
            Binding6.DataSource = conexao.DataTable(query6);
            dashBoard7.DataSource = Binding6;
            dashBoard7.AllowUserToResizeRows = false;
            dashBoard7.AllowUserToAddRows = false;
            dashBoard7.Columns[0].Width = 240;
            dashBoard7.RowTemplate.Height = 46;
            dashBoard7.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dashBoard7.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
            CreateDashBoard2();
        }

        private void MenuTela_Load(object sender, EventArgs e)
        {

        }
    }
}
