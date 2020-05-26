using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03ArrayNControls
{
    class M3Main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n ### If-Control ###");
            MyIf.ZeigeTrueBlock();
            MyIf.ZeigeTernärenOperator();

            Console.WriteLine("\n ### Array ###");
            MyArray.ZeigeArray();
            MyArray.ZeigeDoubleArray();

            Console.WriteLine("\n ### Random ###");
            MyRandom.ZeigeRandom();

            Console.ReadKey();
        }
    }
}
