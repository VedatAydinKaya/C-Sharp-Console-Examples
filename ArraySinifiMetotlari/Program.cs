using System;

namespace ArraySinifiMetotlari
{
    class Program
    {
        static void Main(string[] args)
        {


            // sort metodu =>>>>  Diziler üzerinden sıralama işlemi yapar.
            // Eğer string bir dizi ise alfabetik olarak olarak A'dan Z'ye sıralar. Eğer numeric bir dizi ise dizi elemanlarını küçükten büyüğe sıralar.
            int[] sayilar = { 23, 45, 14, 8, 88, 17, 59 };

            Console.WriteLine("***** SIRASIZ LISTE******");
            foreach (int sayi in sayilar)
                Console.WriteLine(sayi);
            Console.WriteLine("***** SIRALI LISTE*****");
            Array.Sort(sayilar);
            foreach ( var item in sayilar)
                Console.WriteLine(item);

            // Clear Dizinin belirtilen elemanlarını varsayılan değerine getirir. Yani örneğin numeric bir dizi ise 0 olarak setler.
            Console.WriteLine("***** ARRAY CLEAR *****");

            Array.Clear(sayilar, 2, 3);
            foreach (int sayi in sayilar)
                Console.WriteLine(sayi);

            // Reverse Dizinin ortasını belirleyerek elemanlarını aynalar gibi düşünebilirsiniz. Yani dizinin ilk elemanı ile son elemanını yer değiştirir.
            Console.WriteLine("***** ARRAY REVERSE *****");
            Array.Reverse(sayilar);
            foreach (var item in sayilar)
                Console.WriteLine(item);

            // IndexOf  Verilen dizinin verilen elemanının indexini getirir. Eğer dizi içerisinde elemanı bulamazsa -1 döner.

            Console.WriteLine("***** ARRAY IndexOf *****");
            Console.WriteLine(Array.IndexOf<int>(sayilar,14));

            // Resize  Dizileri yeniden boyutlandırmak için kullanılır.

            Console.WriteLine("**** Array Resize");

            Array.Resize<int>(ref sayilar, 8);

            sayilar[7] = 28;

            foreach (var item in sayilar)
                Console.WriteLine(item);
            
            
            //  










        }
    }
}
