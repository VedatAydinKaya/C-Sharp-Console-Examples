using System;

namespace exception_handling           //hata yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {

            // compile time error && run time error
            try
            {
                Console.Write("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girilen sayi: " + sayi);
            }
            catch (Exception exx)
            {

                Console.WriteLine("Hata: " + exx.Message.ToString());

            }
            finally
            {
                Console.WriteLine("İslem basarılı");

            }


            try
            {
                // int a=int.Parse(null);  
                // int a=int.Parse("aliveli");
                int a = int.Parse("-20000000000");


            }
            // argument null excepition
            catch (ArgumentNullException ex)
            {

                Console.WriteLine("Bos deger girdiniz:");
                Console.WriteLine(ex);  //object doner
            }

            //format exception

            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun degil");

                Console.WriteLine(ex.Message.ToString());    // Input string was not in a correct format.   
            }

            //overflow excepition
            catch (OverflowException ex)
            {
                Console.WriteLine("girilen sayı cok buyuk ya da cok buyuk  ");

                Console.WriteLine(ex);                   //Value was either too large or too small for an Int32.

            }

            finally
            {
                Console.WriteLine("islem tamamlandı");
            }








        }
    }
}
