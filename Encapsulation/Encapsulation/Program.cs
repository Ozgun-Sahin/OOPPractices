using System;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Isim = "Özgün";
            ogr.Soyisim = "Şahin";
            ogr.OgrenciNo = 512;
            ogr.Sinif = 3;

            ogr.SinifAtlat();
            ogr.OgrenciBilgileriniGetir();

            Ogrenci ogr2 = new Ogrenci("Damla Naz","Şahin",507,1);
            ogr2.SinifDusur();
            ogr2.SinifDusur();
            ogr2.OgrenciBilgileriniGetir();



        }
    }


    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim
        {
            get { return isim; }
            set { isim = value; } 
        }

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        {
            get => sinif;

            set 
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az bir olabilir");
                    sinif = 1;
                }
                else
                    sinif = value;
            }  
        }


        public Ogrenci() { }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("*öğrenci bilgileri*");
            Console.WriteLine("Öğrenci Adı:{0}",this.Isim);
            Console.WriteLine("Öğrenci Adı:{0}", this.soyisim);
            Console.WriteLine("Öğrenci Adı:{0}", this.sinif);
            Console.WriteLine("Öğrenci Adı:{0}", this.ogrenciNo);
        }


        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }



    }
}
