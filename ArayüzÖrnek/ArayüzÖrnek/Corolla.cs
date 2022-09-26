using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArayüzÖrnek
{
    internal class Corolla : IOtomobil
    {
        public Marka HangiMarka()
        {
            return Marka.Toyota;
        }

        public Renk HangiRenk()
        {
            return Renk.Beyaz;
        }

        public int KacTeker()
        {
            return 4;
        }
    }
}
