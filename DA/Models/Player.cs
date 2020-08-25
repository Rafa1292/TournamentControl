using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DA.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }

        [Required]
        [MaxLength(8,ErrorMessage = "Maximo 8 caracteres")]
        public string Name { get; set; }

        [Required]
        [MaxLength(8, ErrorMessage = "Maximo 8 caracteres")]
        public string Alias { get; set; }
    }
}
