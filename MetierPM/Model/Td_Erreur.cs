using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MetierPM.Model
{
    public class Td_Erreur
    {
        [Key]
        public int ID { get; set; }
        public  Nullable<System.DateTime> DateErreur { get; set; }
        [MaxLength(300), Required]
        public string DescriptionErreur { get; set; }
        [MaxLength(300), Required]
        public string TitreErreur { get; set; }
    }
}