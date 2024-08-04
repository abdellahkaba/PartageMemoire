using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierPM.Model
{
     public class Soutenance
     {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "*")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "*")]
        public TimeSpan Heure { get; set; }

        [Required(ErrorMessage = "*")]
        public string Lieu { get; set; }

        [ForeignKey("Memoire")]
        public int MemoireId { get; set; }

        public virtual Memoire Memoire { get; set; }

        [ForeignKey("Directeur")]
        public int DirecteurId { get; set; }

        public virtual Directeur Directeur { get; set; }
    }
}