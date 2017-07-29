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

namespace LJMSOFT
{
    public partial class MenuTela : Form
    {
        public MenuTela()
        {
            InitializeComponent();

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaixaTela caixaTela = new CaixaTela();
            caixaTela.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }

        private void MenuTela_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
           if( menuTreeView.SelectedNode == null)
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
                            if(node == "Agenda")
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
            if(menuTreeView.Visible == false)
            {
                menuTreeView.Visible = true;
            }
            else
            {
                menuTreeView.Visible = false;
            }
          
        }

        private void Provisoriobutton_Click(object sender, EventArgs e)
        {
            CadastroPessoa cp = new CadastroPessoa();
            cp.ShowDialog();
        }
    }
}
