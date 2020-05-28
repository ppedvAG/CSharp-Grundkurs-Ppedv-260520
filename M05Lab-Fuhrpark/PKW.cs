using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05Lab_Fuhrpark
{
    public class PKW : Transportmittel, IRollbar, IKannAndereTransportieren
    {
        public int AnzahlTüren { get; set; }
        public int RäderAnzahl { get; set; }
        public int GefahreneKm { get; set; }
        public List<Transportmittel> AktLadung { get; set; }
        public Transportmittel MaxLadung { get; set; }

        public PKW(string name, double preis, int maximalGeschwindigkeit, int anzahlTüren, int räderAnzahl, int gefahreneKm) : base(name, preis, maximalGeschwindigkeit)
        {
            AnzahlTüren = anzahlTüren;
            RäderAnzahl = räderAnzahl;
            GefahreneKm = gefahreneKm;
        }

        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $"AnzahlTüren: {AnzahlTüren}";
        }

        public void Bewegen(int distanz)
        {
            GefahreneKm += distanz;
        }

        public bool Belade(Transportmittel transport)
        {
            AktLadung.Add(transport);
            return true;
        }

        public bool Entlade()
        {
            AktLadung = null;
            return false;
        }
    }
}
