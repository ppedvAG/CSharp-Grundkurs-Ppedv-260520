using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02Demo_bool
{
    class Dbool
    {
        static bool myB1 = true;
        static bool myB2 = false;
        static bool myB3 = true;

        public static void ZeigeGleichheit()
        {
            Console.WriteLine($"myB1 == myB2: {myB1 == myB2}"); // False
            Console.WriteLine($"4 == 5: {4 == 5}"); // False
            Console.WriteLine($"\"bla\" == \"bla\": {"bla" == "bla"}"); // True
        }

        public static void ZeigeUngleichheit()
        {
            Console.WriteLine($"myB1 != myB2: {myB1 != myB2}"); // True
        }

        public static void ZeigeUnd()
        {
            Console.WriteLine("ZeigeUnd");
            Console.WriteLine(myB1 != myB2 && "bla" == "bla"); // True
            Console.WriteLine(myB1 != myB2 && myB3); // True
        }

        public static void ZeigeOder()
        {
            Console.WriteLine("ZeigeOder");
            Console.WriteLine(myB1 != myB2 || "bla" == "bla"); // True
            Console.WriteLine(myB1 != myB2 || false); // True
        }

        public static void ZeigeAusschlOder()
        {
            Console.WriteLine("ZeigeAusschlOder");
            // Entweder links oder rechts darf true stehen, 
            // damit der gesamte Ausdruck auch true hat
            Console.WriteLine(myB1 != myB2 ^ "bla" == "bla"); // False
            Console.WriteLine(myB1 != myB2 ^ false); // True
        }

        static void Main(string[] args)
        {
            ZeigeGleichheit();
            ZeigeUngleichheit();
            ZeigeUnd();
            ZeigeOder();
            ZeigeAusschlOder();
            Console.ReadKey();
        }
    }
}
