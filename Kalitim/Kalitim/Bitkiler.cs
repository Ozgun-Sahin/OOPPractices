using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class Bitkiler :Canlilar
    {
        protected void Fotosentez()
        {
            Console.WriteLine("Bitkiler Fotosentez Yapar");
        }

        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();

            Console.WriteLine("Bitkiler Güneşe Tepki Verir");
        }
    }

    public class TohumluBitkiler :Bitkiler
    {
        public TohumluBitkiler()
        {
            base.Fotosentez();
            base.UyaranlaraTepki();
        }

        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu bitikiler tohumla çoğalır");
        }
    }
    public class TohumsuzBitkiler : Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.Fotosentez();
        }

        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumlu bitikiler sporla çoğalır");
        }
    }
}
