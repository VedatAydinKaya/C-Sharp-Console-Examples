using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            //                   Canlılar
            //                     |
            //      Bitkiler                    Hayvanlar
            //
            //     |       |                   |                 |
            //  Tohumlu    Tohumsuz         Surungenler         Kuslar

            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
        
            tohumluBitki.TohumlaCogalma(); // once constuctor calisti sonra metot islendi

            Console.WriteLine("******************");

            Kuslar marti = new Kuslar();
       
           
            marti.Ucmak();



        } 
    }
}
