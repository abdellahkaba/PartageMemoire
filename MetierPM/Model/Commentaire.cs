using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetierPM.Model
{
    public class Commentaire
    {
        [Key]
        public int IdCommentaire { get; set; }

        [MaxLength(3000), Required]
        public string LaDemande { get; set; }

        public string LaReponse { get; set; }

        public int? IdDemandeur { get; set; }

        [ForeignKey("IdDemandeur")]
        public virtual Personne Demandeur { get; set; }

        public DateTime DateCommentaire { get; set; } = DateTime.Now;

        public DateTime DateResponse { get; set; }

        public int? IdRepondeur { get; set; }

        [ForeignKey("IdRepondeur")]
        public virtual Expert Repondeur { get; set; }
    }
}