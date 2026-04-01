using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon_jaksa2026b
{
    internal class Ravan
    {

        public static int SIS(Vektor a, tacka B, tacka C)
        {

            Vektor AB = new Vektor(a.pocetak, B);
            Vektor AC = new Vektor(a.pocetak, C);
            double aAB = Vektor.VP(a, AB);
            double aAC = Vektor.VP(a, AC);
            if (aAC * aAB > 0) return 0;
            if(aAC * aAB < 0)return-1;
            return 1;
            
            
            

        }

    }
}
