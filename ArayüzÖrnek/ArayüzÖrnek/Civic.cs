using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArayüzÖrnek
{
    internal class Civic : IOtomobil
    {
        public Marka HangiMarka()
        {
            return Marka.Honda;
        }

        public Renk HangiRenk()
        {
            return Renk.Gri;
        }

        public int KacTeker()
        {
            return 4;
        }
    }
}
