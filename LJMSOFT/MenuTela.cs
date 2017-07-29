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
        }

        public void CreateDashBoard1()
        {
            conexao.Conectar();
            //Cria o dashboard1
            String query = "SELECT B.NOME PESSOA, A.VALORTOTAL VALOR, C.NOME PAGAMENTO, D.NOME FORMA" +
                             " FROM CX_PEDIDO A " +
                            " INNER JOIN PS_PESSOA B ON B.HANDLE = A.PESSOA" +
                            " INNER JOIN CX_TIPOPAGAMENTO C ON C.HANDLE = A.TIPOPAGAMENTO" +
                            " INNER JOIN CX_FORMAPAGAMENTO D ON D.HANDLE = A.FORMAPAGAMENTO" +
                            " AND B.NOME IS NOT NULL";
           

            BindingSource Binding = new BindingSource();
            Binding.DataSource = conexao.DataTable(query);
            dashBoard1.DataSource = Binding;
       
            dashBoard1.ClearSelection();
            dashBoard1.Columns[0].Width = 350;
            dashBoard1.Columns[2].Width = 153;
            dashBoard1.Columns[3].Width = 170;
            dashBoard1.AllowUserToResizeRows = false;
            dashBoard1.AllowUserToAddRows = false;

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
            if (menuTreeView.SelectedNode == null)
            {

            }
            else
            {
                String node = menuTreeView.SelectedNode.Text;


                if (node == "Pessoa")
                {
                    ListaPessoas listaPessoas = new ListaPessoas();
                    listaPessoas.ShowDialog();
                }
                else
                {
                    if (node == "Produto")
                    {
                        ListaProduto listaProduto = new ListaProduto();
                        listaProduto.ShowDialog();
                    }
                    else
                    {
                        if (node == "Entrada")
                        {
                            CaixaEntradaTela caixaEntradaTela = new CaixaEntradaTela();
                            caixaEntradaTela.ShowDialog();
                        }
                        else
                        {
                            if (node == "Agenda")
                            {
                                Agenda agenda = new Agenda();
                                agenda.ShowDialog();
                            }
                        }
                    }
                }
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
    }
}
