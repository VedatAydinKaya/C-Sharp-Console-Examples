using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
   public class Canlilar
    {
        protected void Beslenme() 
        {
            Console.WriteLine("Canlilar beslenirler");
        }
        protected void Solunum() 
        {
            Console.WriteLine("Canlilar solunum yaparlar");
        }

        protected void Bosaltım() 
        {
            Console.WriteLine("Canlilar bosaltım yaparlar");
        }
    }
}
