using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LJMSOFT.VIEW.RL_RELATORIO
{
    public partial class formOrcamentoRelatorio : Form
    {
        public formOrcamentoRelatorio()
        {
            InitializeComponent();
        }

        private void Orcamento_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
