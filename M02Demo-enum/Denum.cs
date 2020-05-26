using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02Demo_enum
{
    class Denum
    {
        enum Pizzagröße { klein=1, mittel, groß, family }
        static void Main(string[] args)
        {
            Pizzagröße pizzagröße1 = Pizzagröße.mittel;
            Pizzagröße pizzagröße2 = (Pizzagröße)3;
            Console.WriteLine($@"
- Ich hab mit eine {pizzagröße1}-Pizza bestellt.
- Und ich hab mit eine {pizzagröße2}-Pizza genommen.");
            Console.ReadKey();
        }
    }
}
