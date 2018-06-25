using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PickAny_.Logic.Interface;
using PickAny_.Model;
using PickAny_.Model.UserProfiles;

namespace PickAny_.Logic.Service
{
    public class UserProfileService : IUserProfile
    {
        private PickAnyLiveEntities dbcontext = new PickAnyLiveEntities();
        public Result<Boolean> Save(UserProfiles userProfile)
        {
            Result<Boolean> _Result = new Result<Boolean>();

            try
            {
                _Result.IsSuccess = false;

                if (userProfile.UserId == 0)
                {
                    var _userExists = dbcontext.UserProfiles.Where(c => c.UserName == userProfile.UserName).FirstOrDefault();
                    if (_userExists == null)
                    {
                        if (dbcontext.UserProfiles.Where(x => x.Email == userProfile.Email).Count() == 0)
                        {
                            UserProfile UserProfileObject = new UserProfile();
                            UserProfileObject.FullName = userProfile.FullName;
                            UserProfileObject.UserName = userProfile.UserName;
                            UserProfileObject.Pass = userProfile.Pass;
                            UserProfileObject.Address = userProfile.Address;
                            UserProfileObject.Mobile = userProfile.Mobile;
                            UserProfileObject.Address = userProfile.Address;
                            UserProfileObject.CreatedDate = userProfile.CreatedDate;
                            UserProfileObject.CreatedById = userProfile.CreatedById;
                            UserProfileObject.City = userProfile.City;
                            UserProfileObject.PinCode = userProfile.PinCode;
                            UserProfileObject.IsDeactive = userProfile.IsDeactive;
                            UserProfileObject.RoleId = userProfile.RoleId;
                            UserProfileObject.IndustryId = userProfile.IndustryId;

                            dbcontext.UserProfiles.Add(UserProfileObject);
                            dbcontext.SaveChanges();

                            _Result.IsSuccess = true;
                        }
                        else
                        {
                            _Result.IsSuccess = false;
                            throw new Exception("email address already exists. please try different");
                        }
                    }
                    else
                    {
                        _Result.IsSuccess = false;
                    }

                }
                else
                {
                    var _userExists = dbcontext.UserProfiles.Where(c => c.UserId == userProfile.UserId).FirstOrDefault();
                    if (_userExists != null)
                    {
                        _userExists.FullName = userProfile.FullName;
                        _userExists.UserName = userProfile.UserName;
                        _userExists.Pass = userProfile.Pass;
                        _userExists.Address = userProfile.Address;
                        _userExists.Mobile = userProfile.Mobile;
                        _userExists.Address = userProfile.Address;
                        _userExists.CreatedDate = userProfile.CreatedDate;
                        _userExists.CreatedById = userProfile.CreatedById;
                        _userExists.City = userProfile.City;
                        _userExists.PinCode = userProfile.PinCode;
                        _userExists.IsDeactive = userProfile.IsDeactive;
                        _userExists.RoleId = userProfile.RoleId;
                        _userExists.IndustryId = userProfile.IndustryId;

                        dbcontext.SaveChanges();
                        _Result.IsSuccess = true;
                    }
                    else
                    {
                        _Result.IsSuccess = false;
                    }
                }
            }
            catch (Exception ex)
            {
                _Result.IsSuccess = false;
                _Result.Message = ex.Message;
                _Result.Exception = ex.InnerException;
            }

            return _Result;
        }
    }
}
