using System;
using System.Collections.Generic;

namespace dictionaryList
{
    class Program
    {
        static void Main(string[] args)
        {
            //System Collections Generic namespace altında bulunurlar
            
            // key,value pair  =>>>>>>>>>>>> key ifadeler unique olmalı

             Dictionary<int,string> kullanicilar=new Dictionary<int, string>();

            kullanicilar.Add(10, "Ayse Yılmaz");
            kullanicilar.Add(12, "Deniz Arda");
            kullanicilar.Add(18, "Ahmet Yılmaz");
            kullanicilar.Add(20, "Ozcan Cosar");
            // elemanlara erisim

            Console.WriteLine(kullanicilar[18]);
            foreach (var item in kullanicilar)
                Console.WriteLine($"KEY:{item.Key} Value:{item.Value} ");


            //Count
            Console.WriteLine("****Count ****");
            Console.WriteLine(kullanicilar.Count);


            //Contains

            Console.WriteLine("****CONTAINS ****");

            Console.WriteLine(kullanicilar.ContainsKey(17));  // false
            Console.WriteLine(kullanicilar.ContainsValue("Ayse Yılmaz"));  //true

            // Remove
            Console.WriteLine("********REMOVE*********");

            kullanicilar.Remove(12);
            foreach (var item in kullanicilar)
                Console.WriteLine(item.Value);

            // keys

            Console.WriteLine("****Keys****");
            foreach (var item in kullanicilar.Keys)
                Console.WriteLine(item);

            // Value

            Console.WriteLine("**** Value****");

            foreach (var item in kullanicilar.Values)
                Console.WriteLine(item);
                     
            
            


        }
    }
}
