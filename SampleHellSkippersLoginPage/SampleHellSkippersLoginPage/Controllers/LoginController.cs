using SampleHellSkippersLoginPage.DbConnect;
using SampleHellSkippersLoginPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleHellSkippersLoginPage.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult LoginPage()
        {
            ViewBag.ErrorMsg = TempData["ErrorMessage"];
            return View();
        }
        public ActionResult DashboardPage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CheckLogin([Bind(Include = "Username")]User user)
        {
            return RedirectToAction("DashboardPage");
        }
        //[HttpPost]
        //public ActionResult CheckLogin(FormCollection fc)
        //{
        //    String un = fc["Username"].ToString();
        //    String pa = fc["Password"].ToString();
        //    return RedirectToAction("DashboardPage");
        //}
        //[HttpPost]
        //public ActionResult CheckLogin(String Username,String Password)
        //{
        //    DbFile db = new DbFile();
        //    var userlist =db.user.Where(x => x.Username == Username && x.Password == Password);
        //    bool isValid = userlist.ToList().Count>0;
        //    if (isValid)
        //    {
        //        return RedirectToAction("DashboardPage");
        //    }
        //    else
        //    {
        //        TempData["ErrorMessage"] = "Invalid Credantials";
        //        return RedirectToAction("LoginPage");
        //    }
        //}
    }
}