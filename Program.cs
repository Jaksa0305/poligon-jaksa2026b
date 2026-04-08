using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon_jaksa2026b
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
           tacka A = new tacka(2, 3);
           tacka B = new tacka(4, 5);
           tacka C = new tacka(6, 7);
           tacka D = new tacka(8, 9);
           vektor AB = new vektor(A, B);
           AB.stampaj();
           */
            /* Poligon prvi = Poligon.unos();
            prvi.stampa();
            prvi.snimi();*/

            // Poligon drugi = Poligon.ucitaj();
            //drugi.stampa();
            /*tacka A = new tacka(1, 1);
            tacka B = new tacka(5, 1);
            tacka C = new tacka(2, 0.1);
            tacka D = new tacka(2, 0);
            Vektor AB = new Vektor(A, B);
            Vektor CD = new Vektor(C, D);
            Console.WriteLine(AB.Sece(CD));*/

            Poligon prvi = Poligon.unos();
            if (prvi.prost())
            {
                Console.WriteLine(prvi.povrsina());

            }
            else Console.WriteLine("nije prost");
        }
    }
}
