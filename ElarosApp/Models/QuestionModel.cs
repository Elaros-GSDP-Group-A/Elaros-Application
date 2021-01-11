using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElarosApp.Models
{
    public class QuestionModel
    {
        [Key]
        public int QuestionId { get; set; }
        public string QuestionContent { get; set; }
        public Breathlessness Breathlessness { get; set; }
        public int BreathlessnessId { get; set; }
        public Coughing Coughing { get; set; }
        public int CoughingId { get; set; }
        public Anxiety Anxiety { get; set; }
        public int AnxietyId { get; set; }



        public void test()
        {

            QuestionModel Question1 = new QuestionModel();


            Question1.Breathlessness.PrecovidAtRest = 1.ToString();
            Question1.Anxiety = null;

         
        }
    }
}
