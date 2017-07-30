using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LJMSOFT.VIEW.CX_CAIXA
{
    public partial class OrdemDeCompra : Form
    {
        public OrdemDeCompra()
        {
            InitializeComponent();
            orcamentoTabPage.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tipoDeMovimentacaoClosed(object sender, EventArgs e)
        {
            if (tipoMovimentacaoCombo.Text == "SIMPLES")
            {
                pessoaCombo.Enabled = false;
                orcamentoTabPage.Visible = false;
            }
            else
            {
                if (tipoMovimentacaoCombo.Text == "VINCULADA A ORÇAMENTO")
                {
                    orcamentoTabPage.Visible = true;
                }
                else
                {
                    pessoaCombo.Enabled = true;
                    orcamentoTabPage.Visible = false;
                }
                  
            }
        }
    }
}
