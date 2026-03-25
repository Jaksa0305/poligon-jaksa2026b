using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon_jaksa2026b
{
    internal class Vektor
    {

        public tacka pocetak;
        public tacka kraj;
        public tacka centriraj()
        {
            double x = kraj.x - pocetak.x;
            double y = kraj.y - pocetak.y;
            return  new tacka(x, y);

        }
        public void stampaj()
        {
            Console.WriteLine("x1={0} , y1={1} do x2={2}, y2={3}", pocetak.x , pocetak.y, kraj.x,kraj.y);
        }

        public Vektor(tacka a , tacka b)
        {
            pocetak = a;
            kraj = b;
        }
        
        public static double SP(Vektor a, Vektor b)
        {
            tacka a1 = a.centriraj();
            tacka b1 = b.centriraj();
            return a1.x * b1.x + a1.y * b1.y;
        }
        public static double VP(Vektor a, Vektor b)
        {
            tacka A = a.centriraj();
            tacka B = b.centriraj();
            double k = A.x * B.y - A.y * B.x;
            return k;
        }

        public double duzina()
        {
            
            tacka druga = this.centriraj();
            
            return druga.d();
        }


    }
}
