using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElarosApp.Models
{
    public class OpeningQuestion
    {
        public int OpeningQuestionId { get; set; }

        public bool? MedicalProblems { get; set; }

        public string MedicalProblemsDetails { get; set; }

        public bool? HealthServicesUsed { get; set; }

        public string HealthServicesDetails { get; set; }
    }
}
