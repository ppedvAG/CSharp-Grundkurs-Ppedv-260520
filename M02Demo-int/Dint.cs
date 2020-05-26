using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02Demo_int
{
    class Dint
    {
        // Default-Wert bei int ist 0

        public static void ZeigeLiterals()
        {
            int myInt = -3;
            int myInt2 = 0b_0000_0000_0000_0000_0000_0000_0000_1011; // wird bei der Ausgabe dezimal dargestellt
            Console.WriteLine($"{myInt}, {myInt2}");
        }

        public static void ZeigeMöglicheWerte()
        {
            Console.WriteLine($"int.MaxValue: {int.MaxValue}");
            Console.WriteLine($"int.MinValue: {int.MinValue}");
        }

        public static void ZeigeParsing()
        {
            string myStr = "3";
            string myStr2 = "f";
            // System.Int32
            int myInt = int.Parse(myStr);
            int myInt2;
            bool istMöglich = int.TryParse(myStr2, out myInt2);
            Console.WriteLine($"myInt: {myInt}, istMöglich: {istMöglich}, myInt2: {myInt2}");
            // default-Wert bei int ist 0
        }

        public static void ZeigeCasting()
        {
            double kommaZahl = 44.32;
            int ganzeZahl = (int)kommaZahl;
            Console.WriteLine($"ganzeZahl: {ganzeZahl}"); // 44
        }

        public static void ZeigeVergleich()
        {
            Console.WriteLine($"5 >= 3: {5 >= 3}"); // True
                                                    // 3 > 5, <, >=, <=


        }
        static void Main(string[] args)
        {
            ZeigeLiterals();
            ZeigeMöglicheWerte();
            ZeigeParsing();
            ZeigeCasting();
            ZeigeVergleich();
            Console.ReadKey();

        }
    }
}
