using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Tam Sayı */

            byte b = 5;     //  1 byte 0-255 arası deger alır
            sbyte c = 7;    // 1 byte -128 ile 127 arası deger alır

            short s = 5;    // 2byte -32768 ile +32768  arası deger alır
            ushort us = 5;  // 2byte 0-65535  arasında deger alır


            Int16 i16 = 2;    // 2byte
            int i = 2;     //  4byte
            Int32 i32 = 2;   //  4byte
            Int64 i64 = 2;   //  8byte

            uint ui = 2;    //4 byte
            long l = 2;     //8byte

            ulong ul = 2;   //8byte



            /* reel sayı*/

            float f = 5;      //4byte 
            double d = 5;      // 8byte
            decimal de = 5;     // 16byte



            /* Tek karakter */

            char ch = '2';          // 2byte

            string str = "vedat "; //sınırsız 


            /* Boolean Ifadeler  */

            bool b1 = true;
            bool b2 = false;


            /* DateTime Degiskeni */

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);


            /* Objeler degişekeni
               tum degisken tipleri object turedigi icin her degiskeni atayabiliriz    */

            object o1 = "x";
            object o2 = 'd';
            object o3 = 5;
            object o4 = 4.7;




            // string ifadeler

            string str1 = string.Empty;
            str1 = "Vedat Kaya";
            string ad = "Vedat";
            string soyad = "Kaya";
            string tamad = ad + " " + soyad;


            //integer  tanımlama sekilleri

            int integer1 = 5;
            int interger2 = 7;
            int integer3 = integer1 * interger2;


            // boolean

            bool bool1 = 10 < 2; //false


            // degisken donusumleri


            string str20 = "20";

            int int20 = 20;

            string yenideger = str20 + int20.ToString();

            Console.WriteLine(yenideger);  //2020

            int numberyenideger = Convert.ToInt32(str20) + int20;

            Console.WriteLine(numberyenideger);


            /* Parse ile degisken donusumu */

            int number = int20 + int.Parse(str20); //

            Console.WriteLine(number);  // 40


            // datetime ile islemler 

            DateTime tarih = DateTime.Now;
            Console.WriteLine(tarih);

            string datetime1 = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime1);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");

            Console.WriteLine(datetime2);

            // saat
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);

            Console.WriteLine();

        }
    }
}
