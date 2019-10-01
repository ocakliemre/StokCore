using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StokCoreUI.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            ViewData["TaxNumber"] = HttpContext.Session.GetString("TaxNumber");
            ViewData["AuthorizedPerson"] = HttpContext.Session.GetString("AuthorizedPerson");
            return View();
        }
    }
}