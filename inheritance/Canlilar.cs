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


        /* Polymorphisim (Cok Bicimcilik) 
         
         
        Çok biçimcilik ile birlikte hayatımıza sanal yani virtual metotlar giriyor. 
        Virtual metotlar ile nesne yönelimli programlama ilkesi olan polymorphism'i uygularız. 
        Sanal metotlar kalıtım alınan yani miras veren sınıf içerisinde yazılan ve daha sonra alt sınıflarda yeniden yazılabilen metotlardır.
        Bunu da virtual ve override anahtar kelimeleri sağlar.
         
       
         */

        public virtual void UyaranlaraTepki() 
        {
            Console.WriteLine("Canlılar uyaranlara tepki verir.");
        }

    }
}
