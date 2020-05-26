using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05Lab_Fuhrpark
{
    public class Transportmittel
    {
        // types
        public enum Zustand { aus, an }
        
        // props
        public string Name { get; set; }
        public int MaximalGeschwindigkeit { get; }
        public double Preis { get; set; }
        public int AktuelleGeschwindigkeit { get; private set; }
        public Zustand FZustand { get; private set; }
        
        // ctor
        public Transportmittel(string name, double preis, int maximalGeschwindigkeit)
        {
            Name = name;
            Preis = preis;
            MaximalGeschwindigkeit = maximalGeschwindigkeit;
            FZustand = Zustand.aus;
            AktuelleGeschwindigkeit = 0;
        }

        // methods
        public int Beschleunigen(int erhöhung)
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
            return AktuelleGeschwindigkeit;
        }
        public void StarteMotor()
        {
            FZustand = Zustand.an;
        }

        public void StoppeMotor()
        {
            FZustand = Zustand.aus;
        }

        public void Parke()
        {
            FZustand = Zustand.aus;
            AktuelleGeschwindigkeit = 0;
        }

        public string BeschreibeMich()
        {
            return $@"
{Name}, ({Preis} Euro)
Maximale Geschwindigkeit: {MaximalGeschwindigkeit} km/h
Zustand: {FZustand}
Aktuelle Geschwindigkeit: {AktuelleGeschwindigkeit}";
        }
    }
}
