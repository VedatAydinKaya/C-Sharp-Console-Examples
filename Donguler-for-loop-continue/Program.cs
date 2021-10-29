using System;

namespace Donguler_for_loop_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Bir sayi giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());

            //for (int i = 1; i < sayi; i++)
            //{
            //    if (i%2==1)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            int tekToplam = 0, ciftToplam = 0;

            // 1-1000 arasındaki tek sayıların toplamı
            for (int i = 1; i <= 1000; i++)
            {
                if (i%2==0)
                    ciftToplam += i;
                else 
                    tekToplam += i;         
            }
            Console.WriteLine($"1-1000 arasındaki Tek Sayıların Toplamı:{tekToplam}");
            Console.WriteLine($"1-1000 arasındaki Cift Sayıların Toplamı:{ciftToplam}");


            // break-continue

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }

        }
    }
}
