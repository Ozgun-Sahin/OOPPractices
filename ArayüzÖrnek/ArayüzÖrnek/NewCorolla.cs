using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArayüzÖrnek
{
    internal class NewCorolla : Otomobil
    {
        public override Marka HangiMarka()
        {
            return Marka.Toyota;
        }
    }
}
