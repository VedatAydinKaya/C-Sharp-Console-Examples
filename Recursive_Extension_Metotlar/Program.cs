using System;

namespace Recursive_Extension_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recursive-Oz Yınemeli Fonksiyon
            // 3^4  Us ALMA

            int result = 1;
            for (int i = 1; i < 5; i++)
                result = result * 3;
            Console.WriteLine(result);

            //3! faktoriyel
            int deger = 1;
            for (int i = 1; i <= 3; i++)
            {
                deger = deger * i;
            }
            Console.WriteLine(deger);
         
            

            Islemler instance = new Islemler();
            Console.WriteLine(instance.Expo(3,4));
            Console.WriteLine($"FAKTORİYEL: {instance.Fakto(5)}");


            // Extension Metotlar : Extension Classlar ve Extension Metotlar Static Olmalıdır nesnesi olmadan erisilmedlidir

            string ifade = "Vedat Aydin Kaya";

            bool sonuc = ifade.CheckSpace();               //nesnesini uretmeden eristik

            Console.WriteLine(sonuc);
            if (sonuc)
                Console.WriteLine(ifade.RemoveWhiteSpace());
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());


            // İnteger bir diziyi sıralayan Extension Metot

            int[] dizi = { 25, 14, 9, 4, 5, 7, 47 };

            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi = 7;
            Console.WriteLine(sayi.isEvenNumber());   // false

            Console.WriteLine(ifade.GetFirstCharacter()); 

            
        }
    }

    public class Islemler 
    {
        public int Expo(int sayi, int us) 
        {
            if (us < 2)
                return sayi;
            return Expo(sayi, us-1) * sayi;
        }

        // Expo(3,4)
        // Expo(3,3)*3
        // Expo(3,2)*3*3
        // Expo(3,1)*3*3*3
        // 3*3*3*3

        public int Fakto(int sayi)
        {
            if (sayi < 2)
                return sayi;
            return Fakto(sayi-1) * sayi;
        } 
        // Fakto(3)
        // Fakto(2)*3
        // Fakto(1)*2*3

    }

    public static class Extension     //Static bir class içerisinde static bir metot olarak yazılmalılar.    
                                         //Extension Classlar static  olmalıdır =>> nesnesi olmadan eriseblimeniz gerekiyor
    {

        public static bool CheckSpace(this string param)    // this ifadesi ile artık extension metot oluyor
        {
             return param.Contains(" ");      //string kutuphanesini Contains metotu
        }

        public static string RemoveWhiteSpace(this string param) 
        {
            string[] dizi = param.Split(" ");        // string ifadeyi bosluklara gore ayırarak diziye atıyor

            return string.Join("", dizi);            // dizi ifadesini stringe atadı 
        }

        public static string MakeUpperCase(this string param) 
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param) 
        {
              return param.ToLower();
        }

        public static int[] SortArray(this int[] param)   // dizi alıyor dizi donuyor
        {
            Array.Sort(param);

            return param;
        }
        public static void EkranaYazdir(this int[] param) 
        {

            foreach (var item in param)
                Console.WriteLine(item);
        }
        public static bool isEvenNumber(this int param) 
        {
            return param % 2 == 0;
        }

        public static string GetFirstCharacter(this string param) 
        {
            return param.Substring(0, 1);
        }
    
    }
     
}
