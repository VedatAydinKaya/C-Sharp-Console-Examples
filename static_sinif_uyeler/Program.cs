using System;

namespace static_sinif_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Static sinif ve uyelerine sinif. seklinde erisilir

            
            Console.WriteLine("Calisan Sayisi:{0}", Calisan.CalisanSayisi) ;

            Calisan calisan = new Calisan("Ayşe","Yilmaz","IK");

            Console.WriteLine("Calisan Sayisi:{0}",Calisan.CalisanSayisi);

            Calisan calisan1 = new Calisan("Deniz", "Derya", "IK");
            Calisan calisan2 = new Calisan("Zikriye", "Urkmez", "IT");

            Console.WriteLine("Calisan Sayisi:{0}", Calisan.CalisanSayisi);


            // Static sınıflara nesnesi olmadan direk adi ile eristik
          

            Console.WriteLine("Toplama Islemi Sonucu: {0} ", Islemler.Topla(100, 200));

            Console.WriteLine("Cıkarma Islemi Sonucu: {0} ", Islemler.Cikar(400, 200));



        }
    }

    class Calisan 
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }


        private string Isim;

        private string Soyisim;

        private string Departman;


        // Static Constructor

        static Calisan() 
        {
            calisanSayisi = 0;
        }


        // Constructor Metot
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
        public static long Topla(int sayi1,int sayi2) 
        {

            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1, int sayi2)
        {

            return sayi1- sayi2;
        }


    }
}
