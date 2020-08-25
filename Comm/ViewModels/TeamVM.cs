using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Comm.ViewModels
{
    public class TeamVM
    {
        public int TeamId { get; set; }

        [Required]
        [MaxLength(16, ErrorMessage = "Maximo 16 caracteres")]
        public string Name { get; set; }

        [Required]
        [MaxLength(3, ErrorMessage = "Maximo 3 caracteres")]
        public string Acronym { get; set; }

        public string Image { get; set; }
    }
}
