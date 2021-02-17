using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElarosApp.Models
{
    public class Employment { 
        [Key]
        public int ActivitiesId { get; set; }
        public string Occupation { get; set; }
        public string EmploymentBeforeLockdown { get; set; }
        public string EmploymentPrecovid { get; set; }
        public string EmploymentNow { get; set; }
        public string FamilyOrCarerAdditions { get; set; }
        public string UnmentionedProblemsPostCovid { get; set; }
        public string OtherClinicalNotes { get; set; }
    }
}
