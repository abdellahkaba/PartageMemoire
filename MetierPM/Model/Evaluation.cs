using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierPM.Model
{
    public class Evaluation
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "*")]
        public int Note { get; set; }

        [Required(ErrorMessage = "*")]
        public string Commentaire { get; set; }

        [Required(ErrorMessage = "*")]
        public DateTime Date { get; set; }

        [ForeignKey("MembreDeJury")]
        public int MembreDeJuryId { get; set; }

        public virtual MembreDeJury MembreDeJury { get; set; }

        [ForeignKey("Memoire")]
        public int MemoireId { get; set; }

        public virtual Memoire Memoire { get; set; }
    }
}