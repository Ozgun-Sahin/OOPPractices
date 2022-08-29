using System;

namespace Enumlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.pazar);
            Console.WriteLine((int)Gunler.cumartesi);

            int sıcaklık = 26;

            if (sıcaklık <= (int)HavaDurumu.normal)
            {
                Console.WriteLine("Hava çok soğuk");
            }
            else if (sıcaklık >= (int)HavaDurumu.sıcak)
            {
                Console.WriteLine("Hava çok sıcak");
            }
            else if ((sıcaklık >= (int)HavaDurumu.normal && sıcaklık <= (int)HavaDurumu.sıcak))
            {
                Console.WriteLine("Dışarı çıkılabilir");
            }

        }
    }

    enum Gunler
    {
        pazartesi,
        salı,
        çarşamba,
        perşembe,
        cuma,
        cumartesi,
        pazar
    }

    enum HavaDurumu
    {
        soguk = 5,
        normal = 25,
        sıcak = 27,
        cokSıcak = 30
    }
}
