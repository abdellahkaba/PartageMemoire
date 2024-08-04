using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierPM.Model
{
    public class Etudiant : Personne
    {
        [Required(ErrorMessage = "*")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*")]
        public string NumeroEtudiant { get; set; }

        [Required(ErrorMessage = "*")]
        public DateTime DateDeNaissance { get; set; }

        [Required(ErrorMessage = "*")]
        public string ProgrammeEtudes { get; set; }
    }
}