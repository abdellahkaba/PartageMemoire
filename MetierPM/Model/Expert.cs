using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierPM.Model
{
    public class Expert: Personne
    {
        [Required, MaxLength(80)]

        public string Specialiste { get; set; }
    }
}