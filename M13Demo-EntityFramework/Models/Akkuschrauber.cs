using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace M13Demo_EntityFramework.Models
{
    public class Akkuschrauber
    {
        // types
        public enum Typ { T12V, T14V, T18V }

        // props
        [Key]
        public int Id { get; set; }
        [Required]
        public string Modell { get; set; }
        public double Preis { get; set; }
        public Typ AkkuTyp { get; set; }

        // ctor
        public Akkuschrauber(int id, string modell, double preis, Typ akkuTyp)
        {
            Id = id;
            Modell = modell;
            Preis = preis;
            AkkuTyp = akkuTyp;
        }
    }
}
