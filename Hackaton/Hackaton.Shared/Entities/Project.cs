﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Shared.Entities
{
    public class Project
    {
        [Display(Name = ("Codigo del proyecto"))]
        [MaxLength(4, ErrorMessage = "El {0} puede tener solo 10 caracteres")]
        [Required(ErrorMessage = "Es obligatorio")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string description { get; set; }
        public string state { get; set; }
        public DateTime dueDate { get; set; }
    }
}
