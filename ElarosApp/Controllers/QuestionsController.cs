using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElarosApp.Data;
using ElarosApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ElarosApp.Controllers
{
    public class QuestionsController : Controller
    {
        private readonly DataContext _context;
        private static ViewModel _viewModel;
        private static string patientName;

        public QuestionsController(DataContext context)
        {
            _context = context;

            PatientModel pm = _context.Patients.FirstOrDefault(p => p.ReferalCode == patientName);
            AnswerModel ans = new AnswerModel();

            _viewModel = new ViewModel() { AnswerModel = ans, PatientModel = pm };
        }

        [HttpGet]
        public IActionResult Index(PatientModel P)
        {
            _viewModel.PatientModel = _context.Patients.FirstOrDefault(p => p.ReferalCode == P.ReferalCode);
            patientName = _viewModel.PatientModel.ReferalCode;

            if (_viewModel.PatientModel.FinishedQuestionniare == true)
                return View("QuestionnaireFinished", _viewModel.PatientModel);

            MakeRelationships(_viewModel.PatientModel);

            return View("Index", _viewModel);
        }

        [HttpPost]
        public IActionResult OnPost(string submitButton, ViewModel answers)
        {
            if (submitButton == "NextQuestion")
               return NextQuestion(answers);

            if (submitButton == "PreviousQuestion")
                return PreviousQuestion();

            if (submitButton == "SubmitQuestionnaire")
                return SubmitQuestionnaire(answers.AnswerModel);

            return RedirectToAction("Index", _viewModel);
        }

        private IActionResult SubmitQuestionnaire(AnswerModel answers)
        {
            QuestionModel currentQuestion = _context.Questions.FirstOrDefault(q => q.QuestionId == _viewModel.PatientModel.QuestionId);
            if (currentQuestion.Employment == null)
            {
                currentQuestion.Employment = new List<Employment>();
            }

            currentQuestion.Employment.Add(new Employment
            {
                Occupation = answers.TextboxAnswers[0],
                EmploymentBeforeLockdown = answers.TextboxAnswers[1],
                EmploymentPrecovid = answers.TextboxAnswers[2],
                EmploymentNow = answers.TextboxAnswers[3],
                FamilyOrCarerAdditions = answers.TextboxAnswers[4],
                UnmentionedProblemsPostCovid = answers.TextboxAnswers[5],
                OtherClinicalNotes = answers.TextboxAnswers[6],
            });
 
            _viewModel.PatientModel.FinishedQuestionniare = true;
            HttpContext.Response.Cookies.Delete("LongCovidPatientAuthCookie");
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        private IActionResult NextQuestion(ViewModel vm)
        {
            QuestionModel currentQuestion = _context.Questions.FirstOrDefault(q => q.QuestionId == _viewModel.PatientModel.QuestionId);
            AnswerModel answers = vm.AnswerModel;

            // Check to see if the relevent data from AnswerModel is false and set answers.IsDataNull appropriately.
         
                switch (_viewModel.PatientModel.QuestionId)
                {

                    case 1:
                        if (currentQuestion.OpeningQuestion == null)
                        {
                            currentQuestion.OpeningQuestion = new List<OpeningQuestion>();
                        }

                        currentQuestion.OpeningQuestion.Add(new OpeningQuestion
                        {
                            MedicalProblems = answers.CheckboxAnswers[0],
                            MedicalProblemsDetails = answers.TextboxAnswers[0],
                            HealthServicesUsed = answers.CheckboxAnswers[1],
                            HealthServicesDetails = answers.TextboxAnswers[1]
                        });
                        break;

                    case 2:
                        if (currentQuestion.Breathlessness == null)
                        {
                            currentQuestion.Breathlessness = new List<Breathlessness>();
                        }

                        currentQuestion.Breathlessness.Add(new Breathlessness
                        {
                            PrecovidAtRest = answers.NumberAnswers[0],
                            PrecovidDressing = answers.NumberAnswers[1],
                            PrecovidWalkingUpStairs = answers.NumberAnswers[2],

                            PostcovidAtRest = answers.NumberAnswers[3],
                            PostcovidDressing = answers.NumberAnswers[4],
                            PostcovidWalkingUpStairs = answers.NumberAnswers[5],
                        });
                        break;
                    case 3:
                        if (currentQuestion.Voice == null)
                        {
                            currentQuestion.Voice = new List<Voice>();
                        }

                        currentQuestion.Voice.Add(new Voice
                        {
                            SoreThroat = answers.CheckboxAnswers[0],
                            VoiceChange = answers.CheckboxAnswers[1],
                            NoiseyBreathing = answers.CheckboxAnswers[2],
                            Severity = answers.NumberAnswers[0]
                        });
                        break;

                    case 4:
                        if (currentQuestion.Consumption == null)
                        {
                            currentQuestion.Consumption = new List<Consumption>();
                        }

                        currentQuestion.Consumption.Add(new Consumption
                        {
                            DifficultySwallowing = answers.CheckboxAnswers[0],
                            WeightlossConcern = answers.CheckboxAnswers[1],
                            Severity = answers.NumberAnswers[0]
                        });
                        break;

                    case 5:
                        if (currentQuestion.Fatigue == null)
                        {
                            currentQuestion.Fatigue = new List<Fatigue>();
                        }

                        currentQuestion.Fatigue.Add(new Fatigue
                        {
                            Precovid = answers.NumberAnswers[0],
                            Postcovid = answers.NumberAnswers[1]
                        });
                        break;

                    case 6:
                        if (currentQuestion.Continence == null)
                        {
                            currentQuestion.Continence = new List<Continence>();
                        }

                        currentQuestion.Continence.Add(new Continence
                        {
                            BowelProblems = answers.CheckboxAnswers[0],
                            BladderProblems = answers.CheckboxAnswers[1],
                            Severity = answers.NumberAnswers[0]
                        });
                        break;

                    case 7:
                        if (currentQuestion.Pain == null)
                        {
                            currentQuestion.Pain = new List<Pain>();
                        }

                        currentQuestion.Pain.Add(new Pain
                        {
                            NewPain = answers.CheckboxAnswers[0],
                            Precovid = answers.NumberAnswers[0],
                            Postcovid = answers.NumberAnswers[1],
                        });
                        break;

                    case 8:
                        if (currentQuestion.Cognition == null)
                        {
                            currentQuestion.Cognition = new List<Cognition>();
                        }

                        currentQuestion.Cognition.Add(new Cognition
                        {
                            DifficultyConcentrating = answers.CheckboxAnswers[0],
                            ShortTermMemoryEffected = answers.CheckboxAnswers[1],
                            Severity = answers.NumberAnswers[0]
                        });
                        break;

                    case 9:
                        if (currentQuestion.Anxiety == null)
                        {
                            currentQuestion.Anxiety = new List<Anxiety>();
                        }

                        currentQuestion.Anxiety.Add(new Anxiety
                        {
                            Precovid = answers.NumberAnswers[0],
                            Postcovid = answers.NumberAnswers[1]
                        });
                        break;

                    case 10:
                        if (currentQuestion.Depression == null)
                        {
                            currentQuestion.Depression = new List<Depression>();
                        }

                        currentQuestion.Depression.Add(new Depression
                        {
                            Precovid = answers.NumberAnswers[0],
                            Postcovid = answers.NumberAnswers[1]
                        });
                        break;

                    case 11:
                        if (currentQuestion.Ptsd == null)
                        {
                            currentQuestion.Ptsd = new List<Ptsd>();
                        }

                        currentQuestion.Ptsd.Add(new Ptsd
                        {
                            UnwantedMemoriesWhilstAwake = answers.CheckboxAnswers[0],
                            UnpleasantDreams = answers.CheckboxAnswers[1],
                            ThoughtOrFeelingAvoidance = answers.CheckboxAnswers[2],
                            SelfharmThoughts = answers.CheckboxAnswers[3],
                            Severity = answers.NumberAnswers[0]
                        });
                        break;

                    case 12:
                        if (currentQuestion.Communication == null)
                        {
                            currentQuestion.Communication = new List<Communication>();
                        }

                        currentQuestion.Communication.Add(new Communication
                        {
                            DifficultyCommunicating = answers.CheckboxAnswers[0],
                            Severity = answers.NumberAnswers[0]
                        });
                        break;

                    case 13:
                        if (currentQuestion.Mobility == null)
                        {
                            currentQuestion.Mobility = new List<Mobility>();
                        }

                        currentQuestion.Mobility.Add(new Mobility
                        {
                            Precovid = answers.NumberAnswers[0],
                            Postcovid = answers.NumberAnswers[1]
                        });
                        break;
                    case 14:
                        if (currentQuestion.PersonalCare == null)
                        {
                            currentQuestion.PersonalCare = new List<PersonalCare>();
                        }

                        currentQuestion.PersonalCare.Add(new PersonalCare
                        {
                            Precovid = answers.NumberAnswers[0],
                            Postcovid = answers.NumberAnswers[1]
                        });
                        break;
                    case 15:
                        if (currentQuestion.Activities == null)
                        {
                            currentQuestion.Activities = new List<Activities>();
                        }

                        currentQuestion.Activities.Add(new Activities
                        {
                            Precovid = answers.NumberAnswers[0],
                            Postcovid = answers.NumberAnswers[1]
                        });
                        break;
                    case 16:
                        if (currentQuestion.SocialRole == null)
                        {
                            currentQuestion.SocialRole = new List<SocialRole>();
                        }

                        currentQuestion.SocialRole.Add(new SocialRole
                        {
                            Precovid = answers.NumberAnswers[0],
                            Postcovid = answers.NumberAnswers[1]
                        });
                        break;
                    case 17:
                        if (currentQuestion.OverallHealth == null)
                        {
                            currentQuestion.OverallHealth = new List<OverallHealth>();
                        }

                        currentQuestion.OverallHealth.Add(new OverallHealth
                        {
                            Precovid = answers.NumberAnswers[0],
                            Postcovid = answers.NumberAnswers[1]
                        });
                        break;
                }
                vm.isDataNull = false;
                _viewModel.PatientModel.QuestionId++;
                _context.SaveChanges();
            
            return RedirectToAction("Index", _viewModel.PatientModel);
        }

        private IActionResult PreviousQuestion()
        {
            if(_viewModel.PatientModel.QuestionId > 1)
            {
                _viewModel.PatientModel.QuestionId--;
                _context.SaveChanges();
            }

            return RedirectToAction("Index", _viewModel.PatientModel);
        }

        public void MakeRelationships(PatientModel currentPatient)
        {
            _context.Entry(currentPatient).Reference(q => q.Question).Load();
            //_context.Entry(currentPatient.Question).Reference(s => s.Activities).Load();
            //_context.Entry(currentPatient.Question).Reference(s => s.Anxiety).Load();
            //_context.Entry(currentPatient.Question).Reference(s => s.Breathlessness).Load();
            //_context.Entry(currentPatient.Question).Reference(s => s.Cognition).Load();
            //_context.Entry(currentPatient.Question).Reference(s => s.Communication).Load();
            //_context.Entry(currentPatient.Question).Reference(s => s.Consumption).Load();
            //_context.Entry(currentPatient.Question).Reference(s => s.Continence).Load();
            //_context.Entry(currentPatient.Question).Reference(s => s.Depression).Load();
            //_context.Entry(currentPatient.Question).Reference(s => s.Fatigue).Load();
            //_context.Entry(currentPatient.Question).Reference(s => s.Mobility).Load();
            //_context.Entry(currentPatient.Question).Reference(s => s.Pain).Load();
            //_context.Entry(currentPatient.Question).Reference(s => s.PersonalCare).Load();
            //_context.Entry(currentPatient.Question).Reference(s => s.Ptsd).Load();
            //_context.Entry(currentPatient.Question).Reference(s => s.SocialRole).Load();
            //_context.Entry(currentPatient.Question).Reference(s => s.Voice).Load();
        }
    }
}