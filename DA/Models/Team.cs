using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DA.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }
    }
}
