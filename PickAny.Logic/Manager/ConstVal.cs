using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickAny.Logic.Manager
{
    public class ConstVal
    {
        //For Roles
        public const string Administrator = "Administrator";
    }
    public static class CommonMethod
    {
        public static bool UserAllowedToAccessMenu(int userid, string menu)
        {
            using (ALoanContext context = new ALoanContext())
            {
                var userroleid = context.UserInRoles.Where(c => c.UserId == userid).Select(x => x.RoleId).FirstOrDefault();
                var check = context.UserRights.Any(x => x.FkMenu.Action == menu && x.RoleId == userroleid);
                return check;
            }
        }
    }
}
