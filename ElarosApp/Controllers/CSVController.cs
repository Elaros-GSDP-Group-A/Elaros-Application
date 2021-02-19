using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElarosApp.Data;
using ElarosApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ElarosApp.Controllers
{
    public class CSVController : Controller
    {
        private readonly DataContext _context;
        
        public CSVController(DataContext ctx)
        {
            _context = ctx;

        }


        

        public IActionResult Index()
        {
            
            return View("../Report/TrialResults");
        }
    }
}