using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElarosApp.Models
{
    public class Ptsd { 
        [Key]
        public int PtsdId { get; set; }
        public bool? UnwantedMemoriesWhilstAwake { get; set; }
        public bool? UnpleasantDreams { get; set; }
        public bool? ThoughtOrFeelingAvoidance { get; set; }
        public bool? SelfharmThoughts { get; set; }
        public string Severity { get; set; }
    }
}
