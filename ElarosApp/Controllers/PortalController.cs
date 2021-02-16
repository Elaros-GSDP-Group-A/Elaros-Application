using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElarosApp.Models.Clinician;
using Microsoft.AspNetCore.Mvc;
using ElarosApp.Data;

namespace ElarosApp.Controllers
{
    public class PortalController : Controller
    {

        private readonly DataContext _context;

        public PortalController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index(LoginFormModel Clinician)
        {
            return View("../Clinician/Portal", Clinician);
        }

        [HttpPost]
        public IActionResult Index(string TextBoxRefCode)
        {
            _context.Patients.Add(new Models.PatientModel { ReferalCode = TextBoxRefCode, FinishedQuestionniare = false, QuestionId = 1 });
            _context.SaveChanges();
            return View("../Clinician/Portal");
        }
    }
}