using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ElarosApp.Models;

namespace ElarosApp.Controllers
{
    public class HomeController : Controller
    {
        // In memory temporary patient code list 
        private List<string> patientCodeList = new List<string>() { "unggz", "QPbs8", "Tl0vW", "s0lIx", "yXo79" };
        private string _referalCode;
        [HttpPost]
        public ActionResult Index(string referalCode)
        {
            _referalCode = referalCode;
            if (patientCodeList.Contains(referalCode))
            {
                return Content($"Successfully logged in as {referalCode}");
            }
            return Index();
        }

        [HttpGet]
        public ActionResult Index()
        {
            if (ModelState.IsValid)
            {
                return View("StartQuestionnaire", _referalCode);
            }
            return View("StartQuestionnaire");
        }

        
    }
}
