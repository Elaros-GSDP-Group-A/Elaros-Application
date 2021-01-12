using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElarosApp.Models
{
    public class Communication { 
        [Key]
        public int CommunicationId { get; set; }
        public bool? DifficultyCommunicating { get; set; }
        public string Severity { get; set; }
    }
}
