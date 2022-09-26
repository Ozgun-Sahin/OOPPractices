using System;

namespace Kalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tb = new TohumluBitkiler();
            tb.Beslenme();
            tb.Solunum();
            tb.Bosaltim();
            //tb.Fotosentez();
            tb.TohumlaCogalma();

            Kuslar kus = new Kuslar();
            kus.Solunum();
            kus.Beslenme();
            kus.Ucma();
            kus.SesCikarma();
           
        }
    }
}
