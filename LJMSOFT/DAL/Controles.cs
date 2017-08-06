using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LJMSOFT.DAL
{
    class Controles
    { private static int handle;

        public static int Handle
        {
            get { return handle; }
            set { handle = value; }
            
        }
    }
}
