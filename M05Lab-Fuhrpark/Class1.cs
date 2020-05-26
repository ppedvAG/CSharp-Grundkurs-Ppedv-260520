using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05Lab_Fuhrpark
{
    public class Class1
    {
        // Methoden ohne Modifizierer sind private
        public static void StaticVoid()
        {
            Console.WriteLine("Hallo aus StaticVoid");
            // PrivateVoid(); // nicht statische Methode kann ohne eine Instanz nicht aufgerufen werden
            // this.PrivateVoid(); // in static-Methoden dürfen wir nur auf static-Member zugreifen
            PrivateStaticVoid();
        }

        public void Void()
        {
            Console.WriteLine("Hallo aus Void");
            PrivateVoid();
        }

        private void PrivateVoid()
        {
            Console.WriteLine("Hallo aus PrivateVoid");
        }

        private static void PrivateStaticVoid()
        {
            Console.WriteLine("Hallo aus PrivateStaticVoid");
        }

    }
}
