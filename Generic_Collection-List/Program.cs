using System;

using System.Collections.Generic;   // namespace =>>isim uzayi

namespace Generic_Collection_List
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Klasik programlama dillerinde array yani diziler çok önemli veri tipleridir. Bir çok problemimizi diziler yardımıyla çözebiliriz. 
            Ama bazı handikapları nedeniyle bir çok sorun karşısında da yetersiz kalırlar.Bu sorunları şöyle sıralayabiliriz: 
             
             
            *** Array'in elemanları aynı veri tipinde olmalıdır.
            ***Array'in boyutu önceden belirlenmelidir.

             Oysa programlama dillerinde farklı türlerde verileri saklamaya ihtiyaç duyarız. Ve çoğu zaman ne kadar veri saklayacağımız program 
            akışında belli olabilir.Koleksiyonlar tam da bu sorunları çözmek için dizilerin handikaplarından yaratılmıştır.
            
             Dizilerin aksine koleksiyonların bazı tipleri; üzerinde çalıştıkları makinaın RAM'i yettiği sürece genişleyebilirler ve farklı türlerde 
             veri tiplerini saklayabilirler.

            Koleksiyonların elemanları object tipindedir. Hatırlayacak olursak öğrendiğimiz veri tipleri için object sınıfından 
            türediklerini söylemiştik. Yani bu bir sorun değil,
             her türlü veriyi koleksiyonlar içerisinde saklayabiliriz.

             Koleksiyonlar System.Collections namespace i yani isim uzayı altında bulunurlar. 
             Yani bir koleksiyon tipini kullanmak istiyorsanız System.Collections'ı using direktifi ile programınıza import 
             ediyor olmanız gerekiyor.
             
             Değer Tipleri: int, long, float, double, decimal, char, bool, byte, short, struct, enum
             Referans Tipleri: string, object, class, interface, array, delegate, pointer


            Bir değer tipinin referans tipine dönüştürülme boxing, tam tersine unboxing işlemi denir.

            Koleksiyonlar verilerini object tipinde tutuyor demiştik. Object de bir referans tipi.
            Bu demek oluyor ki değer tipinde bir veriyi koleksiyona eklemek istediğimde bir boxing işlemi yapıyorum. 
            Daha sonra elemanı okumak istediğimde de unboxing işlemi yapıyorum. Boxing ve unboxing işlemleri bilgisayar açısından maliyetli bir işlemdir. 
            Koleksiyon içerisindeki eleman sayısının artışına bağlı olarak bu boxing ve unboxing işlemlerinin sayısı artacaktır. 
            Buna bağlı olarakta uygulamanın performansı olumsuz yönde etkilenecektir.


             */

            // Generic  Koleksiyonlar

            //  <List>T class =>> generic bir list sınıf koleksiyonudur
            //   Generic olmasını sağlayan da burdaki T veri tipidir. T listenin hangi türden veri tutacağını belirler
            // T object turundedir.Liste icindeki nesnelerin tipini ifade eder.Hangi tipten nesne eklenecegini belirler


            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(7);
            sayiListesi.Add(25);
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(81);
            sayiListesi.Add(73);



            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kirmizi");
            renkListesi.Add("Sari");
            renkListesi.Add("Yesil");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");


            //Count

            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(renkListesi.Count);


            // foreach ve List.Foreach ile elamanlara erisim
             
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);
            foreach (var renk in renkListesi)
                Console.WriteLine(renk);
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));


            //Listeden eleman cikarma

            sayiListesi.Remove(23);
            renkListesi.Remove("Mavi");


            // index ile
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);
                
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));


            //Liste icinde arama 

            if (sayiListesi.Contains(10))
            {
                  if (renkListesi.Contains("Kirmizi"))
                    Console.WriteLine("10 ve Kırmizi LİSTENDE BULUNDU");
            }

            // diziyi listeye cevirme

            string[] hayvanlar = { "Kedi", "Kopek", "Kus", "Kartal","Karga" };
            List<string> hayvanListe = new List<string>(hayvanlar);

            // listeyi temizleme
            hayvanListe.Clear();



            //Liste icinde class tutmak istersek; nesne atamak istersem?

            List<Kullanicilar> kullanicilistesi = new List<Kullanicilar>();

            // kullanicilar sınıfının nesnesini olusturmak
            Kullanicilar kullanici1=new Kullanicilar();
            kullanici1.Isim = "Ayse";              //isim property
            kullanici1.Soyisim = "Yılmaz";         //soyisim propertry
            kullanici1.Yas = 26;                   //yas property

            // kulllanicilar sınıfının yeni nesnesini olusturmak

            Kullanicilar kullanici2=new Kullanicilar();
            kullanici2.Isim = "Fırat";
            kullanici2.Soyisim = "Kemal";
            kullanici2.Yas = 38;


            kullanicilistesi.Add(kullanici1);
            kullanicilistesi.Add(kullanici2);


            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar()
            {
                 Isim="Deniz",            // Kullanicilar Sınıfına yeni bir nesne eklendi
                 Soyisim="Arda",
                 Yas=47
            });

            foreach (Kullanicilar kullanici in kullanicilistesi)  // Kullanicilar tipindeki kullanicliste koleksiyonunu loglama
            {
                Console.WriteLine("Kullanici Adi: "+kullanici.Isim);
                Console.WriteLine("Kullanici Soyadi: " + kullanici.Soyisim);
                Console.WriteLine("Kullanici Yas: " + kullanici.Yas);
            }
            yeniListe.Clear();

        }
    }


    public class Kullanicilar {


        private string isim;
        private string soyisim;
        private int yas;


        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }

        public int Yas { get => yas; set => yas = value; }

    }
}
