using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01Demo_Console
{
    class DConsole
    {
        static void Main(string[] args)
        {
            #region 1
            Console.WriteLine("### WriteLine(string) ###");
            int alter = 35;
            string name = "Vadzim";
            Console.WriteLine("mein Text für die Konsole");
            Console.WriteLine(alter);
            Console.WriteLine(name);
            #endregion

            #region 2
            Console.WriteLine("### WriteLine(string, arg0, arg1) ###");
            Console.WriteLine("Ich heiße {0} und bin {1} Jahre alt.", name, alter);
            #endregion

            #region 3
            Console.WriteLine("### Write(string) ###");
            Console.Write("Text ohne Zeilenumbruch danach");
            #endregion

            #region 4
            Console.WriteLine("### OutputEncoding ###");
            Console.WriteLine("Eurozeichen: €");
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Eurozeichen: €");
            #endregion

            #region 5
            Console.WriteLine("### ReadLine() ###");
            Console.WriteLine("Geben Sie einen Text ein und klicken Sie auf 'Enter': ");
            string eingabe = Console.ReadLine();
            Console.WriteLine("Sie haben eingegeben: {0}", eingabe);
            #endregion

            #region 6
            Console.WriteLine("### ReadKey() ###");
            Console.ReadKey();
            #endregion
        }
    }
}
