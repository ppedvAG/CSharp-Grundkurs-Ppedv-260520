using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05Lab_Fuhrpark
{
    public interface IKannAndereTransportieren
    {
        Transportmittel AktLadung { get; set; }
        Transportmittel MaxLadung { get; set; }
        bool Belade(Transportmittel transport);
        bool Entlade();
    }
}
