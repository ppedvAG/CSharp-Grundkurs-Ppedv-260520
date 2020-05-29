using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M14Demo_AsyncAwait
{
    class Program
    {

        static async Task Main(string[] args)
        {
            #region Klasse Task
            Console.WriteLine("\n ### Klasse Task ###");
            MyTask.DemonstrateTask();
            #endregion

            #region Frühstück
            Console.WriteLine("\n ### Frühstück ###");
            // Tasks anlegen
            // äquivalent zu Func<string>:
            Task<List<Ei>> eierTask = BrateEierAsync(2);
            Task<List<Speck>> speckTask = BrateSpeckAsync(3);
            Task<List<Brotscheibe>> brotTask = BrotMitButterUndMarmelade(2);


            // Tasks ausführen / Frühstück servieren
            Saft osaft = SchenkeOsaftEin();
            Console.WriteLine("Osaft ist fertig");

            // gestartete Aufgaben zum Ende bringen, Variante 1
            //List<Brotscheibe> brotscheiben = await brotTask;
            //Console.WriteLine("Brot ist fertig geschmiert");
            //List<Ei> eier = await eierTask;
            //Console.WriteLine("Eier sind fertig");
            //List<Speck> speckscheiben = await speckTask;
            //Console.WriteLine("Speck ist fertig");

            // gestartete Aufgaben zum Ende bringen, Variante 2
            await Task.WhenAll(brotTask, eierTask, speckTask);
            Console.WriteLine("Brot ist fertig geschmiert");
            Console.WriteLine("Eier sind fertig");
            Console.WriteLine("Speck ist fertig");

            Kaffee tasse = SchenkeKaffeeEin();
            Console.WriteLine("Kaffee ist fertig");

            Console.WriteLine("Frühstück ist fertig!");

            Console.ReadKey();
        }

        private static async Task<List<Brotscheibe>> BrotMitButterUndMarmelade(int brotscheibenZahl)
        {
            var brotscheiben = await ToasteBrotAsync(brotscheibenZahl);
            SchmiereButterAuf(brotscheiben);
            SchmiereMarmeladeAuf(brotscheiben);
            return brotscheiben;

        }

        private static async Task<List<Brotscheibe>> ToasteBrotAsync(int v)
        {
            Console.WriteLine("Brot wird getoastet");
            List<Brotscheibe> brotscheiben = new List<Brotscheibe>();
            for (int i = 0; i < v; i++)
            {
                brotscheiben.Add(new Brotscheibe());
            }
            return brotscheiben;
        }


        private static void SchmiereMarmeladeAuf(List<Brotscheibe> brotscheiben)
        {
            foreach (var item in brotscheiben)
            {
                Console.WriteLine($"{item} ist mit Marmelade geschmiert");
            }
        }

        private static void SchmiereButterAuf(List<Brotscheibe> brotscheiben)
        {
            foreach (var item in brotscheiben)
            {
                Console.WriteLine($"{item} ist mit Butter geschmiert");
            }
        }

        private static Saft SchenkeOsaftEin()
        {
            Console.WriteLine("OSaft wird eingeschenkt");
            Saft osaft = new Saft();
            return osaft;
        }



        private static async Task<List<Speck>> BrateSpeckAsync(int v)
        {
            Console.WriteLine("Speck wird gebraten");
            List<Speck> speckscheiben = new List<Speck>();
            for (int i = 0; i < v; i++)
            {
                speckscheiben.Add(new Speck());
            }
            return speckscheiben;
        }

        private static async Task<List<Ei>> BrateEierAsync(int v)
        {
            Console.WriteLine("Eier werden gebraten");
            List<Ei> eier = new List<Ei>();
            for (int i = 0; i < v; i++)
            {
                eier.Add(new Ei());
            }
            return eier;
        }

        private static Kaffee SchenkeKaffeeEin()
        {
            Console.WriteLine("Kaffee wird eingeschenkt");
            Kaffee kaffee = new Kaffee();
            return kaffee;
        }

        private class Kaffee
        {
        }

        private class Speck
        {
        }

        private class Ei
        {
        }

        private class Brotscheibe
        {
        }

        private class Saft
        {
        }
        #endregion
    }
}

/*
 * Ü zufälliges Erzeugen von Transportmittel sollte umgebaut werden und asynchron stattfinden
 */
