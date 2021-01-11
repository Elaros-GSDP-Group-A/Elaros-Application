using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElarosApp.Models
{
    public class AnswerModel
    {
        [Key]
        public int AnswerId { get; set; }
        public int? Answer1 { get; set; }
        public int? Answer2 { get; set; }
        public int? Answer3 { get; set; }
        public int? Answer4 { get; set; }

    }
}
