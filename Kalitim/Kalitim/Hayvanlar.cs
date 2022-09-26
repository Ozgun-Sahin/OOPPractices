using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class Hayvanlar : Canlilar
    {
        public void SesCikarma()
        {
            Console.WriteLine("Hayvanlar Ses Çıkarır");
        }

        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();

            Console.WriteLine("Hayvanlar Temasa Tepki Verir");
        }
    }


    public class Surungenler: Hayvanlar
    {
        public void SurunerekHareket()
        {
            Console.WriteLine("Sürüngenler sürünürler");
        }
    }
    public class Kuslar : Hayvanlar
    {
        public Kuslar()
        {
            base.UyaranlaraTepki();
        }

        public void Ucma()
        {
            Console.WriteLine("Kuşlar uçabilirler");
        }
    }
}
