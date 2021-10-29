using System;

namespace conversion_type
{
    class Program
    {
        static void Main(string[] args)
        {

            // implicit Conversion =>>>> Bilincsiz Donusum
            // >>== kucuk veri tiplerininin uncoucious şekilde Daha buyuk kapasiteli veri tipine atanmasıdır. 
            /*Bir değişkenin kendinden daha yüksek kapasiteli bir değişkene atanmasıdır. Hedef değişkenin veri tipi bellekte 
             yeterli alana sahip olacağından,
             bu dönüşümde bir veri kaybı söz konusu olmayacaktır. Dolayısıyla bu dönüşüm kendiliğinden yapılabilir. */
            Console.WriteLine("**** Implicit Converision");

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;

            Console.WriteLine("d:" + d);

            long e = d;

            Console.WriteLine("e:" + e);

            float f = e;
            Console.WriteLine("f:" + f);


            string g = "zikriye";
            char h = 'K';

            object j = g + h + d;

            Console.WriteLine("j:" + j);

            //Explicit Conversion =>>>>   Bilincli Donusum : C# kendinden yapamadıgı donusumlerdir 

            /*Bu yöntemde dönüşümleri developer'ın yapıyor olması gerekiyor. Dönüşüm için farklı yöntemler mevcut. */
            // Convert, Parse , toString

            Console.WriteLine("**** Explicit Converision");

            int x = 4;
            byte y = (byte)x;

            Console.WriteLine("y:" + y);


            int z = 100;
            short q = (short)z;
            Console.WriteLine("q:" + q);

            float w = 10.7f;

            byte v = (byte)w;

            Console.WriteLine(v);


            // toString Methodu ile Conversion >>>= Tip donusumu


            Console.WriteLine("***** toString Methodu");
            int XX = 6;

            string YY = XX.ToString();

            Console.WriteLine("YY:" + YY);

            string ZZ = 12.5d.ToString();

            Console.WriteLine("ZZ:" + ZZ);
            

            // System.Convert Sınıfı  

            Console.WriteLine("******* System Convert Sınıfı ");

            string sayi1 = "20", sayi2 = "35";

            int toplam;
            toplam = Convert.ToInt32(sayi1) + Convert.ToInt32(sayi2);
            Console.WriteLine("Toplam :" + toplam);

            // Parse >>>>>>>= string parametre tek alabilir daha farklı bir parametre alamaz!

            ParseMethod();

        }



         //  A new method declared as static
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10,25";

            int rakam1 = Int32.Parse(metin1);
            Console.WriteLine("rakam1:" + rakam1);

            double double1 = Double.Parse(metin2);
            Console.WriteLine("double1:" + double1);

            Console.WriteLine("**** Double Sayi Test Etme");

            double value1 = 123548.0788498498;
            Console.WriteLine("value1: " + value1);
        }
    }
}


