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
            Agenda agenda = new Agenda();
            agenda.ShowDialog();
        }

        private void MenuTela_Load(object sender, EventArgs e)
        {

        }

        private void CadastrarNovaPessoapictureBox2_Click(object sender, EventArgs e)
        {
            CadastroPessoa novoCadastro = new CadastroPessoa();
            novoCadastro.ShowDialog();
        }
    }
}
