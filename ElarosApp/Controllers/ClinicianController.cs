using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElarosApp.Models.Clinician;
using Microsoft.AspNetCore.Mvc;

namespace ElarosApp.Controllers
{
    public class ClinicianController : Controller
    {

        // temp login details for clinician
        private string email = "clinician@nhs.co.uk";
        private string password = "test";

        public LoginFormModel LoginFormModel;

        // called when page is requested
        [HttpGet]
        public ActionResult Index()
        {
            LoginFormModel = new LoginFormModel();
            return View(LoginFormModel);
        }

        // Called when form is submitted
        [HttpPost]
        public ActionResult Index(LoginFormModel formModel)
        {
            if (formModel.Email == email && formModel.Password == password)
                return View("Portal", formModel);
            return View(formModel);
        }
    }
}