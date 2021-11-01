using System;

namespace struct_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {

            Dikdortgen dikdortgen = new Dikdortgen();

            //dikdortgen.KisaKenar = 3;

            //dikdortgen.UzunKenar = 4;

            Console.WriteLine("Dikdortgen Alan Hesabi:{0} ",dikdortgen.AlanHesapla());



            //  struct ile nesnesi yaratılmadan da field ve propertylere erisilebilir !!!

            Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct(3, 5);

            

            Console.WriteLine("Dikdortgen Alan Hesabi:{0}",dikdortgen_Struct.AlanHesapla());

        }
    }
           
    class Dikdortgen
    {
        public int KisaKenar;

        public int UzunKenar;

        // default constructor

        //public Dikdortgen()
        //{
        //    KisaKenar = 3;
        //    UzunKenar = 4;   // default constructorda  defaault olarak parametre atandi eger parametre verilmezse int=0 string=null atar
        //}

        public long AlanHesapla() 
        {
            return this.KisaKenar * this.UzunKenar;
        }

    
    }

    struct Dikdortgen_Struct 
    {
        public int KisaKenar;

        public int UzunKenar;



        // Struct initial olarak deger atamıyor =>>>>>>  default constructorda  
        public Dikdortgen_Struct(int kisaKenar, int uzunKenar)
        {
           
            KisaKenar = kisaKenar;
            UzunKenar = uzunKenar;
        }

        public long AlanHesapla() 
        {
            return this.KisaKenar * this.UzunKenar;
        }

    
    }
}
