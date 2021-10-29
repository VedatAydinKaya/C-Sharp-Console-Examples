using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***** Atama ve İslemli Atama****");

            // atama ve islemli atama
            int x = 2;
            int y = 2;
            y = y + 2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            //mantıksal Operatorler
            //   ||,&&,!


            Console.WriteLine("***** Mantıksal Operatorler****");

            bool isSuccess = true;
            bool isCompleted = false;
            if (isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect:");
            }
            if (isSuccess || isCompleted)
            {
                Console.WriteLine("Great");
            }
            if (isSuccess && !isCompleted)
            {
                Console.WriteLine("Fine:");
            }

            Console.WriteLine("***** Iliskisel  Operatorler****");

            //Iliskisel Operatorler

            // <,>,<=,>=,==,!=


            int a = 3;
            int b = 4;
            bool sonuc;

            sonuc = a < b;
            Console.WriteLine(sonuc);

            sonuc = a > b;
            Console.WriteLine(sonuc);

            sonuc = a <= b;
            Console.WriteLine(sonuc);

            sonuc = a >= b;
            Console.WriteLine(sonuc);

            sonuc = a != b;
            Console.WriteLine(sonuc);

            sonuc = a == b;
            Console.WriteLine(sonuc);

            //Aritmetik Operatorler

            // +,-,/,*

            Console.WriteLine("***** Aritmetik  Operatorler ****");


            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 - sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);

            Console.WriteLine(sonuc1);

            //   % mod alma :

            int value1 = 20;
            int value2 = 8;

            Console.WriteLine(" Mod Degeri: " + value1 % value2);












        }
    }
}
