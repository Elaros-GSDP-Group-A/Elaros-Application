using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElarosApp.Models
{
    public class Consumption
    {
        [Key]
        public int ConsumptionId { get; set; }
        public bool? DifficultySwallowing { get; set; }
        public bool? WeightlossConcern { get; set; }
        public string Severity { get; set; }
        
    }
}
