using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Comm.ViewModels
{
    public class PlayerVM
    {
        
        public int PlayerId { get; set; }

        [Required]
        [MaxLength(8,ErrorMessage ="Maximo 8 caracteres")]
        public string Name { get; set; }

        [Required]
        [MaxLength(8, ErrorMessage = "Maximo 8 caracteres")]
        public string Alias { get; set; }

    }
}
