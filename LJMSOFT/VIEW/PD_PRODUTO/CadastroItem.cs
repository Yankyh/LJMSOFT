using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LJMSOFT.VIEW.PD_PRODUTO;

namespace LJMSOFT.VIEW.PD_PRODUTO
{
    public partial class CadastroItem : Form
    {
        public CadastroItem()
        {
            InitializeComponent();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void tipoPagamentoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void f3event(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                CadastroFamilia cadastroFamilia = new CadastroFamilia();
                cadastroFamilia.ShowDialog();

            }
        }
    }
}
