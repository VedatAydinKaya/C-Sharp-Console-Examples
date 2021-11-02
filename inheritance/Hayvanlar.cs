using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Hayvanlar:Canlilar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar Adaptasyon yaparlar");
        }
        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();    // üst sınıftaki komutları çalıştırır.

            Console.WriteLine("Hayvanlar temasa tepki verir");
        }
    }

    public class Surungunler:Hayvanlar
    {
        public Surungunler() 
        {
            base.Adaptasyon();  // hayvanlaradan alınan kalıtım ile fotosentez yapma metotu tanımlandı
            base.Beslenme();    // hayvanlar da canlılardan kalıtım alarak beslenme metotu ozelligini kazandı
            base.Bosaltım();    // hayvanlar da canlılardan kalıtım alarak bosaltım metotu ozelligini kazandı
            base.Solunum();     // hayvanlar da canlılardan kalıtım alarak solunum metotu ozelligini kazandı

        }

        public void SurunerekHareket() 
        {
            Console.WriteLine("Surungunler surunerek hareket ederler");
        }
    }

    public class Kuslar:Hayvanlar
    {

        public Kuslar()  // Constructor
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltım();
            base.Solunum();
            base.UyaranlaraTepki();

        }
        public void Ucmak() 
        {
            Console.WriteLine("Kuslar ucarlar");
        }
    
    }
}
