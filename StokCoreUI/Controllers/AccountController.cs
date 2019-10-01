using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StokCoreData.Concrete;
using StokCoreModels;
using StokCoreBll.Concrete;
using System.Web.Helpers;
using StokCoreData.concrete.EntityFramework;
using Microsoft.AspNetCore.Http;

namespace StokCoreUI.Controllers
{
    public class AccountController : Controller
    {
        private AuthenticationManager _authenticationManager;
        private CompanyManager _companyManager;
        public AccountController()
        {
            _authenticationManager = new AuthenticationManager(new EfAuthenticationDal());
            _companyManager = new CompanyManager(new EfCompanyDal());
        }
        public IActionResult CompanyLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CompanyLogin(string Username, string Password)
        {
            Company User = new Company
            {
                Password = Crypto.Hash(Password, "sha256"),
                TaxNumber = Username

            };
            Company company = _authenticationManager.AuthenticationCompany(User);
            if (company != null)
            {
                HttpContext.Session.SetString("TaxNumber",company.TaxNumber);
                HttpContext.Session.SetString("AuthorizedPerson", company.AuthorizedPerson);
                HttpContext.Session.SetInt32("CompanyId", company.Id);
                return Redirect("~/Company/Index");
            }
            else
            {
                ViewData["NotEntry"] = "Kulanıcı Adınız Ya da Şifreniz Yanlış Olabilir";

                return View();
            }
        }

        public IActionResult CreateNewAccount()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateNewAccount(string Password)
        {
            Company company = new Company
            {
                Name = Request.Form["Name"],
                AuthorizedPerson = Request.Form["AuthorizedPerson"],
                Password = Crypto.Hash(Password, "sha256"),
                TaxNumber = Request.Form["TaxNumber"],
                Email = Request.Form["Email"],
                IsActive = true

            };
            _companyManager.Add(company);
            return View("CompanyLogin");
        }
    }
}