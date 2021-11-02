

namespace abstract_ornek
{
   public abstract class Otomobil
    {
        public int KacTekerlektenOlusur() 
        {
            return 4;
        }

        public virtual Renk StandartRengiNe() 
        {
            return Renk.Beyaz;
        }

        public abstract Marka HangiMarkanınAraci();   // Eger burada abstract method olarak yazarsak; alt sınıflara bunu implemente etmeye
                                                       // ve govdesini yazmaya zorlamıs olurum ve her biri icin farklı oldugundan hiç ortak olmadıgından
                                                       // en dogru yontem olmus olur // ABSTRACT METOTLARIN GOVDESI YAZILMAZ ZORLAMIS OLDUUK ALT SINIFLARDA YAZILMASINA

        

    }
}
