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

namespace ElarosApp.Controllers
{
    public class HomeController : Controller
    {
        // In memory temporary patient code list 
        private List<string> patientCodeList = new List<string>() { "unggz", "QPbs8", "Tl0vW", "s0lIx", "yXo79" };
        private string _referalCode;
        [HttpPost]
        public async Task<ActionResult> Index(string referalCode)
        {
            _referalCode = referalCode;
            if (patientCodeList.Contains(referalCode))
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, referalCode)
                };

                var identity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                var props = new AuthenticationProperties{ IsPersistent = true };
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    principal,
                    props);

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
