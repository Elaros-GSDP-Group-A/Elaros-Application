using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElarosApp.Data;
using ElarosApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ElarosApp.Controllers
{

    public class ReportController : Controller
    {
        public readonly DataContext _context;
        private Dictionary<string, Dictionary<string, double>> Results;

        public ReportController(DataContext ctx)
        {
            _context = ctx;
            BuildDataStructure();
        }


        public void BuildDataStructure()
        {
            Results = new Dictionary<string, Dictionary<string, double>>()
                    {
                        { "Breathlessness", new Dictionary<string, double>()
                            {
                                {"Precovid",  _context.Breathlessness.ToList().Average(r1 => double.Parse(r1.PrecovidAtRest))},
                                {"Postcovid", _context.Breathlessness.ToList().Average(r1 => double.Parse(r1.PostcovidAtRest))},
                            }
                        },

                        { "Coughing", new Dictionary<string, double>()
                            {
                                {"Severity", _context.Voice.ToList().Average(r1 => double.Parse(r1.Severity))},
                            }
                        },

                        { "Consumption", new Dictionary<string, double>()
                            {
                                {"Severity", _context.Consumption.ToList().Average(r1 => double.Parse(r1.Severity))},
                            }
                        },

                        { "Fatigue", new Dictionary<string, double>()
                            {
                                {"Precovid", _context.Fatigue.ToList().Average(r1 => double.Parse(r1.Precovid))},
                                {"Postcovid", _context.Fatigue.ToList().Average(r1 => double.Parse(r1.Postcovid))},
                            }
                        },

                        { "Continence", new Dictionary<string, double>()
                            {
                                {"Severity", _context.Continence.ToList().Average(r1 => double.Parse(r1.Severity))},
                            }
                        },

                        { "Pain", new Dictionary<string, double>()
                            {
                                {"Precovid", _context.Pain.ToList().Average(r1 => double.Parse(r1.Precovid))},
                                {"Postcovid", _context.Pain.ToList().Average(r1 => double.Parse(r1.Postcovid))},
                            }
                        },

                        { "Cognition", new Dictionary<string, double>()
                            {
                                {"Severity", _context.Cognition.ToList().Average(r1 => double.Parse(r1.Severity))},
                            }
                        },

                        { "Anxiety", new Dictionary<string, double>()
                            {
                                {"Precovid", _context.Anxiety.ToList().Average(r1 => double.Parse(r1.Precovid))},
                                {"Postcovid", _context.Anxiety.ToList().Average(r1 => double.Parse(r1.Postcovid))},
                            }
                        },

                        { "Depression", new Dictionary<string, double>()
                            {
                                {"Precovid", _context.Depression.ToList().Average(r1 => double.Parse(r1.Precovid))},
                                {"Postcovid", _context.Depression.ToList().Average(r1 => double.Parse(r1.Postcovid))},
                            }
                        },

                        { "Ptsd", new Dictionary<string, double>()
                            {
                                {"Severity", _context.Ptsd.ToList().Average(r1 => double.Parse(r1.Severity))},
                            }
                        },

                        { "Communication", new Dictionary<string, double>()
                            {
                                {"Severity", _context.Communication.ToList().Average(r1 => double.Parse(r1.Severity))},
                            }
                        },

                        { "Mobility", new Dictionary<string, double>()
                            {
                                {"Precovid", _context.Mobility.ToList().Average(r1 => double.Parse(r1.Precovid))},
                                {"Postcovid", _context.Mobility.ToList().Average(r1 => double.Parse(r1.Postcovid))},
                            }
                        },

                        { "PersonalCare", new Dictionary<string, double>()
                            {
                                {"Precovid", _context.PersonalCare.ToList().Average(r1 => double.Parse(r1.Precovid))},
                                {"Postcovid", _context.PersonalCare.ToList().Average(r1 => double.Parse(r1.Postcovid))},
                            }
                        },

                        { "Activities", new Dictionary<string, double>()
                            {
                                {"Precovid", _context.Activities.ToList().Average(r1 => double.Parse(r1.Precovid))},
                                {"Postcovid", _context.Activities.ToList().Average(r1 => double.Parse(r1.Postcovid))},
                            }
                        },

                        { "SocialRole", new Dictionary<string, double>()
                            {
                                {"Precovid", _context.SocialRole.ToList().Average(r1 => double.Parse(r1.Precovid))},
                                {"Postcovid", _context.SocialRole.ToList().Average(r1 => double.Parse(r1.Postcovid))},
                            }
                        },

                        { "OverallHealth", new Dictionary<string, double>()
                            {
                                {"Precovid", _context.OverallHealth.ToList().Average(r1 => double.Parse(r1.Precovid))},
                                {"Postcovid", _context.OverallHealth.ToList().Average(r1 => double.Parse(r1.Postcovid))},
                            }
                        },

                    };

        }
        public IActionResult Index()
        {
            return View("TrialResults", Results);
        }
    }
}