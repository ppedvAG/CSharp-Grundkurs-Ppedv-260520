using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05Lab_Fuhrpark
{
    public class PKW : Transportmittel
    {
        public int AnzahlTüren { get; set; }
        public PKW(string name, double preis, int maximalGeschwindigkeit, int anzahlTüren) : base(name, preis, maximalGeschwindigkeit)
        {
            AnzahlTüren = anzahlTüren;
        }

        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $"AnzahlTüren: {AnzahlTüren}";
        }
    }
}
