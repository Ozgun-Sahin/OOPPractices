using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArayüzÖrnek
{
    internal class Focus : IOtomobil
    {
        public Marka HangiMarka()
        {
            return Marka.Ford;
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
