using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElarosApp.Models
{
    public class Voice
    {
        [Key]
        public int VoiceId { get; set; }
        public bool? SoreThroat { get; set; }
        public bool? VoiceChange { get; set; }
        public bool? NoiseyBreathing { get; set; }
        public string Severity { get; set; }
    }
}
