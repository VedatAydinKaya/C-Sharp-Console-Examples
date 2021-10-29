using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // while 1 den baslayarak sayiya kadar ortalama yazdıran Program

            int sayi, sayac = 1, toplam = 0;
            Console.Write("Bir sayi giriniz: ");
            sayi = int.Parse(Console.ReadLine());
            while (sayac<=sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

             //a dan z ye karakterleri yazdırma
            char harf = 'a';
            while (harf< 'z')
            {
                Console.Write($"{harf} ");
                harf++;
            }

            Console.WriteLine("***********ForEach*******************");

            string[] arabalar = { "BMW", "TOYOTA", "NISSAN", "MERCEDES-BENZ", "TESLA" };

            foreach (string araba in arabalar)
            {
                Console.WriteLine(araba);
            }
           

            
            


        }
    }
}
