using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M08GenericDataStructures
{
    class MyList
    {
        internal static List<DateTime> ZeigeListe()
        {
            List<DateTime> dateTimes = new List<DateTime>();
            dateTimes.Add(DateTime.Now);
            dateTimes.Add(DateTime.UtcNow);
            dateTimes.Add(DateTime.MaxValue);
            dateTimes.Add(DateTime.MinValue);
            return dateTimes;
        }

        internal static int LöscheEinElementAmIndex(List<DateTime> liste, int index)
        {
            if (index > liste.Count-1 || index < 0)
            {
                throw new IndexOutOfRangeException("Index liegt außerhalb vom möglichen Bereich");
            }
            else
            {
                liste.RemoveAt(index);
            }
            return liste.Count;
        }

        internal static int LöscheEinElement<T>(List<T> liste, T el)
        {
            if (liste.Contains<T>(el))
                liste.Remove(el);
            else
                throw new ItemDoesNotExist("Das gesuchte Element wurde nicht gefunden");
            return liste.Count;
        }
    }
}
