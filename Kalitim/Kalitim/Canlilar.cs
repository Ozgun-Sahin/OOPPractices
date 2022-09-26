using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class Canlilar
    {
        public void Beslenme()
        {
            Console.WriteLine("Canlılar Beslenir");
        }
        public void Solunum()
        {
            Console.WriteLine("Canlılar Solunum Yapar");
        }
        public void Bosaltim()
        {
            Console.WriteLine("Canlılar Boşaltım Yapar");
        }

        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlılar Uyaranlara Tepki Veriri");
        }


    }
}
