using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElarosApp.Models
{
    public class Breathlessness
    {
        [Key]
        public int BreathlessnessId { get; set; }
        public string PrecovidAtRest { get; set; }
        public string PostcovidAtRest { get; set; }
  
    }
}
