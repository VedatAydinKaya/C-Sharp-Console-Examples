using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // System Collections NameSpace

            /* Standart dizilerde aynı tipte verileri verileri bir arada tutabileceğimizi ve dizinin boyutunun belirtilmesi gerektiğinden bahsetmiştik.
             * Arraylist tam olarak bu noktada farklılaşıyor. 
             * Farklı veri tiplerini array list içerisinde saklayabilirsiniz. Ve eleman ekleyerek ve cıkararak boyutunu dinamik olarak değiştirebilirsiniz.  */

            ArrayList liste = new ArrayList();

            //liste.Add("ayse");
            //liste.Add(2);
            //liste.Add(true);
            //liste.Add('A');



            // icerisindeki verilere erisim

           // Console.WriteLine(liste[1]);
            foreach ( var item in liste)
                Console.WriteLine(item);

            //AddRange

            Console.WriteLine("*********Add Range********");
            //string[] renkler = { "Kirmizi", "Mavi", "Yesil", "Beyaz", };

            // Generic collection ekleme
            List<int> sayilar = new List<int>() { 1, 8, 17, 41, 315, 13 };

            liste.AddRange(sayilar);
            //liste.AddRange(renkler);
            foreach (var item in liste)
                Console.WriteLine(item);

            Console.WriteLine("****************ArraySort**********");
            liste.Sort();   // ArrayList koleksiyonlarda her veri tipi aldıgından Sort methodunda hata alırız.Run time kısmında INt almalı
                foreach(var item in liste)
                Console.WriteLine(item);

            Console.WriteLine("****BİNARY SEARCH");      // =>>>>>>>index 

            Console.WriteLine(liste.BinarySearch(315));

            // Reverse

            Console.WriteLine("**** REVERSE***");      // =>>>>>>>index 

            liste.Reverse();

            foreach (var item in liste)

                Console.WriteLine(item);

            //CLEAR

            liste.Clear();


        }
    }
}
