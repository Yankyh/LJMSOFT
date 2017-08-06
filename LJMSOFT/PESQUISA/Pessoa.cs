using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LJMSOFT.DAL;
using System.Windows.Forms;

namespace LJMSOFT.PESQUISA
{
    class Pessoa
    {


      public AutoCompleteStringCollection teste()
        {
            var source = new AutoCompleteStringCollection();
            source.AddRange(new string[]
                        {
                        "January",
                        "February",
                        "March",
                        "April",
                        "May",
                        "June",
                        "July",
                        "August",
                        "September",
                        "October",
                        "November",
                        "December"
                        });

            return source;
        }



    }
}
