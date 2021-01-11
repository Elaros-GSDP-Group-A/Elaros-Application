using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElarosApp.Models
{
    public class Cognition
    {
        [Key]
        public int CognitionId { get; set; }
        public bool? DifficultyConcentrating { get; set; }
        public bool? ShortTermMemoryEffected { get; set; }
        public string Severity { get; set; }
    }
}
