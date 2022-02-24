using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using WCFClient.MyServiceClient1;

namespace WCFClient.Controllers
{
    public class ProductController : Controller
    {
        MyServiceClient1.Service1Client serviceClient = new MyServiceClient1.Service1Client();
        // GET: Product
        [HttpPost]
        public ActionResult Index()
        {
            var listproduct = serviceClient.GetList();

            return View(listproduct);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(Product product)
        {
            serviceClient.Save(product);
            return RedirectToAction("Index");
        }
    }
}