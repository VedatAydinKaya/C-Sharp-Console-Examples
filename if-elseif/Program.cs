using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            Console.WriteLine(time);

            if (time >= 6 && time < 11)
                Console.WriteLine("Gunaydın");
            else if (time <= 18)
                Console.WriteLine("İyi gunler");
            else
                Console.WriteLine("iyi geceler");

            string sonuc = time <= 18 ? "iyi gunler" : "iyi geceler";

            sonuc = time >= 6 && time < 11 ? "Gunaydın" : time <= 18 ? "İyi gunler" : "iyi geceler";

            Console.WriteLine(sonuc);

        }
    }
}
