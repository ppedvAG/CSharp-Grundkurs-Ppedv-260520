using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02Demo_string
{
    class Dstring
    {
        // null ist Default-Wert bei Strings

        public static void ZeigeInterpoliertesString()
        {
            Console.WriteLine("ZeigeInterpoliertesString");
            string interpolStr = $"DateTime.Now: {DateTime.Now}";
            Console.WriteLine(interpolStr);
        }

        public static void ZeigeEscapes()
        {
            Console.WriteLine("ZeigeEscapes");
            string myStr = "\n nach n, \t nach t";
            Console.WriteLine(myStr);
        }

        public static void ZeigeVerbatimString()
        {
            Console.WriteLine("ZeigeVerbatimString");
            string myStr = @"
            nach n,          nach t";
            Console.WriteLine(myStr);
        }

        public static void ZeigeInterpoliertesVerbatimString()
        {
            Console.WriteLine("ZeigeInterpoliertesVerbatimString");
            string myStr = $@"
nach n,     {DateTime.Now}    nach t";
            Console.WriteLine(myStr);
        }

        static void Main(string[] args)
        {
            ZeigeInterpoliertesString();
            ZeigeEscapes();
            ZeigeVerbatimString();
            ZeigeInterpoliertesVerbatimString();
            Console.ReadKey();
        }
    }
}
