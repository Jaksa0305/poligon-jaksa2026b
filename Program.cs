using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon_jaksa2026b
{
    internal class Program
    {
        public static void Main(string[] args)
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



            tacka a = new tacka(1, 3);
            tacka b = new tacka(1, 1);
            tacka c = new tacka(4, 0);
            tacka d = new tacka(3, 3);
            Vektor ab = new Vektor(a, b);
            Vektor bc = new Vektor(b, c);
            Vektor cd = new Vektor(c, d);
            Vektor da = new Vektor(d, a);

            double ab_len = ab.duzina();
            double bc_len = bc.duzina();
            double cd_len = cd.duzina();
            double da_len = da.duzina();


            // kvadrat:
            // ab = bc = cd = da
            // ab L bc
            if ((ab_len == bc_len) && (bc_len == cd_len) && (cd_len == da_len))
                if (Vektor.SP(ab, bc) == 0)
                    Console.WriteLine("jeste kvadrat");
                else Console.WriteLine("nije kvadrat");
            else Console.WriteLine("nije kvadrat");
            // pravougaonik:
            // ab = cd, bc = da
            // ab L bc
            if ((ab_len == cd_len) && (bc_len == da_len))
            {
                if (Vektor.SP(ab, bc) == 0)
                {
                    Console.WriteLine("jeste pravougaonik");
                }
                else Console.WriteLine("nije pravougaonik");
            }
            else Console.WriteLine("nije pravougaonik");
            // deltoid:
            // ab = da & bc = cd
            // ab = bc & cd = da
            if ((ab_len == da_len) && (bc_len == cd_len))
            {
                Console.WriteLine("jeste deltoid: ab=da");
            }
            else
            if ((ab_len == bc_len) && (cd_len == da_len))
            {
                Console.WriteLine("Jeste deltoid AB=BC");
            }
            else Console.WriteLine("nije deltoid"); ;


        }








    }
}
