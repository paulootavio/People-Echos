using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace HQ_Echos___WEB.Controllers
{
    
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {           
            if(User.Identity.IsAuthenticated)
            {
                ViewBag.Message = "Vc está logado.";
                return View("IndexAuth");
            }
            else
            {
                ViewBag.Message = "Descrição com video sobre o que é o People Echos..";
            }
            
            return View();
        }

        public ActionResult IndexAuth()
        {
            ViewBag.Message = "Vc está logado.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
