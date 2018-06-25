using PickAny_.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PickAny.Controllers
{
    public class BaseController : Controller
    {
        PickAnyLiveEntities db = new PickAnyLiveEntities();

        protected int UserId
        {
            get
            {
                var UserID = (from u in db.UserProfiles
                              where u.UserName == User.Identity.Name
                              select new
                              {
                                  UserID = u.UserId
                              }).Single();
                return Convert.ToInt32(UserID);
            }
        }
    }
}