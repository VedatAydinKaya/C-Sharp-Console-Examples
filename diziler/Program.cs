using System;
using System.Collections;
using System.Collections.Generic;


namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {

            // Dizi tanımlama   //Arrays - Diziler
            //Aynı tipten birden fazla değeri tutabildiğimiz veri tiplerine dizi adını veriyoruz.
            //Index 0dan başlar

            //string[] isimler = new string[5];

            //string[] hayvanlar = { "Maymun", "Kedi", "Kopek", "Kus" };

            //char[] harfler = { 'a', 'b', 'c', 'd', 'e' };

            //int[] sayilar;

            //sayilar = new int[6];

            //sayilar[5] = 70;

            //string[] kelimeler = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };




            //Console.WriteLine(kelimeler[5]);
            //Console.WriteLine(harfler[3]);  
            //Console.WriteLine(hayvanlar[1]);

            // dongulerle dizi kullanımı


            // klavyeden girilen n sayının ortalamasını bulan program


            //Console.Write("Dizi uzunlugunu giriniz: ");
            //int diziUzunlugu = int.Parse(Console.ReadLine());

            //int[] sayilar = new int[diziUzunlugu];

            //  for (int i = 0; i < diziUzunlugu; i++)
            //  {
            //    Console.Write($"Dizinin {i+1}. elamanını girin: ");
            //    sayilar[i] = int.Parse(Console.ReadLine());
            //  }
            //  double toplam = 0;
            //  foreach (int item in sayilar)
            //  {
            //      toplam += item;
            //  }
            //  double ortalama = (toplam / diziUzunlugu);   // double/int =double

            // Console.WriteLine($"SAyıların Ortalaması: {ortalama} ");


            // Kullanıcı girdigi n sayısı kadar random 1-100  sayi uretme dizi

            //Console.Write("Dizi uzunlugunu girin: ");
            //int diziUzunlugu = int.Parse(Console.ReadLine());

            //int[] randomSayiDizisi = new int[diziUzunlugu];
            //Random rnd = new Random();

            //for (int i = 0; i < diziUzunlugu; i++)
            //{
            //    randomSayiDizisi[i] = rnd.Next(1, 101);
            //    Console.WriteLine($"Dizinin {i+1}.elamanı {randomSayiDizisi[i]} ");
            //}
            //foreach (var item in randomSayiDizisi)
            //{
            //    Console.WriteLine(item);
            //}


            // *********************************     //
            // İki Boyutlu Matris Deger ATAMA Kullanıcı boyut belirlesin

            //Console.Write("Dizinin Satır Sayisini Belirleyin: ");
            //int satir = int.Parse(Console.ReadLine());
            //Console.Write("Dizinin Sutun Sayisini Belirleyin: ");
            //int sutun = int.Parse(Console.ReadLine());
            //int[,] matrisSayilar = new int[satir, sutun];
            //for (int i = 0; i < matrisSayilar.GetLength(0); i++)      
            //{
            //    for (int j = 0; j < matrisSayilar.GetLength(1); j++)
            //    {
            //        Console.Write($"{i+1}.satir ,{j+1}.sutun : ");
            //        matrisSayilar[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < matrisSayilar.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrisSayilar.GetLength(1); j++)
            //    {

            //        Console.Write(matrisSayilar[i,j]);   
            //    }
            //        Console.WriteLine();
            //}

            // ArrayList 

            //ArrayList liste1 = new ArrayList();
            //liste1.Add("Kemal");
            //liste1.Add(true);
            //liste1.Add(null);
            //liste1.Add(DateTime.Now.Year);
            ////liste1.Add(matrisSayilar);

            //foreach (var item in liste1)
            //{
            //    Console.WriteLine(item);
            //}


            // ARRAY LIST  =>> GERREKTİGİNDE LİSTE ELAMANLARI EKLEMEK ICIN KULLANILIR

            ArrayList listem = new ArrayList();
            listem.Add(7);
            listem.Add("Kemal");

            listem.Add(true);

            foreach (var item in listem)
            {
                Console.WriteLine(item);
            }



            // Generic List


            List<int> liste2 = new List<int>();

            liste2.Add(5);
            liste2.Add(55);

            liste2.Add(25);

            foreach (var item in liste2)
            {
                Console.WriteLine(item);
            }

            // Generic Liste Olusturmak

            List<int> liste5 = new List<int>();
            liste5.Add(50);
            liste5.Add(75);
            liste5.Add(85);
            foreach (var item in liste5)
            {
                Console.WriteLine(item);
            }

        }
    }
}
