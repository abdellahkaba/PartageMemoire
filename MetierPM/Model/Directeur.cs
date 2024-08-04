using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierPM.Model
{
    public class Directeur : Personne
    {
        [Required(ErrorMessage = "*")]
        public string Email { get; set; }

        [ForeignKey("Departement")]
        public int DepartementId { get; set; }
        public virtual Departement Departement { get; set; }
    }
}