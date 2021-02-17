using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElarosApp.Data;
using ElarosApp.Models.Clinician;
using Microsoft.AspNetCore.Mvc;
using ElarosApp.Data;

namespace ElarosApp.Controllers
{
    public class PortalController : Controller
    {
        private readonly DataContext _context;
        private LoginFormModel _clinician;
        public PortalController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Index(LoginFormModel Clinician)
        {
            _clinician = Clinician;
            return View("../Clinician/Portal", Clinician);
        }

        [HttpPost]
        public IActionResult Index(string TextboxRefCode)
        {
            _context.Patients.Add(new Models.PatientModel { ReferalCode = TextboxRefCode, QuestionId = 1, FinishedQuestionniare = false});
            _context.SaveChanges();

            return RedirectToAction("Index", _clinician);
        }
    }
}