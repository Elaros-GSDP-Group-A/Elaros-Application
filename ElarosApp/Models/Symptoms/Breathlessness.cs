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
        
        // Precovid
        public string PrecovidAtRest { get; set; }
        public string PrecovidDressing { get; set; }
        public string PrecovidWalkingUpStairs { get; set; }

        // Postcovid
        public string PostcovidAtRest { get; set; }
        public string PostcovidDressing { get; set; }
        public string PostcovidWalkingUpStairs { get; set; }
    }
}
