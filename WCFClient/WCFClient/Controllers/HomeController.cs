using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCFClient.MyServiceClient1;

namespace WCFClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MyServiceClient1.Service1Client serviceClient = new MyServiceClient1.Service1Client();
            serviceClient.GetList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}