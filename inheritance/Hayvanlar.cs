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
    }

    public class Surungunler:Hayvanlar
    {
        public Surungunler() 
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltım();
            base.Solunum();

        }

        public void SurunerekHareket() 
        {
            Console.WriteLine("Surungunler surunerek hareket ederler");
        }
    }

    public class Kuslar:Hayvanlar
    {

        public Kuslar() 
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltım();
            base.Solunum();

        }
        public void Ucmak() 
        {
            Console.WriteLine("Kuslar ucarlar");
        }
    
    }
}
