using PickAny.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PickAny_.Logic.Interface;
using PickAny_.Logic.Service;
using PickAny_.Model;
namespace PickAny.Controllers
{
    //[Authorize]
    //[InitializeSimpleMembership]
    public class MasterController : Controller
    {
        // GET: Master
        #region ------------- declaration -----------------
        private IIndustryMaster _IIndustryMaster;
        #endregion

        #region ------------------ constractor ---------------------
        public MasterController(IIndustryMaster industrymaster)
        {
            _IIndustryMaster = industrymaster;
        }
        #endregion

        public ActionResult IndustryList()
        {
            List<PickAny_.Model.IndustryMaster> IndustryList = new List<PickAny_.Model.IndustryMaster>();
            IndustryList = _IIndustryMaster.GetIndustryList().Data;
            return PartialView("_IndustryList", IndustryList);
        }
        public ActionResult Industry()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Industry(IndustryMaster industrymaster)
        {
            var p = _IIndustryMaster.Save(industrymaster);
            TempData["industry"] = p.IsSuccess.ToString();
            return RedirectToAction("industry");
        }
        [HttpPost]
        public ActionResult UpdateIndustry(FormCollection fc)
        {
            IndustryMaster IndustryMaster = new IndustryMaster();
            IndustryMaster.Name = fc["IndustryName"];
            IndustryMaster.Id = fc["IndustryId"] == "" ? 0 : int.Parse(fc["IndustryId"]);

            if (IndustryMaster.Id > 0)
            {
                _IIndustryMaster.Save(IndustryMaster);
            }
            return RedirectToAction("industry");
        }
        
        public ActionResult DeleteIndustry(int id)
        {
            var p = _IIndustryMaster.Delete(id);
            return RedirectToAction("industry");
        }

        [HttpGet]
        public JsonResult GetIndustryById(int id)
        {
            var Industry = _IIndustryMaster.GetIndustryById(id).Data;
            return Json(Industry, JsonRequestBehavior.AllowGet);
        }

    }
}