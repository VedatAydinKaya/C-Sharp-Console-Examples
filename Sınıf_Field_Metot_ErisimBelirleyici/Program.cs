using System;

namespace Sınıf_Field_Metot_ErisimBelirleyici
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soz Dizimi
            //class SinifAdi
            // {
            //
            //          [Erisim Belirleyici] [VeriTipi]  OzellikAdi;                                // Property
            //          [Erisim Belirleyici]  [Geri Donus Tipi] MetotAdi([parametre Listesi])       // Metotlar
            //
            //           {
            //               //Metot Komutlari
            //           }
            //
            // }


            // Erisim Belirleyiciler

            //   *Public       Her yerden erişilebilir.
            //   *Private      Sadece tanımlandığı sınıf içerisinden erişilebilir.
            //   *Internal     Sadece bulunduğu proje içerisinden erişilebilir
            //   *Protected    Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.


            Calisan calisan1 = new Calisan();       //Kısaca calisan1 biziim nesnemiz      // Calisan Sınıfından nesne olusturduk bir instance; bir ornegini yaratalım

            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 24527471;
            calisan1.Departman = "Insan Kaynaklari";

            calisan1.CalisanBilgileri();

            Console.WriteLine("****************************");

            // Calisan Sınıfından Yeni bir nesne olusturalım

            Calisan calisan2 = new Calisan();      // calisan2 =>>>>>>>>> Calisan Sınıfının yeni nesnesi
            calisan2.Ad = "Arda";
            calisan2.Soyad = "Deniz";
            calisan2.No = 24714772;
            calisan2.Departman = "Satın Alma";

            calisan2.CalisanBilgileri();


        }
    }

    class Calisan 
    {
            // Calisan Sınıfının Propertyleri

            public string Ad;

            public string Soyad;

            public int No;

            public string Departman;


        // Calisan Sınıfını EKRANA YAZDIRAN METHOD

           public void CalisanBilgileri() 
           {

            Console.WriteLine("Calisanın Adı:{0} ",Ad);
            Console.WriteLine("Calisanın Soyadi:{0} ", Soyad);
            Console.WriteLine("Calisanın No:{0} ", No);
            Console.WriteLine("Calisanın Departmanı:{0} ", Departman);

        }
    }
}
