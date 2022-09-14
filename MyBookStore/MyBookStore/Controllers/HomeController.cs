using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace MyBookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
            //return View("TempView/Other.cshtml");
            //return View("~/TempView/Other.cshtml");
            //return View("../../TempView/Other");

            //var obj = new { Id = 1, Name = "Nitish" };
            //return View("ContactUs",obj);

            //return View(obj);
            //return View("Contactus");
        }
        public ViewResult AboutUs()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
