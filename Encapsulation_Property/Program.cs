using System;

namespace encapsulation_property
{
    class Program
    {

        //Enkapsulleme bir özeliği başka sınıflardan saklamak yada korumaktır.
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();

            ogrenci.Isim = "Ayse";
            ogrenci.Soyisim = "Yilmaz";
            ogrenci.Sinif = 3;
            ogrenci.OgrenciNo = 292;

            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifArttir();
            ogrenci.OgrenciBilgileriniGetir();


            Ogrenci ogrenci1 = new Ogrenci("Deniz", "Arda", 256, 1);

            ogrenci1.SinifAzalt();
            ogrenci1.SinifAzalt();
            ogrenci.OgrenciBilgileriniGetir();


        }
    }


    class Ogrenci 
    {
        // field alani

        private string isim;     

        private string soyisim;

        private int ogrenciNo;

        private int sinif;


        // Encapsulleme =>>>>>>>> Public Property alani
        public string Isim    
        {
            get { return isim; }         // get field degerini geri dondurmeye yarar;  sadece get varsa read-only olur

            set { isim = value; }       // set field degerine yeni deger atamaya yarar
        
        }

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        {
            get => sinif;

            set 
            {
                if (value<1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir !!!");
                    sinif = 1;
                }
                else
                  sinif = value;   
            } 
        

        }

        // Constructor

        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci() { }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("*************** Ogrenci Bilgileri****************");
            Console.WriteLine("Ogrenci Adi:            {0}",this.Isim);
            Console.WriteLine("Ogrenci Soyismi:        {0}", this.Soyisim);
            Console.WriteLine("Ogrenci No:             {0}", this.OgrenciNo);
            Console.WriteLine("Ogrenci Sınıf:          {0}",this.Sinif);
        }
        public void SinifArttir() 
        {
            this.Sinif = this.Sinif + 1;
        }
        public void SinifAzalt() 
        {
            this.Sinif = this.Sinif - 1;
        }

    }
}
