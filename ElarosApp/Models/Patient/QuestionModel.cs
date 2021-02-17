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

        // The actual question context

        public string QuestionContent { get; set; }
        public ICollection<OverallHealth> OverallHealth { get; set; }
      
        public int? OverallHealthId{ get; set; }


        public ICollection<Employment> Employment { get; set; }
        public int? EmploymentId { get; set; }

        // Symptoms that a question could potentitally use
        public ICollection<OpeningQuestion> OpeningQuestion { get; set; }
        public int? OpeningQuestionId { get; set; }

        public ICollection<Activities> Activities { get; set; }
        public int? ActivitiesId { get; set; }

        public ICollection<Anxiety> Anxiety { get; set; }
        public int? AnxietyId { get; set; }

        public ICollection<Breathlessness> Breathlessness { get; set; }
        public int? BreathlessnessId { get; set; }

        public ICollection<Cognition> Cognition { get; set; }
        public int? CognitionId { get; set; }

        public ICollection<Communication> Communication { get; set; }
        public int? CommunicationId { get; set; }

        public ICollection<Consumption> Consumption { get; set; }
        public int? ConsumptionId { get; set; }

        public ICollection<Continence> Continence { get; set; }
        public int? ContinenceId { get; set; }

        public ICollection<Depression> Depression { get; set; }
        public int? DepressionId { get; set; }

        public ICollection<Fatigue> Fatigue { get; set; }
        public int? FatigueId { get; set; }

        public ICollection<Mobility> Mobility { get; set; }
        public int? MobilityId { get; set; }

        public ICollection<Pain> Pain { get; set; }
        public int? PainId { get; set; }

        public ICollection<PersonalCare> PersonalCare { get; set; }
        public int? PersonalCareId { get; set; }

        public ICollection<Ptsd> Ptsd { get; set; }
        public int? PtsdId { get; set; }

        public ICollection<SocialRole> SocialRole { get; set; }
        public int? SocialRoleId { get; set; }

        public ICollection<Voice> Voice { get; set; }
        public int? VoiceId { get; set; }
    }
}
