using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LJMSOFT.VIEW.PS_PESSOA;
using LJMSOFT.VIEW.PD_PRODUTO;
using LJMSOFT.VIEW.CX_CAIXA;
using LJMSOFT.VIEW.AG_AGENDA;

namespace LJMSOFT.VIEW
{
    class MenuControl
    {
        public void Menu(String node)
        {
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
}
