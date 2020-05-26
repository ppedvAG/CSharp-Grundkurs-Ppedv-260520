using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03ArrayNControls
{
    class MyArray
    {
        public static void ZeigeArray()
        {
            string[] arrOfStr = new string[3];
            // in anderen Sprachen:
            // Array arr = new Array();
            arrOfStr[1] = "Tulpe";
            arrOfStr[2] = "Rose";
            Console.WriteLine($"arrOfStr: {arrOfStr}"); // zeigt nur den Datentyp: System.String[]
                        
            foreach (string item in arrOfStr)
            {
                //if (item == "")
                //{ 
                //    Console.WriteLine("Leeres Element");
                //}
                // Ist im True-Block bei If nur eine einzelne Anweisung, 
                // dann sind die geschw. Klammern optional
                if (item == null)
                    Console.WriteLine("Leeres Element");
                // null ist Default-Wert bei Strings
                // leere Zeile bei der Ausgabe, weil null.ToString() -> leeres String
                Console.WriteLine(item);
            }
        }


        public static void ZeigeDoubleArray()
        {
            double[] arrOfDbl = new double[] { 4.2, 6.3, 5.2 };

            for (int i = arrOfDbl.Length-1; i > -1; i--)
            {
                Console.WriteLine(arrOfDbl[i]);
            }            
        }
    }
}
