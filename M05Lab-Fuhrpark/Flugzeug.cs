using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05Lab_Fuhrpark
{
    public class Flugzeug : Transportmittel
    {
        public int MaxFlugHöhe { get; set; }
        public Flugzeug(string name, double preis, int maximalGeschwindigkeit, int maximalFlugHöhe) : base(name, preis, maximalGeschwindigkeit)
        {
            MaxFlugHöhe = maximalFlugHöhe;
        }

        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $"MaxFlugHöhe: {MaxFlugHöhe}";
        }
    }
}
