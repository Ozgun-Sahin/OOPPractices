using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArayüzÖrnek
{
    public abstract class Otomobil
    {
        public int KacTeker()
        {
            return 4;
        }

        public virtual Renk HangiRenk()
        {
            return Renk.Beyaz;
        }

        public abstract Marka HangiMarka();

        

    }
}
