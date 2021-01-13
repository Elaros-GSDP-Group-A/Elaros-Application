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
        private PatientModel patient;
        public static string PatientName;

        public QuestionsController(DataContext context)
        {
            _context = context;
            patient = _context.Patients.FirstOrDefault(p => p.ReferalCode == PatientName);
        }

        [HttpGet]
        public IActionResult Index(PatientModel tmpPatient)
        {
            var tmptmpPatient = _context.Patients.FirstOrDefault(p => p.ReferalCode == tmpPatient.ReferalCode);
            PatientName = tmptmpPatient.ReferalCode;

            MakeRelationships(tmptmpPatient);
            return View("Index", tmptmpPatient);
        }

        [HttpPost]
        public IActionResult OnPost(string submitButton)
        {
            if (submitButton == "NextQuestion")
               return NextQuestion();

            if (submitButton == "PreviousQuestion")
                return PreviousQuestion();

            return RedirectToAction("Index", patient);
        }

        private IActionResult NextQuestion()
        {
            patient.QuestionId++;
            _context.SaveChanges();
            return RedirectToAction("Index", patient);
        }

        private IActionResult PreviousQuestion()
        {
            if(patient.QuestionId > 1)
            {
                patient.QuestionId--;
                _context.SaveChanges();
            }

            return RedirectToAction("Index", patient);
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