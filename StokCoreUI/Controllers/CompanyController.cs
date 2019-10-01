using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StokCoreBll.Concrete;
using StokCoreData.concrete.EntityFramework;

namespace StokCoreUI.Controllers
{
    public class CompanyController : Controller
    {
        CompanyManager _companyManager;
        public CompanyController()
        {
            _companyManager = new CompanyManager(new EfCompanyDal());
        }
        public IActionResult Index()
        {
            ViewData["TaxNumber"] = HttpContext.Session.GetString("TaxNumber");
            ViewData["AuthorizedPerson"] = HttpContext.Session.GetString("AuthorizedPerson");
            return View(_companyManager.Get((int)HttpContext.Session.GetInt32("CompanyId")));
        }
    }
}