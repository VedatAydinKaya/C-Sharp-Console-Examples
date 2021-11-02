using System;

namespace arayuzler_ornek
{
    class Program
    {
        static void Main(string[] args)
        {

            Focus focus = new Focus();

            Console.WriteLine(focus.HangiMarkanınAraci().ToString());   // enum =>>>>>>> to string
            Console.WriteLine(focus.KacTekerlektenOlusur());
            Console.WriteLine(focus.StandartRengiNe().ToString());  // enum =>>>>>>> to string


            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkanınAraci().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur());
            Console.WriteLine(civic.StandartRengiNe().ToString());



        }
    }
}
