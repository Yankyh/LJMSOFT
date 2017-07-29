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

namespace LJMSOFT.VIEW.CX_CAIXA
{
    public partial class CaixaTela : Form
    {
        public CaixaTela()
        {
            InitializeComponent();
        }

        private void CaixaTela_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String str = "3,5";
            str = str.Replace(',', '.');
            MessageBox.Show(str);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            CaixaEntradaTela caixaSaidaTela = new CaixaEntradaTela();
            caixaSaidaTela.ShowDialog();
        }
    }
}
