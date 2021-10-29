using System;

namespace Hazir_Metotlar_DateTime_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);


            Console.WriteLine(DateTime.Now.DayOfWeek);

            Console.WriteLine(DateTime.Now.DayOfYear);



            Console.WriteLine(DateTime.Now.ToLongDateString());  //29 Ekim 2021 Cuma

            Console.WriteLine(DateTime.Now.ToShortDateString()); //29.10.2021

            Console.WriteLine(DateTime.Now.ToLongTimeString()); // 21:08:17

            Console.WriteLine(DateTime.Now.ToShortTimeString());  //21:08



            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddMinutes(30));
            Console.WriteLine(DateTime.Now.AddSeconds(20));
            Console.WriteLine(DateTime.Now.AddYears(20));

             
            // DateTime Format  =>>>>>>>>>>>ToString

            Console.WriteLine(DateTime.Now.ToString("dd")); // 29
            Console.WriteLine(DateTime.Now.ToString("ddd")); // Fri
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Friday

            Console.WriteLine(DateTime.Now.ToString("MM")); // 29
            Console.WriteLine(DateTime.Now.ToString("MMM")); // Sep
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //April

            Console.WriteLine(DateTime.Now.ToString("yy")); //21
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //2021




            // Math Kutuphanesi


            Console.WriteLine(Math.Abs(-25)); //25
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));


            Console.WriteLine(Math.Ceiling(7.3)); //8
            Console.WriteLine(Math.Floor(7.3));  //7
            Console.WriteLine(Math.Round(7.7));  //8


            Console.WriteLine(Math.Max(2,6));  // 6
            Console.WriteLine(Math.Min(2,6));   //2

            Console.WriteLine(Math.Pow(3,4));  //81
            Console.WriteLine(Math.Sqrt(9));   //3
            Console.WriteLine(Math.Log(5));
            Console.WriteLine(Math.Exp(3));  // e^3

            Console.WriteLine(Math.Log10(10))  //1;








        }
    }
}
