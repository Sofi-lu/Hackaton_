using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Shared.Entities
{
    public class Hackaton
    {
        [Display(Name = ("Codigo de la edicion de la hackaton"))]
        [MaxLength(4, ErrorMessage = "El {0} solo puede tener 4 caracteres")]
        [Required(ErrorMessage = "Es obligatorio")]
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Name { get; set; }
        public string topic { get; set; }
        public string organizer { get; set; }
    }
}
