using System;

namespace Sınıflar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan c = new Calisan();

            c.Ad = "Özgün";
            c.Soyad = "Şahin";
            c.Departman = "Çevre";
            c.No = 06015;

            c.CasisanBilgileri();

            Calisan c1 = new Calisan();

            c1.Ad = "Damla Naz";
            c1.Soyad = "Şahnin";
            c1.Departman = "Raporlama";
            c1.No = 06016;

            c1.CasisanBilgileri();



        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;


        public void CasisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı : {0}",Ad);
            Console.WriteLine("Çalışan Soyadı : {0}",Soyad);
            Console.WriteLine("Çalışan Numarası : {0} ",No);
            Console.WriteLine("Çalışan Departmanı : {0}",Departman);
        }

    }


}
