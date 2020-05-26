using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03ArrayNControls
{
    class MyRandom
    {
        public static void ZeigeRandom()
        {
            Random random = new Random();
            int zufallszahl = random.Next(5); // liefert eine Zufallszahl zw. 0 und 4 inclusive
            Console.WriteLine($"Zufallszahl1: {zufallszahl}");
            Random random2 = new Random();
            Console.WriteLine($"Zufallszahl2: {random2.Next(1, 5)}");

        }
    }
}
