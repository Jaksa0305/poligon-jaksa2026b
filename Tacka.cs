using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon_jaksa2026b
{
    internal class Tacka
    {

        public double x;
        public double y;
        public double d()
        {
            return Math.Sqrt(x*x + y*y);
        }
        
        public Tacka(double a, double b) {

            x = a;
            y = b;
            
        }

    }
}
