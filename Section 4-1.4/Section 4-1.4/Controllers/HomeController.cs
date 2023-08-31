using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Web.Mvc;
using System.EnterpriseServices;
using Section_4_1._4.Controllers;


namespace Section_4_1._4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        /*public ActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/

        public ActionResult Info(String t)
        {
            ViewData["Message"] = "You have requested info for " + t;

            return View();
        }
        [HttpPost]
        public ActionResult StudentDetails(String t)
        {
            StringBuilder sb = new StringBuilder("<b>Student details entered:</b><br>");
            sb.Append("Name: " + Request.Form["name"].ToString() + "<Br>");
            sb.Append("Address: " + Request.Form["address"].ToString() + "<Br>");
            sb.Append("Subject: " + Request.Form["subject"].ToString() + "<Br>");

            ViewData["message"] = sb.ToString();
            return View();
        }

    }
}


