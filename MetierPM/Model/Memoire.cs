using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetierPM.Model
{
    public class Memoire
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "*")]
        public string Titre { get; set; }

        [Required(ErrorMessage = "*")]
        public string Resume { get; set; }

        [Required(ErrorMessage = "*")]
        public DateTime DateDeSoumission { get; set; }

        [Required(ErrorMessage = "*")]
        public string Statut { get; set; }

        [ForeignKey("Etudiant")]
        public int EtudiantId { get; set; }

        public virtual Etudiant Etudiant { get; set; }
    }
}