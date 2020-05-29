using M05Lab_Fuhrpark;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace M05Lab_FuhrparkKonsument
{
    class FParkKonsument
    {
        public enum Fahrzeugtypen { PKW = 0, Schiff = 1, Flugzeug = 2 }

        static void Main(string[] args)
        {
            #region Klassen & static
            Console.WriteLine("\n ### Klassen & statische Methoden ###");
            Class1 class1 = new Class1();
            class1.Void();
            Class1.StaticVoid();
            #endregion

            #region Polymorphismus
            Console.WriteLine("\n ### Fahrrad & Polymorphismus ###");
            Transportmittel fahrrad1 = new Fahrrad("Nextbike", 400.00, 50, 2, 0);
            Fahrrad fahrrad2 = new Fahrrad("Lidlbike", 300.00, 45, 2, 0);

            Console.WriteLine("\n # Overrides #");
            Console.WriteLine(fahrrad1.BeschreibeMich());
            Console.WriteLine(fahrrad2.BeschreibeMich());

            Console.WriteLine("\n # Overloads #");
            fahrrad1.Beschleunigen(5);
            fahrrad2.Beschleunigen(5);
            #endregion

            #region Interfaces
            Console.WriteLine("\n # Interfaces & Klassenverschachtelung #");
            bool kannBeladenWerden;
            kannBeladenWerden = FahrzeugBeladen(new Schiff("Marina", 200000.00, 300, Schiff.SchiffsTreibstoff.Diesel), new PKW("BMW", 20000.00, 250, 5, 4, 2000));
            Console.WriteLine($"Können Schiffe PKWs transportieren?: {kannBeladenWerden}");
            kannBeladenWerden = FahrzeugBeladen(new Fahrrad("Fordbike", 5000.00, 60, 2, 4444), new PKW("BMW", 20000.00, 250, 5, 4, 2000));
            Console.WriteLine($"Können Fahrräder PKWs transportieren?: {kannBeladenWerden}");
            #endregion

            #region Generics
            Console.WriteLine("\n ### Generische Datenstrukturen ###");
            Queue<Transportmittel> FahrzeugSchlange = new Queue<Transportmittel>();
            Stack<Transportmittel> FahrzeugStack = new Stack<Transportmittel>();
            Dictionary<Transportmittel, Transportmittel> FahrzeugDictionary = new Dictionary<Transportmittel, Transportmittel>();

            Random random = new Random();

            //FahrzeugSchlange und Stack mit 10 zufällig erzeugten Fahrzeugtypen befüllen
            for (int i = 0; i < 10; i++)
            {
                Transportmittel neuesFahrzeug = null;

                switch ((Fahrzeugtypen)random.Next(3))
                {
                    case Fahrzeugtypen.Flugzeug: neuesFahrzeug = new Flugzeug("Boing 474", 10000000, 800, 200, 6, 0); break;
                    case Fahrzeugtypen.PKW: neuesFahrzeug = new PKW("Opel Astra", 20000, 190, 4, 4, 0); break;
                    case Fahrzeugtypen.Schiff: neuesFahrzeug = new Schiff("Titanik", 100000000, 200, Schiff.SchiffsTreibstoff.Dampf); break;
                    default: Console.WriteLine("Ungültiger Flugzeugtyp!"); break;
                }

                if (neuesFahrzeug != null)
                {
                    FahrzeugSchlange.Enqueue(neuesFahrzeug);
                    FahrzeugStack.Push(neuesFahrzeug);
                }

            }

            //Namen der FahrzeugSchlangen-Elemente ausgeben
            foreach (var item in FahrzeugSchlange)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");
            //Namen der FahrzeugStack-Elemente ausgeben
            foreach (var item in FahrzeugStack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");

            for (int i = 0; i < 10; i++)
            {
                Transportmittel newElementFromQueue = FahrzeugSchlange.Dequeue();
                Transportmittel newElementFromStack = FahrzeugStack.Pop();
                if (FahrzeugBeladen(newElementFromQueue, newElementFromStack))
                {
                    FahrzeugDictionary.Add(newElementFromQueue, newElementFromStack);
                }
            }

            Console.WriteLine("----------------");

            foreach (var item in FahrzeugDictionary)
            {
                Console.WriteLine($"Beladbares Objekt {item.Key} hat {item.Value} beladen.");
            }

            #endregion




            Console.ReadKey();
        }

        public static bool FahrzeugBeladen(Transportmittel aufnehmendesFahrzeug, Transportmittel zuBeladendesObject)
        {
            if (aufnehmendesFahrzeug is IKannAndereTransportieren)
            {
                if (!(aufnehmendesFahrzeug as IKannAndereTransportieren).Belade(zuBeladendesObject))
                {
                    Console.WriteLine($"{zuBeladendesObject} kann nicht beladen werden!");
                    return false;
                }
                return true;
            }
            else
            {
                Console.WriteLine($"{aufnehmendesFahrzeug} erfüllt das Interface IBeladbar nicht!");
                return false;
            }
        }
    }
}
