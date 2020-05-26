using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M04Demo_Methods
{
    class DMethods
    {
        static void Main(string[] args)
        {
            // var rückgabe = MOhneReturn();
            // void rückgabe = MOhneReturn();

            //MOhneReturn();

            //bool rückgabe2 = MMitReturn();
            //Console.WriteLine($"Die Antwort war: {rückgabe2}");

            //Console.WriteLine(FrageNachWohlergehen());

            //Console.WriteLine(BerechneStringLänge("3e67gh6cxfg"));

            //Console.WriteLine(Addiere(4, 5, 6, 3, 2, 0, -34));

            //            Console.WriteLine($@"
            //4 + 5 = {WendeVierMathOpsAn(4, 5, out int diff, out int prod, out int quot)},
            //4 - 5 = {diff},
            //4 * 5 = {prod},
            //4 / 5 = {quot}");

            Console.WriteLine(Addiere(5,6));
            // Overload wurde aufgerufen, nicht die Variante mit params, weil es genau der Form entspricht 'Methode mit 2 Argumenten'

            double d1 = 364.32, d2 = 345.64;
            double mod = 0;
            double max = 4.54;
            GibModuloUndMax(d1, d2, ref mod, ref max);
            Console.WriteLine($@"
{d1} % {d2} = {mod},
Max({d1}, {d2}) = {max}");
            Console.ReadKey();
        }

        static void MOhneReturn()
        {
            bool istGut = true;
            Console.WriteLine($"Corona ist gut? {istGut}");
        }

        static bool MMitReturn()
        {
            Console.Write("Geht es Ihnen gut? - ");
            if (Console.ReadLine() == "ja")
                return true;
            else return false;
        }

        static string FrageNachWohlergehen()
        {
            Console.Write("Geht es Ihnen gut? - ");
            return Console.ReadLine();
        }

        static int BerechneStringLänge(string parameter)
        {
            return parameter.Length;
        }

        static int Addiere(params int[] zahlen)
        {
            return zahlen.Sum();
        }

        static int Addiere(int a, int b)
        {
            var sum = a + b;
            Console.WriteLine("Meldung aus Addiere(a,b)");
            return sum;
        }

        static int WendeVierMathOpsAn(int a, int b, out int differenz, out int produkt, out int quotient)
        {
            differenz = a - b;
            produkt = a * b;
            quotient = a / b;
            return a + b;
        }

        static void GibModuloUndMax(double a, double b, ref double m, ref double max)
        {
            m = a % b;
            max = Math.Max(a, b);
        }
    }
}
