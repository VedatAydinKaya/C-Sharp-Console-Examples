using System;

namespace KurucuMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Constructor Method 

            1- Yapıcı metotların isimleri sınıf isimleri ile aynı olmak zorundadır.

            2- Public olarak bildirilmeleri gerekir
            
            3-Geri dönüş değerleri yoktur.



             */


            // Constructor Metotta initial olarak string ifadeye : null  boolean ifadeye:false ve int ifadeye :0 degerini atar

            Console.WriteLine("*******Calisan 1 Bilgileri **********");

            Calisan calisan1 = new Calisan("Ayşe","Kara", 24527471, "Insan Kaynaklari");
            calisan1.CalisanBilgileri();


            Console.WriteLine("*******Calisan 2 Bilgileri **********");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Arda";
            calisan2.Soyad = "Deniz";
            calisan2.No = 24714772;
            calisan2.Departman = "Satın Alma";

            calisan2.CalisanBilgileri();

            Console.WriteLine("*******Calisan 3 Bilgileri **********");

            Calisan calisan3 = new Calisan("Zikriye","Urkmez");

            Console.WriteLine("*******Calisan 4 Bilgileri **********");

            Calisan calisan4 = new Calisan();

            calisan4.CalisanBilgileri();

            /* 
             Her sınıfın biz tanımlamasakta bir tane kurucu metotu vardır. Buna varsayılan kurucu metot (default constructor) denir.
            Default constructor'ın görevi sınıfın içerindeki özelliklere ilk değer ataması yapılmadığında onların default değerlerini set etmektir. 
            Şöyle düşünebilirsiniz; sınıf içerisinde string veri tipinde bir özellik varsa ve siz ilk değer atamasını yapmazsanız varsayılan 
            kurucu onun atamasını  arka planda null olarak yapar. 
            Aynı integer tipinde bir özelliğin ilk değer atamasını 0 olarak yapar.
             
             */




        }
    }

    class Calisan
    {
        // Calisan Sınıfının Propertyleri

        public string Ad;

        public string Soyad;

        public int No;

        public string Departman;


        // Constructor Kurucu Fonksiyon  =>>> Nesne olustururken arka planda otomatik olarak olusturulan Metotlar

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        // Overloading Constructor Metot =>>>   METOT UZERINDE OVERLOADING ISLEMI DE YAPILABILIR
        public Calisan(string ad, string soyad) 
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }

        // PARAMETRE ALMAYAN  CONSTRUCTOR METOT  =>>>   METOT UZERINDE OVERLOADING ISLEMI DE YAPILABILIR
        public Calisan() { }

        // Calisan Sınıfını EKRANA YAZDIRAN METHOD

        public void CalisanBilgileri()
        {

            Console.WriteLine("Calisanın Adı:{0} ", Ad);
            Console.WriteLine("Calisanın Soyadi:{0} ", Soyad);
            Console.WriteLine("Calisanın No:{0} ", No);
            Console.WriteLine("Calisanın Departmanı:{0} ", Departman);

        }
    }
}
