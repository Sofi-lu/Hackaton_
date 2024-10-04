using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Shared.Entities
{
    public class Participant
    {

        [Display(Name = ("Identificacion del participante"))]
        [MaxLength(10, ErrorMessage = "El {0} puede tener solo 10 caracteres")]
        [Required(ErrorMessage = "Es obligatorio")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string role { get; set; }
    }
}
