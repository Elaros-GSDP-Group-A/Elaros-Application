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
        public ActionResult Index()
        {
            return View("StartQuestionnaire");
        }
    }
}
