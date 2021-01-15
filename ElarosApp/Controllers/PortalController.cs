using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElarosApp.Models.Clinician;
using Microsoft.AspNetCore.Mvc;

namespace ElarosApp.Controllers
{
    public class PortalController : Controller
    {
        public IActionResult Index(LoginFormModel Clinician)
        {
            return View("../Clinician/Portal", Clinician);
        }
    }
}