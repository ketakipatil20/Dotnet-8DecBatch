using Day4Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Day4Assignment.Controllers
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly MyDbContext context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, MyDbContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.Accounts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public Microsoft.AspNetCore.Mvc.ActionResult Create()

        {

            return View();

        }

        public Microsoft.AspNetCore.Mvc.ActionResult CreateAccount(Account a)

        {

            context.Accounts.Add(a);

            context.SaveChanges();

            return RedirectToAction("Index");

        }

        public Microsoft.AspNetCore.Mvc.ActionResult Edit(int? accno)

        {

            var account_to_edit = (from a in context.Accounts

                                   where a.AccountNumber == accno

                                   select a).SingleOrDefault();

            return View(account_to_edit);

        }

        public Microsoft.AspNetCore.Mvc.ActionResult EditAccount(Account a)

        {

            context.Entry<Account>(a).State = EntityState.Modified;

            context.SaveChanges();

            return RedirectToAction("Index");

        }

        public Microsoft.AspNetCore.Mvc.ActionResult Delete(int? accno)

        {

            var account_to_delete = (from a in context.Accounts

                                     where a.AccountNumber == accno

                                     select a).SingleOrDefault();

            context.Entry<Account>(account_to_delete).State = EntityState.Deleted;

            context.SaveChanges();

            return RedirectToAction("Index");

        }

        public Microsoft.AspNetCore.Mvc.JsonResult CheckAccountNumber(int AccountNumber)

        {

            var acc = (from a in context.Accounts

                       where a.AccountNumber == AccountNumber

                       select a).SingleOrDefault();

            if (acc == null)

            {

                return Json(true, JsonRequestBehavior.AllowGet);

            }

            return Json("Account number " + AccountNumber + "already exists", JsonRequestBehavior.AllowGet);

}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = false)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ??HttpContext.TraceIdentifier });
        }
    }
}
