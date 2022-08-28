using System;

namespace StaticClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Özgün", "Şahin", "Çevre");

            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            Calisan calisan2 = new Calisan("Damla Naz", "Şahin", "Çevre");
            Calisan calisan3 = new Calisan("Bilge Kaan", "Şahin", "Çevre");

            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            Console.WriteLine(Islemler.Topla(100, 200));
            Console.WriteLine(Islemler.Cikar(400, 200));


        }
    }


    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;
        private string Soyisim;
        private string Departman;


        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
