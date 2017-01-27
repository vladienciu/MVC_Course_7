using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Course_7
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [ActionName("about") ]
        public ActionResult SomeMethodName()
        {
            return View("");
        }

        public double Calc()
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };            
            int sum = 0;
            foreach (int x in list)
                sum += x;
            return sum;
        }

        public double DisplayCalc()
        {
            return Calc();
        }

        [HttpGet]
        public ActionResult VerbsTest()
        {
            return View();
        }

        [Authorize(Roles ="Admin")]
        public ActionResult ThisMethodNeedsAuthorization()
        {
            return Content("Hello");
        }
    }
}