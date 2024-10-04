using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Shared.Entities
{
    internal class Assessment
    {
        [Display(Name = ("Codigo evaluacion"))]
        [MaxLength(4, ErrorMessage = "El {0} puede tener solo 4 caracteres")]
        [Required(ErrorMessage = "Es obligatorio")]
        public int Id { get; set; }
        public int Score { get; set; }
        public string Feedback { get; set; }
    }
}
