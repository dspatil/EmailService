using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace EmailService
{
    public class EmailService : IEmailService
    {
        private static string SMTPSERVER = "smtp.gmail.com";
        private static int PORT = 587;

        public bool SendMail(SendMailRQ request)
        {
            if (string.IsNullOrEmpty(request.UserMailAddress))
                return false;
            if (string.IsNullOrEmpty(request.UserPassword))
                return false;
            if (string.IsNullOrEmpty(request.MailTo))
                return false;

            SmtpClient smtpClient = new SmtpClient(SMTPSERVER, PORT);
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(request.UserMailAddress, request.UserPassword);

            using (MailMessage message = new MailMessage())
            {
                message.From = new MailAddress(request.UserMailAddress);
                message.Subject = request.Subject == null ? "" : request.Subject;
                message.Body = request.Body == null ? "" : request.Body;
                message.IsBodyHtml = request.IsBodyHtml;
                message.To.Add(request.MailTo);
                message.CC.Add(request.ccTo);
                try
                {
                    smtpClient.Send(message);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
            }
        }
    }
}