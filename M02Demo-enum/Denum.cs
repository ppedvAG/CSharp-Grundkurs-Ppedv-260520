using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02Demo_enum
{
    class Denum
    {
        enum Pizzagröße { klein = 1, mittel, groß, family }
        static void Main(string[] args)
        {
            #region Intro
            Console.WriteLine("\n ### Intro ###");
            Pizzagröße pizzagröße1 = Pizzagröße.mittel;
            Pizzagröße pizzagröße2 = (Pizzagröße)3;
            Console.WriteLine($@"
- Ich hab mit eine {pizzagröße1}-Pizza bestellt.
- Und ich hab mit eine {pizzagröße2}-Pizza genommen.");
            #endregion

            #region HasFlag
            Console.WriteLine("\n ### HasFlag ###");
            Demo_HasFlag.BreakfastItems breakfastItems =
                Demo_HasFlag.BreakfastItems.brotscheiben |
                Demo_HasFlag.BreakfastItems.eier |
                Demo_HasFlag.BreakfastItems.kaffee |
                Demo_HasFlag.BreakfastItems.nichts |
                //Demo_HasFlag.BreakfastItems.oSaft |
                Demo_HasFlag.BreakfastItems.speckscheiben;
            // breakfastItems.
            Demo_HasFlag.BreakfastItems rabattItems =
                Demo_HasFlag.BreakfastItems.oSaft |
                Demo_HasFlag.BreakfastItems.brotscheiben; 
            // Fehlt mindestens eines von beiden, kommt bei HasFlag False raus.

            Console.WriteLine($"In der Bestellung sind Produkte mit Rabatt drin: " +
                $"{breakfastItems.HasFlag(rabattItems)}");
            #endregion

            Console.ReadKey();
        }
    }

    class Demo_HasFlag
    {
        // [Flags] public enum BreakfastItems // ohne [Flags] funktioniert auch        
        public enum BreakfastItems
        {
            nichts = 0,
            oSaft = 1,
            brotscheiben = 2,
            eier = 4,
            speckscheiben = 8,
            kaffee = 16
        }
        public static async Task PrepareBreakfast()
        {
            Task<List<Ei>> eierTask = BrateEierAsync(2);
            Task<List<Speck>> speckTask = BrateSpeckAsync(3);
            Task<List<Brotscheibe>> brotTask = BrotMitButterUndMarmelade(2);


            // Tasks ausführen / Frühstück servieren
            Saft osaft = SchenkeOsaftEin();
            Console.WriteLine("Osaft ist fertig");

            // gestartete Aufgaben zum Ende bringen, Variante 1
            List<Brotscheibe> brotscheiben = await brotTask;
            Console.WriteLine("Brot ist fertig geschmiert");
            List<Ei> eier = await eierTask;
            Console.WriteLine("Eier sind fertig");
            List<Speck> speckscheiben = await speckTask;
            Console.WriteLine("Speck ist fertig");

            // gestartete Aufgaben zum Ende bringen, Variante 2
            //await Task.WhenAll(brotTask, eierTask, speckTask);
            //Console.WriteLine("Brot ist fertig geschmiert");
            //Console.WriteLine("Eier sind fertig");
            //Console.WriteLine("Speck ist fertig");

            Kaffee kaffee = SchenkeKaffeeEin();
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
    }
}

