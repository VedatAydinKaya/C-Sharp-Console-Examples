using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arayuzler_yeni_ornek
{
    public class Civic : IOtomobil
    {
        public Marka HangiMarkanınAraci()
        {
            return Marka.Honda;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;

        }

        public Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }
}
