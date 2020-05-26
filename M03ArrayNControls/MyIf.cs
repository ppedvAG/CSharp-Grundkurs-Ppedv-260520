using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03ArrayNControls
{
    class MyIf
    {
        public static void ZeigeTrueBlock()
        {
            int myInt1 = 2;
            int myInt2 = 5;

            Console.WriteLine("\nVergleich als Bedingung");
            if (myInt1 < myInt2)
            {
                Console.WriteLine("myInt2 ist größer");
            }
            else
            {
                Console.WriteLine("myInt1 ist größer");
            }

            Console.WriteLine("\nnull als Bedingung - in C# nicht möglich");
            //if (null)
            //{
            //    Console.WriteLine("null");
            //}

            Console.WriteLine("\nWert als Bedingung - in C# nicht möglich, " +
                "es werden nur Anweisungen erwartet, die bool zurückgeben");
            //if (myInt1)
            //{
            //    Console.WriteLine("null");
            //}            
        }

        public static void ZeigeTernärenOperator()
        {
            Console.WriteLine(true ? "true" : "false");
            string myStr = "heute";
            Console.WriteLine(myStr == "morgen" ? "heute" : "morgen");
        }
    }
}
