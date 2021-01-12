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
        public OverallHealth OverallHealth { get; set; }
        public Employment Employment { get; set; }


        // Symptoms that a question could potentitally use
        public OpeningQuestion OpeningQuestion { get; set; }
        public int? OpeningQuestionId { get; set; }

        public Activities Activities { get; set; }
        public int? ActivitiesId { get; set; }

        public Anxiety Anxiety { get; set; }
        public int? AnxietyId { get; set; }
        public Breathlessness Breathlessness { get; set; }
        public int? BreathlessnessId { get; set; }
        public Cognition Cognition { get; set; }
        public int? CognitionId { get; set; }

        public Communication Communication { get; set; }
        public int? CommunicationId { get; set; }

        public Consumption Consumption { get; set; }
        public int? ConsumptionId { get; set; }

        public Continence Continence { get; set; }
        public int? ContinenceId { get; set; }

        public Depression Depression { get; set; }
        public int? DepressionId { get; set; }

        public Fatigue Fatigue { get; set; }
        public int? FatigueId { get; set; }

        public Mobility Mobility { get; set; }
        public int? MobilityId { get; set; }

        public Pain Pain { get; set; }
        public int? PainId { get; set; }

        public PersonalCare PersonalCare { get; set; }
        public int? PersonalCareId { get; set; }

        public Ptsd Ptsd { get; set; }
        public int? PtsdId { get; set; }

        public SocialRole SocialRole { get; set; }
        public int? SocialRoleId { get; set; }

        public Voice Voice { get; set; }
        public int? VoiceId { get; set; }
    }
}
