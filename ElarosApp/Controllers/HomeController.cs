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

namespace ElarosApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        private string _referalCode;
        public HomeController(DataContext context)
        {
            _context = context;
            context.Patients.Count();
        }

        [HttpPost]
        public async Task<ActionResult> Index(string referalCode)
        {
            _referalCode = referalCode;
            PatientModel currentPatient = _context.Patients.FirstOrDefault(patient => patient.ReferalCode == referalCode);
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


                return RedirectToPage("/Questions/Index");
            }
            return Index();
        }
        
        [HttpGet]
        public ActionResult Index()
        {
            if (HttpContext.Request.Cookies["LongCovidAuthCookie"] != null)
                return View("../Questions/Index");

            return View("Login", _referalCode);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index");
        }


    }
}
