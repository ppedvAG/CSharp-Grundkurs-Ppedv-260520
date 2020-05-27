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
        static void Main(string[] args)
        {
            Console.WriteLine("\n ### Klassen & statische Methoden ###");
            Class1 class1 = new Class1();
            class1.Void();
            Class1.StaticVoid();

            Console.WriteLine("\n ### Fahrrad & Polymorphismus ###");            
            Transportmittel fahrrad1 = new Fahrrad("Nextbike", 400.00, 50, 2, 0);
            Fahrrad fahrrad2 = new Fahrrad("Lidlbike", 300.00, 45, 2, 0);

            Console.WriteLine("\n # Overrides #");
            Console.WriteLine(fahrrad1.BeschreibeMich());
            Console.WriteLine(fahrrad2.BeschreibeMich());

            Console.WriteLine("\n # Overloads #");
            fahrrad1.Beschleunigen(5);
            fahrrad2.Beschleunigen(5);

            Console.WriteLine("\n # Interfaces & Klassenverschachtelung #");
            bool kannBeladenWerden;
            kannBeladenWerden = FahrzeugBeladen(new Schiff("Marina", 200000.00, 300, Schiff.SchiffsTreibstoff.Diesel), new PKW("BMW", 20000.00, 250, 5, 4, 2000));
            Console.WriteLine($"Können Schiffe PKWs transportieren?: {kannBeladenWerden}");
            kannBeladenWerden = FahrzeugBeladen(new Fahrrad("Fordbike", 5000.00, 60, 2, 4444), new PKW("BMW", 20000.00, 250, 5, 4, 2000));
            Console.WriteLine($"Können Fahrräder PKWs transportieren?: {kannBeladenWerden}");

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
