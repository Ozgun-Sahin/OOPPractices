using System;

namespace Structlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdörtgen = new Dikdortgen();
            dikdörtgen.KisaKenar = 3;
            dikdörtgen.UzunKenar = 4;

            Console.WriteLine(dikdörtgen.AlanHesapla());

            Dikdortgen_Struct dikdortgen_Struct;
            dikdortgen_Struct.KisaKenar = 3;
            dikdortgen_Struct.UzunKenar = 4;
            Console.WriteLine(dikdortgen_Struct.AlanHesapla());

        }

        class Dikdortgen
        {
            public int KisaKenar;
            public int UzunKenar;

            public Dikdortgen()
            {
                KisaKenar = 3;
                UzunKenar = 4;
            }

            public long AlanHesapla()
            {
                return this.KisaKenar * UzunKenar;
            }
        }

        struct Dikdortgen_Struct
        {
            public int KisaKenar;
            public int UzunKenar;

            public long AlanHesapla()
            {
                return this.KisaKenar * UzunKenar;
            }
        }



    }
}
