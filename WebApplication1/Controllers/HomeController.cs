using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //comment
            //2
            //change from branch1
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return view();
        }

        public actionresult contact()
        {
            viewbag.message = "your contact page.";

            return view();
        }
    }
}
//xcvxcvxvxvcxzvxz