using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElarosApp.Models
{
    public class AnswerModel
    {
        public List<bool?> CheckboxAnswers { get; set; }
        public List<string> NumberAnswers { get; set; }
        public List<string> TextboxAnswers { get; set; }
    }
}
