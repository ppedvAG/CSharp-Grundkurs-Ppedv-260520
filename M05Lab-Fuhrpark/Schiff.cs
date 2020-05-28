using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05Lab_Fuhrpark
{
    public class Schiff : Transportmittel, IKannAndereTransportieren
    {
        public enum SchiffsTreibstoff
        {
            Diesel,
            Dampf,
            Wind,
            Muskelkraft
        }
        public SchiffsTreibstoff Treibstoff { get; set; }
        public List<Transportmittel> AktLadung { get; set; }
        public int MaxLadung { get; set; }

        public Schiff(string name, double preis, int maximalGeschwindigkeit, SchiffsTreibstoff treibstoff) : base(name, preis, maximalGeschwindigkeit)
        {
            Treibstoff = treibstoff;
            AktLadung = new List<Transportmittel>();
        }

        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $@"
Treibstoff: {Treibstoff},
AktLadung: {AktLadung},
MaxLadung: {MaxLadung}";
        }

        public bool Belade(Transportmittel transport)
        {
            AktLadung.Add(transport);
            return true;
        }

        public bool Entlade()
        {
            AktLadung.Clear();
            return false;
        }
    }
}
