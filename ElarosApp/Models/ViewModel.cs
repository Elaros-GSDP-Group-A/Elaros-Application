using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElarosApp.Models
{
    public class ViewModel
    {
        public PatientModel PatientModel { get; set; }
        public AnswerModel AnswerModel { get; set; }
        public bool isDataNull { get; set; } = false;
    }
}
