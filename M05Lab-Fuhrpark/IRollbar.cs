using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05Lab_Fuhrpark
{
    interface IRollbar
    {
        int RäderAnzahl { get; set; }

        int GefahreneKm { get; set; }

        void Bewegen(int distanz);
    }
}
