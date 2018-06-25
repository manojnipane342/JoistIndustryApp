using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PickAny_.Model.UserProfiles;
using PickAny_.Logic;
namespace PickAny.Helpers
{
    public class Mapper
    {
        public static UserProfile Map(UserProfiles src)
        {
            return src == null ? null : new UserProfile
            {
                UserId = src.UserId,
                UserName = src.UserName,
                Pass = src.Pass,
                FullName = src.FullName,
                Mobile = src.Mobile,
                Address = src.Address,
                City = src.City,
                PinCode = src.PinCode,
                State = src.State,
                CreatedById = src.CreatedById,
                CreatedDate = src.CreatedDate,
                IsDeactive = src.IsDeactive,
                IndustryId = src.IndustryId,
                RoleId = src.RoleId,
                Email = src.Email,
                EmailVerified = src.EmailVerified,
                ActivationCode = src.ActivationCode,
            };
        }

        public static UserProfiles Map(UserProfile src)
        {
            return src == null ? null : new UserProfiles
            {
                UserId = src.UserId,
                UserName = src.UserName,
                Pass = src.Pass,
                FullName = src.FullName,
                Mobile = src.Mobile,
                Address = src.Address,
                City = src.City,
                PinCode = src.PinCode,
                State = src.State,
                CreatedById = src.CreatedById.HasValue ? src.CreatedById.Value : 0,
                CreatedDate = src.CreatedDate,
                IsDeactive = src.IsDeactive,
                IndustryId = src.IndustryId.HasValue ? src.IndustryId.Value : 0,
                RoleId = src.RoleId.HasValue ? src.RoleId.Value : 0,
                Email = src.Email,
                EmailVerified = src.EmailVerified,
                ActivationCode = src.ActivationCode,
            };
        }
    }
}