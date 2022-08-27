using System;

namespace Sınıflar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan c = new Calisan("Özgün", "Şahin", 06015, "Çevre");

            //c.Ad = "Özgün";
            //c.Soyad = "Şahin";
            //c.Departman = "Çevre";
            //c.No = 06015;
             
            c.CasisanBilgileri();

            Calisan c1 = new Calisan();

            c1.Ad = "Damla Naz";
            c1.Soyad = "Şahnin";
            c1.Departman = "Raporlama";
            c1.No = 06016;

            c1.CasisanBilgileri();

            Calisan c3 = new Calisan("Mehmet", "Şahin");

            c3.CasisanBilgileri();



        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        

        public Calisan(string ad, string soyad, int no, string departman) // parametre isteyen kurucu metot
        {
            Ad = ad;
            Soyad = soyad;
            No = no;
            Departman = departman;
        }

        public Calisan(string ad, string soyad) // parametre isteyen kurucu metot
        {
            Ad = ad;
            Soyad = soyad;
            
        }



        public Calisan() { } // parametre istemeyen kurucu metot



        public void CasisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı : {0}",Ad);
            Console.WriteLine("Çalışan Soyadı : {0}",Soyad);
            Console.WriteLine("Çalışan Numarası : {0} ",No);
            Console.WriteLine("Çalışan Departmanı : {0}",Departman);
        }

    }


}
