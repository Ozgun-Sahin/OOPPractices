using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArayüzÖrnek
{
    internal class NewCivic : Otomobil
    {
        public override Marka HangiMarka()
        {
            return Marka.Honda;
        }

        public override Renk HangiRenk()
        {
            return Renk.Gri;
        }
    }
}
