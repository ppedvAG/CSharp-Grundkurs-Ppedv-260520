using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05Lab_Fuhrpark
{
    public class Schiff : Transportmittel
    {
        public enum SchiffsTreibstoff
        {
            Diesel,
            Dampf,
            Wind,
            Muskelkraft
        }
        public SchiffsTreibstoff Treibstoff { get; set; }
        public Schiff(string name, double preis, int maximalGeschwindigkeit, SchiffsTreibstoff treibstoff) : base(name, preis, maximalGeschwindigkeit)
        {
            Treibstoff = treibstoff;
        }

        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $"Treibstoff: {Treibstoff}";
        }

    }
}
