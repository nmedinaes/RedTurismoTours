﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedTurismoTours.Models
{
    public class TipoId
    {
        [Key]
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripción { get; set; }

    }
}
