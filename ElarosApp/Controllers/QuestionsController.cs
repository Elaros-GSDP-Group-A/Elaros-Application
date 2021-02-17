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
            _viewModel.PatientModel = _context.Patients.FirstOrDefault(p => p.ReferalCode == patientName);
            AnswerModel ans = new AnswerModel();
            _viewModel.AnswerModel = ans;
        }

        [HttpGet]
        public IActionResult Index(PatientModel P)
        {
            var patient = _context.Patients.FirstOrDefault(p => p.ReferalCode == P.ReferalCode);
            patientName = patient.ReferalCode;

            if (patient.FinishedQuestionniare == true)
                return View("QuestionnaireFinished", patient);

            MakeRelationships(patient);

            _viewModel.PatientModel = patient;
            return View("Index", _viewModel);
        }

        [HttpPost]
        public IActionResult OnPost(string submitButton)
        {
            if (submitButton == "NextQuestion")
               return NextQuestion();

            if (submitButton == "PreviousQuestion")
                return PreviousQuestion();

            if (submitButton == "SubmitQuestionnaire")
                return SubmitQuestionnaire();

            return RedirectToAction("Index", _viewModel);
        }

        private IActionResult SubmitQuestionnaire()
        {
            _viewModel.PatientModel.FinishedQuestionniare = true;
            HttpContext.Response.Cookies.Delete("LongCovidPatientAuthCookie");
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        private IActionResult NextQuestion()
        {

            
            switch (_viewModel.PatientModel.QuestionId)
            {
                case 1:

                    break;
            }


            _viewModel.PatientModel.QuestionId++;
            _context.SaveChanges();
            return RedirectToAction("Index", _viewModel);
        }

        private IActionResult PreviousQuestion()
        {
            if(_viewModel.PatientModel.QuestionId > 1)
            {
                _viewModel.PatientModel.QuestionId--;
                _context.SaveChanges();
            }

            return RedirectToAction("Index", _viewModel);
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