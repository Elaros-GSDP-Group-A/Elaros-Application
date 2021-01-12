using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElarosApp.Models
{
    public class Anxiety { 
        [Key]
        public int AnxietyId { get; set; }
        public string Precovid { get; set; }
        public string Postcovid { get; set; }
    }
}
