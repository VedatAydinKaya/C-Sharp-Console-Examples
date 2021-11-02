using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Bitkiler:Canlilar
    {

        protected void FotosentezYapmak()        // bulundugu class ve miras verdigi diger classlardan erisilir
        {
            Console.WriteLine("Bitkiler fotosentez yaparlar");
        }

        public override void UyaranlaraTepki()
        {
           // base.UyaranlaraTepki();   // üst sınıftaki komutları çalıştırır.

            Console.WriteLine("Bitkiler güneşe tepki verir.");
        }

    }

    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler()    //Constructor nesne ilk ayaga kalktıgında yapılması istenen seyler constructor metotta tanımlanır
        {
            base.FotosentezYapmak();  // bitkilerden alınan kalıtım ile fotosentez yapma metotu tanımlandı
            base.Beslenme();          // bitkiler de canlılardan kalıtım alarak beslenme metotu ozelligini kazandı
            base.Bosaltım();         // bitkiler de canlılardan kalıtım alarak bosaltım metotu ozelligini kazandı
            base.Solunum();          // bitkiler de canlılardan kalıtım alarak solunum metotu ozelligini kazandı
            base.UyaranlaraTepki();
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
