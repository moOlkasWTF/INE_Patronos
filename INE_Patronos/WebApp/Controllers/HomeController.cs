using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (INE_PatronosDbContext dbCtx = new INE_PatronosDbContext())
            {
                new INE_PatronosDbInitializer().InitializeDatabase(dbCtx);
            }

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }


    }
}