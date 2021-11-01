using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Bitkiler:Canlilar
    {

        protected void FotosentezYapmak() 
        {
            Console.WriteLine("Bitkiler fotosentez yaparlar");
        }
    }

    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler() 
        {
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltım();
            base.Solunum();
            
        }

        public void TohumlaCogalma() 
        {
            Console.WriteLine("Tohumlu bitkiler tohumla cogalir");
        }
    }

    public class TohumsuzBitkiler : Bitkiler
    {

        public TohumsuzBitkiler() 
        {
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltım();
            base.Solunum();

        }
        public void SporlaCogalma() 
        {
            Console.WriteLine("Tohumsuz bitkiler sporla cogalir");
        }
    }
}
