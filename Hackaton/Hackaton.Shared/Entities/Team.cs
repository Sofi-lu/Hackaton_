using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Shared.Entities
{
    public class Team
    {
        [Display(Name = ("Codigo de equipo"))]
        [MaxLength(4, ErrorMessage = "El {0} puede tener solo 4 caracteres")]
        [Required(ErrorMessage = "Es obligatorio")]
        public int Id { get; set; }
        public string Name { get; set; }
        public int memberCount { get; set; }
        public string experience { get; set; }

    }
}
