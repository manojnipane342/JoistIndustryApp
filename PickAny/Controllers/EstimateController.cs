using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PickAny.Controllers
{
    public class EstimateController : Controller
    {
        // GET: Estimate
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NewEstimate()
        {
            return View();
        }
    }
}