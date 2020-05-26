using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03Lab_Zahlenratespiel
{
    class Zahlenraten
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int zufallszahl = generator.Next(1, 5);
            Console.WriteLine("zufallszahl: {0}", zufallszahl);

            int ratemalzahl;
            int counter = 0;
            do
            {
                Console.WriteLine("Erraten Sie eine int-Zahl zwischen 1 und 4: ");
                ratemalzahl = int.Parse(Console.ReadLine());
                if (zufallszahl == ratemalzahl)
                {
                    Console.WriteLine("Sie haben die Zahl erraten");
                }
                else if (zufallszahl < ratemalzahl)
                {
                    Console.WriteLine("Zufallszahl ist kleiner als Sie denken");

                }
                else
                {
                    Console.WriteLine("Zufallszahl ist größer als Sie denken");
                }
                counter++;
            } while (zufallszahl != ratemalzahl);
            Console.WriteLine("~~~ Sie haben die Zahl beim {0}. Versuch erraten.", counter);
            Console.ReadKey();
        }
    }
}
