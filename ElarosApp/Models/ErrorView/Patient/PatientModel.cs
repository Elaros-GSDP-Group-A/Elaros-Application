using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ElarosApp.Models
{
    public class PatientModel
    {
        [Key]
        public int PatientId { get; set; }
        public string ReferalCode { get; set; }
        public QuestionModel CurrentQuestion { get; set; }
        public int QuestionId { get; set; }
    }
}
