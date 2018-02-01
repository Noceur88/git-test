using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bitchtits.Controllers
{
    public class HomeController : Controller
    {
        #region Landing
        public ActionResult Index()
        {
            return View();
        }
        #endregion

        #region How To
        public ActionResult HowTo()
        {
            ViewBag.Message = "Show walkthrough here.";

            return View();
        }
        #endregion

        #region Pricing
        public ActionResult Pricing()
        {
            ViewBag.Message = "See pricing table here.";

            return View();
        }
        #endregion

        #region About Us
        public ActionResult About()
        {
            ViewBag.Message = "Our mission and what we do....";

            return View();
        }
        #endregion

        #region Contact Info
        public ActionResult Contact()
        {
            ViewBag.Message = "How to contact us.";

            return View();
        }
        #endregion

        #region PVs
        public ActionResult PV_EntryForm()
        {
            ViewBag.Message = "Please explain your issue.";

            return View();
        }
        #endregion
    }
}