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
    public partial class BotoesGerais : Form
    {
        public BotoesGerais()
        {
            InitializeComponent();
        }

        private void BotoesGerais_Load(object sender, EventArgs e)
        {

        }

        private void NovoCadastrobutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroPessoa cp = new CadastroPessoa();
            cp.ShowDialog();
            this.Close();
        }

        private void Voltarbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuTela mt = new MenuTela();
            mt.ShowDialog();
            this.Close();

        }
    }
}
