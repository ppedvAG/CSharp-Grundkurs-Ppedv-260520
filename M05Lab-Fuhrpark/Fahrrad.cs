using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05Lab_Fuhrpark
{
    public class Fahrrad : Transportmittel, IRollbar
    {
        // types

        // fields

        // props
        public int RäderAnzahl { get; set; }
        public int GefahreneKm { get; set; }

        // ctor
        public Fahrrad(string name, double preis, int maximalGeschwindigkeit, int räderAnzahl, int gefahreneKm) : base(name, preis, maximalGeschwindigkeit)
        {
            RäderAnzahl = räderAnzahl;
            GefahreneKm = gefahreneKm;
        }
        // methods
        public void Bewegen(int distanz)
        {
            GefahreneKm += distanz;
        }

        public new int Beschleunigen(int erhöhung)
        {
            int möglicheErhöhung = MaximalGeschwindigkeit - AktuelleGeschwindigkeit;
            if (AktuelleGeschwindigkeit < MaximalGeschwindigkeit && FZustand == Zustand.an && erhöhung <= möglicheErhöhung)
            {
                AktuelleGeschwindigkeit += erhöhung;
            }
            else
            {
                AktuelleGeschwindigkeit = MaximalGeschwindigkeit;
            }
            Console.WriteLine("Beschleunigen von Fahrrad");
            return AktuelleGeschwindigkeit;
        }

        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $@"
RäderAnzahl: {RäderAnzahl},
GefahreneKm: {GefahreneKm}";
        }

        // dtor

    }
}
