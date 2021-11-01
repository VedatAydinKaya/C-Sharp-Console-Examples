using System;

namespace c_Sharp_enum
{
    class Program
   {
    static void Main(string[] args)
    {


            /*
             
             * Uygulama geliştirirken sabit değerlerle çalışmak durumunda kalırız. 
             * Bu noktalarda okunabilirliği yüksek bir program yazmak istiyorsak enum lardan faydalanırız.
             "enum" anahtar kelimesi enumeration yani numaralandırma kelimesinden gelir. 
            
             Sayısal verileri string ifadelerle saklamanızı sağlar
             
             
             
             
             
             */
            Console.WriteLine(Gunler.Pazartesi);
            Console.WriteLine((int)Gunler.Cumartesi);
            int sicaklik = 28;

            if (sicaklik<=(int)HavaDurumu.Normal)
                Console.WriteLine("Dısarıya cıkmak icin havanın biraz daha ısınmasını beklemelisin !!!!");
            else if (sicaklik>=(int)HavaDurumu.Sıcak)
                Console.WriteLine("Dısariya çıkmak icin cok sıcak");
            else if (sicaklik>(int)HavaDurumu.Normal && sicaklik<(int)HavaDurumu.CokSıcak)
                Console.WriteLine("Hadi disariya cikalım");

            
            
    }
   }

    enum Gunler 
    {
      Pazartesi=1,
      Salı,
      Çarşamba,
      Perşembe,
      Cuma=27,
      Cumartesi,
      Pazar
    }

    enum HavaDurumu 
    {
       Soguk=5,

       Normal=20,

       Sıcak=25,

       CokSıcak=30
      
    }

}
