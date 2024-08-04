﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierPM.Model
{
    public class Faculte
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "*")]
        public string Nom { get; set; }
    }
}