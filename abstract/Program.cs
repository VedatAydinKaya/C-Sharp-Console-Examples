using System;

namespace abstract_ornek
{
    class Program
{
    static void Main(string[] args)

    {
            /* 
             
     Abstract class ları sadece kalıtım için kullanılan sınıflar gibi düşünebilirsiniz. 
     Bazı özellikleri ile sınıflara benzerlerken bazı özellikleriyle arayüzlere benzerler.
     Abstract sınıfları arayüz ve virtual metotların birleşimi gibi davranış gösterirler.

    Kısaca abstract sınıfların özelliklerine bakacak olursak:

             
    * Normal sınıflar gibi new() anahtar kelimesi ile türetilemezler.
    * Interface ler gibi metot bildirimi yapabilirsiniz.
    * Sanal metotları override eder gibi abstract metotlar override edilebilir.
    * Abstract metotların gövdesi yazılamaz.
    * Bir abstract class bir abstract metot içeriyorsa, abstract sınıftan türeyen tüm sınıflar bu metodu override etmek zorundadır.
    * Bir sınıf sadece tek abstract sınıftan kalıtım alabilir
    * Abstract sınıf başka bir abstract sınıftan kalıtım alabilir.
    * Dolaylı olacak türeyen sınıfta birden fazla abstract dan kalıtım almış olur. 
    * Ve bağlantılı olduğu tüm abstract sınıfların bildirimi yapılmış olan abstract metotlarını override etmek zorundadır.
             
             
             
             */


            NewFocus newFocus = new NewFocus();
            Console.WriteLine(newFocus.HangiMarkanınAraci().ToString());
            Console.WriteLine(newFocus.KacTekerlektenOlusur());
            Console.WriteLine(newFocus.StandartRengiNe().ToString());


            NewCivic newCivic = new NewCivic();
            Console.WriteLine(newCivic.HangiMarkanınAraci().ToString());
            Console.WriteLine(newCivic.KacTekerlektenOlusur());
            Console.WriteLine(newCivic.StandartRengiNe().ToString());
    }
}
}
