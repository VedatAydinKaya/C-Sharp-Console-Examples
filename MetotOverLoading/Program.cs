using System;

namespace MetotOverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            // out parametreler


            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);            // TryParse Metotu boolean ifade doner
                                                                         // outSayi parametresi ile  yeni deger buna atandı
            if (sonuc)
            {
                Console.WriteLine("Basarılı");
                Console.WriteLine(outSayi);
            }
            else
                Console.WriteLine("Basarısız");
               
            
            int sayi1 = 5, sayi2 = 4;

            // farklı class instance almasınız

            Metotlar instance = new Metotlar();

            instance.Topla(sayi1, sayi2, out int toplamSonuc);
            instance.EkranaYazdir(toplamSonuc);


            // Metot-Overloading Asırı Yukleme  Bir fonksiyonun imzasını degistirerek birden fazla sekilde kullanabiliriz

            // Method overloading yani metotların aşırı yüklenmesi metot imzasının değiştirilerek
            // aynı isimdeki metodun birden farklı versiyonun yaratılmasıdır.

            int value = 999;

            instance.EkranaYazdir(value);  // int tipindeki metota erisiri

            //Metot İmzası
            // MetotAdi+paramerte sayisi+parametre tipi    nOT:Erisim belirleyici ya da geri donus ifadesi metot imzasını etkilemez

            instance.EkranaYazdir("Vedat", "Kaya"); // strind tipindeki 2 boyutlu metota erisir



        }
    }

    class Metotlar 
    {
        public void Topla(int deger1, int deger2, out int toplam)   // out parametresi ile toplam ifadesi return edildi
        {
            toplam = deger1 + deger2;
        }

        public void EkranaYazdir(string veri)  // string tipindeki metot
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)     // int tipindeki metot
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri,string veri2)  // bu benim icin imzası farklı oldugundan farklı bir fonksiyon
        {
            Console.WriteLine(veri+veri2);
        }

    }
}
