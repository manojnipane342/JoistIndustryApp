using PickAny.Helpers;
using PickAny.Models;
using PickAny_.Logic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace PickAny.Repository
{
    public class UserRepository
    {
        PickAnyLiveEntities db = new PickAnyLiveEntities();

        public UserRepository()
        {

        }

        public bool IsVerfiedEmail(string email, string pass)
        {
            return db.UserProfiles.Where(x => x.Email == email && x.Pass == pass && x.IsDeactive == false && x.EmailVerified == true).Count() > 0;
        }

        public bool CheckLogin(LoginModel loginVM)
        {
            var user = 0;
            try
            {
                if (string.IsNullOrWhiteSpace(loginVM.UserName))
                {
                    throw new Exception(Messages.BAD_DATA);
                }
                user = db.UserProfiles.Where(x => x.UserName == loginVM.UserName && x.Pass == loginVM.Password).Count();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            return user > 0;
        }

        public string ForgotPassword(string email)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(email))
                {
                    throw new Exception(Messages.BAD_DATA);
                }
                var user = db.UserProfiles.FirstOrDefault(x => x.UserName == email && !x.IsDeactive);
                if (user == null)
                {
                    throw new Exception(Messages.BAD_DATA);
                }
                //if (messenger == null) throw new Exception(Messages.ERROR_SENDING_EMAIL);
                var messagedata = new
                {
                    email = user.UserName,
                    url = HttpContext.Current.Request.Url.Scheme + "://" + HttpContext.Current.Request.Url.Authority,
                    token = HttpContext.Current.Server.UrlEncode(Security.Encrypt(user.UserId.ToString()))
                };
                //messenger.SendEmail(user.UserName, Messages.PASSWORD_RESET, string.Format(Messages.PASSWORD_RESET_MESSAGE, messagedata.email, messagedata.url, messagedata.token));
                return Messages.PASSWORD_RESET_SUCCESS;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public PickAny_.Model.UserProfiles.UserProfiles AddOrUpdateProfile(PickAny_.Model.UserProfiles.UserProfiles userVM)
        {
            try
            {
                var user = db.UserProfiles.FirstOrDefault(x => x.UserId == userVM.UserId);
                if (user == null)
                {
                    user = Mapper.Map(userVM);
                    userVM.CreatedDate = DateTime.Now;
                    db.UserProfiles.Add(user);
                    db.SaveChanges();
                    return Mapper.Map(user);
                }
                else
                {
                    db.Entry(user).CurrentValues.SetValues(userVM);
                    db.SaveChanges();
                    return Mapper.Map(user);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public bool SendActivationEmail(string email)
        {
            bool status = true;
            try
            {
                int userId = (from u in db.UserProfiles where u.Email == email select u.UserId).First();
                Guid activationCode = Guid.NewGuid();

                SaveEmailCode(activationCode, userId);

                string Subject = "Account Activation";
                string body = "Hello dear,";
                body += "<br /><br />Please click the following link to activate your account";
                body += "<br /><a href = '" + string.Format("{0}://{1}/Account/EmailActivation?activationCode={2}", HttpContext.Current.Request.Url.Scheme, HttpContext.Current.Request.Url.Authority, activationCode) + "'>Click here to activate your account.</a>";
                body += "<br /><br />Thanks";
                Messaging mm = new Messaging();
                string ToMail = ConfigurationManager.AppSettings["FromEmail"];
                mm.SendMail(email, Subject + " from (" + ToMail + " )", body);
            }
            catch (Exception ex)
            {
                status = false;
                throw new Exception(ex.Message.ToString());
            }
            return status;
        }

        public void UpdateEmailStatus(string email, int UserId)
        {
            PickAny_.Logic.UserProfile user = db.UserProfiles.FirstOrDefault(x => x.UserId == UserId);
            if (!user.EmailVerified)
            {
                user.EmailVerified = true;
                db.SaveChanges();
            }
        }

        public void SaveEmailCode(Guid code, int UserId)
        {
            PickAny_.Logic.UserProfile user = db.UserProfiles.FirstOrDefault(x => x.UserId == UserId);
            if (user != null)
            {
                user.ActivationCode = code.ToString();
                db.SaveChanges();
            }
        }

        public PickAny_.Logic.UserProfile CheckActivationCode(Guid code)
        {
            PickAny_.Logic.UserProfile user = new PickAny_.Logic.UserProfile();
            try
            {
                user = db.UserProfiles.Where(x => x.ActivationCode == code.ToString()).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            return user;
        }

        //public bool IsUserExists(string email, int id)
        //{
        //    return db.users.Count(x => x.email == email && x.id != id) > 0;
        //}

        //public bool IsUserExists(string email)
        //{
        //    return db.users.Count(x => x.email == email) > 0;
        //}

        //public UserVM GetUserByEmail(string email)
        //{
        //    try
        //    {
        //        if (string.IsNullOrWhiteSpace(email))
        //        {
        //            throw new Exception(Messages.BAD_DATA);
        //        }
        //        var user = db.users.FirstOrDefault(x => x.email == email && x.is_active);
        //        return Mapper.Map(user);
        //    }
        //    catch (Exception ex)
        //    {
        //        ErrorSignal.FromCurrentContext().Raise(ex);
        //        throw new Exception(ex.Message.ToString());
        //    }
        //}
    }
}