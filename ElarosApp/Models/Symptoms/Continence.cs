using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElarosApp.Models
{
    public class Continence
    {
        [Key]
        public int ContinenceId { get; set; }
        public bool? BowelProblems { get; set; }
        public bool? BladderProblems { get; set; }
        public string Severity { get; set; }
    }
}
