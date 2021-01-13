using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ElarosApp.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using ElarosApp.Data;
using Microsoft.EntityFrameworkCore;

namespace ElarosApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        private string _referalCode;
        public HomeController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> OnPost(string referalCode)
        {

            _referalCode = referalCode;
            var currentPatient = _context.Patients.FirstOrDefault(patient => patient.ReferalCode == referalCode);
            if (currentPatient == null)
            {
                return Index();
            }
            //MakeRelationships(currentPatient);

            if (currentPatient != null)
            {
                // find ref code from dbctx list of patients and assign to patientModel


                // creating cookie
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, currentPatient.ReferalCode),
                };

                var identity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                var props = new AuthenticationProperties { IsPersistent = true, ExpiresUtc = DateTime.UtcNow.AddMinutes(30)  }; // cookie expires after 30 minutes
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    principal,
                    props);

                //Response.Cookies.Append("currentQuestion", patientModel.CurrentQuestion.ToString());

               
                return RedirectToAction("Index", "Questions", currentPatient);
            }
            return Index();
        }


        [HttpGet]
        public ActionResult Index()
        {
            if (Request.Cookies.Keys.Contains("LongCovidPatientAuthCookie"))
            {
                PatientModel currentPatient = _context.Patients.FirstOrDefault(p => p.ReferalCode == User.Identity.Name);
                //MakeRelationships(currentPatient);
                return RedirectToAction("Index", "Questions", currentPatient);
            }

            return View("Login", _referalCode);
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

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index");
        }


    }
}
