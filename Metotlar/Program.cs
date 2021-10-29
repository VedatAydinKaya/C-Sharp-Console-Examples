using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // erisim_belirteci geri_donustipi metot_adi(parametreListesi/arguman)
            //{ 
            //      //komutlar

            //return

            //}


            int a = 2, b = 3;
            
            int sonuc=Topla(a,b);
            Console.WriteLine(sonuc);
            Console.WriteLine(Cikar(a,b));


            // Main Methodda farklı bir class uzerinden bir methoda erismek icin o classın instance olusturmamız gerekir.

            Metotlar ornek = new Metotlar();   // Class instance olusturuldu

            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArtirVeTopla(ref a, ref b);  // a ve ve b degisti neden cunku ref type ile methot degisiklikten etkilendi bellekteki adresleri modify oldu

            ornek.EkranaYazdir(Convert.ToString(sonuc2));

            ornek.EkranaYazdir(Convert.ToString(a + b));  //5 degerini degil artık  7 degerini alır  cunku ref tipleri ile degisti    // artık a=3 b=4 oldu


            string kelime1 = "DENEME";

            MetotEkran ornekal = new MetotEkran();


            string result = ornekal.YaziKucult(kelime1);

            ornek.EkranaYazdir(result);



        }

        // Aynı Class Uzerinden Metot Olusturma
        static int Topla(int deger1, int deger2) 
        {
            return (deger1 + deger2);
        }

        static int Cikar(int deger1, int deger2) 
        {
            return deger1 - deger2;
        
        }




    }


    // Yeni bir Class Olusturma
    class Metotlar 
    {
       public  void EkranaYazdir(string veri) 
        {
            Console.WriteLine(veri);
        }
        public int ArtirVeTopla(ref int deger1,  ref int deger2) 
        {
            deger1+=1;
            deger2+=1;
            return deger1 + deger2;
        
        }
             
              
    }

    // Yeni Class
    class MetotEkran 
    {
        public string YaziKucult(string veri) 
        {
            return(veri.ToLower());
        }   
             
    
    }

}
