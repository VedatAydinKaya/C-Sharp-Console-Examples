using System;

namespace HazırMetotlar_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp Hosgeldiniz:";
          //  string degisken2 = "Dersimiz CSharp Hosgeldiniz:";

            string degisken2 = "CSharp";



            // length
            Console.WriteLine(degisken.Length);

          //   ToLower , ToUpper Methods

            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper());

            //Concat

            Console.WriteLine(String.Concat(degisken,"Merhaba!"));


            // Compare,CompareTo

            Console.WriteLine(degisken.CompareTo(degisken2));  // 0,1,-1 alır

            Console.WriteLine(String.Compare(degisken,degisken2,true)); // 0 output

            Console.WriteLine(String.Compare(degisken,degisken2,false)); // -1 output


            // Contains

            Console.WriteLine(degisken.Contains(degisken2));  // true
            Console.WriteLine(degisken.StartsWith("Dersimiz"));  //true

            Console.WriteLine(degisken2.EndsWith("CSharp"));  //true

            // Console.WriteLine(degisken2.StartsWith("CSharp"));  //true


            // IndexOf  =>> Returns first index its

            Console.WriteLine(degisken.IndexOf("CS"));   // 9

            Console.WriteLine(degisken2.IndexOf("Vedat"));   // -1


            //Insert 

            Console.WriteLine(degisken2.Insert(0,"MERHABA ! "));

            //lastIndexOf

            Console.WriteLine(degisken.LastIndexOf("i"));  //25


            //PadLeft,PadRight

            Console.WriteLine(degisken+degisken2.PadLeft(30));          //Dersimiz CSharp Hosgeldiniz:                        CSharp
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));     //Dersimiz CSharp Hosgeldiniz:************************CSharp

            Console.WriteLine(degisken.PadRight(50)+degisken2);          //Dersimiz CSharp Hosgeldiniz:                      CSharp
            Console.WriteLine(degisken.PadRight(50,'-') + degisken2);      // Dersimiz CSharp Hosgeldiniz: ----------------------CSharp


            // remove

            Console.WriteLine(degisken.Remove(10));

            Console.WriteLine(degisken.Remove(5,7));



            // Replace

            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split

            Console.WriteLine(degisken.Split(" ")[1]);


            //Substring 

            Console.WriteLine(degisken.Substring(6));
            Console.WriteLine(degisken.Substring(4,6));



        }
    }
}
