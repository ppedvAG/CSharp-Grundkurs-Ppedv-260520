using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M08GenericDataStructures
{
    class M8GenStructures
    {
        public static int NeueLänge { get; set; }
        static void Main(string[] args)
        {
            #region Using Lists
            Console.WriteLine("\n ### Using Lists ###");
            List<DateTime> listeVonDateTimes = MyList.ZeigeListe();
            int i = 0;
            foreach (var item in listeVonDateTimes)
            {
                Console.WriteLine($"listeVonDateTimes[{i}] : {item}");
                ++i;
            }
            Console.WriteLine($"listeVonDateTimes.Count: {listeVonDateTimes.Count}");
            int nL = 0;
            try
            {
                //NeueLänge = MyList.LöscheEinElementAmIndex(listeVonDateTimes, 4);
                nL = MyList.LöscheEinElementAmIndex(listeVonDateTimes, 2);
            }
            catch (IndexOutOfRangeException e)
            {
                string message = e.Message;
                Console.WriteLine(message);
            }
            catch (Exception e)
            {
                string message = e.Message;
                Console.WriteLine(message);                
            }            
            finally
            {
                //Console.WriteLine($"NeueLänge: {NeueLänge}");
                Console.WriteLine($"neue Länge: {nL}");
            }

            try
            {
                nL = MyList.LöscheEinElement(listeVonDateTimes, DateTime.UtcNow);
            }
            catch (ItemDoesNotExist e)
            {
                Console.WriteLine(e.GiveMessageAndSource());
            }
            catch (Exception e)
            {
                string message = e.Message;
                Console.WriteLine(message);
            }
            finally
            {                
                Console.WriteLine($"neue Länge: {nL}");
            }
            #endregion

            Console.ReadKey();
        }
    }
}
