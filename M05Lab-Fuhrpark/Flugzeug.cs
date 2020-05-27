using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05Lab_Fuhrpark
{
    public class Flugzeug : Transportmittel, IRollbar, IKannAndereTransportieren
    {
        public int MaxFlugHöhe { get; set; }
        public int RäderAnzahl { get; set; }
        public int GefahreneKm { get; set; }
        public Transportmittel AktLadung { get; set; }
        public Transportmittel MaxLadung { get; set; }

        public Flugzeug(string name, double preis, int maximalGeschwindigkeit, int maximalFlugHöhe, int räderAnzahl, int gefahreneKm) : base(name, preis, maximalGeschwindigkeit)
        {
            MaxFlugHöhe = maximalFlugHöhe;
            RäderAnzahl = räderAnzahl;
            GefahreneKm = gefahreneKm;
        }

        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $"MaxFlugHöhe: {MaxFlugHöhe}";
        }

        public void Bewegen(int distanz)
        {
            GefahreneKm += distanz;
        }

        public bool Belade(Transportmittel transport)
        {
            AktLadung = transport;
            return true;
        }

        public bool Entlade()
        {
            AktLadung = null;
            return false;
        }
    }
}
