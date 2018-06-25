using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace PickAny.Helpers
{
    
    public class Messaging 
    {
        public void SendMail(string to, string subject, string data)
        {
            try
            {
                var mail = new MailMessage
                {
                    From = new MailAddress(ConfigurationManager.AppSettings["FromEmail"]),
                    Subject = subject,
                    Body = data,
                    IsBodyHtml = true
                };
                mail.To.Add(to);
                var smtp = new SmtpClient();
                smtp.Send(mail);
            }
            catch (Exception ex)
            {

            }
        }
    }
}