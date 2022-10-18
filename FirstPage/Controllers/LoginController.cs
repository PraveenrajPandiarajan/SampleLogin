using FirstPage.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace FirstPage.Controllers
{
    public class LoginController : Controller
    {

        
        public ActionResult FirstPage()
        {
            return View();
        }
        public ActionResult Index(Mod user)
        {
            if (user.userName == "Praveen" && user.pass == 123)
            {
                return RedirectToAction("NextPage");
            }
            else
            {

                return RedirectToAction("NextOne");
            }

        }
        public ActionResult NextPage(Mod user)
        {
            
                Mod mod = new Mod()
                {
                    userName = user.userName,
                    pass = user.pass,
                    c = 79,
                    Java = 89,
                    Matrics = 65,
                    Trignometry = 90,
                    AdvancedAlgebra = 88,
                    Algebra = 78,
                    Differential = 65,
                    Html = 79,
                    Integral = 89,
                    OperationResearch = 65,
                    Python = 90,
                    Vertices = 78,   

                };
                return View(mod);

            }

        public ActionResult NextOne()
        {
            ViewBag.name = "InCorrect userName and Password";
            return View();
        }

    }
        
    }
