using MvcJqueryMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcJqueryMobile.Controllers
{
    public class ChairsController : Controller
    {
        // GET: Chairs
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        MobileContext db = new MobileContext();
        public ActionResult ChairsList()
        {
            var chairs = db.Chairs.OrderBy(x => x.Category).ToList();
            return View(chairs);
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Stores()
        {
            return View();
        }
    }
}