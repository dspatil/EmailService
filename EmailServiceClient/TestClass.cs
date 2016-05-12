using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmailServiceTestClient
{
    [TestClass]
    public class MyTestClass
    {
        [TestMethod]
        public void TestMethod()
        {
            EmailServiceClient client = new EmailServiceClient();

            var request = new SendMailRQ();
            request.UserMailAddress = "deepak@gmail.com";
            request.UserPassword = "*****";
            request.MailTo = "cts.deepak@yahoo.com";
            request.ccTo = "prashatgarud1992@gmail.com";
            request.Subject = "Test mail through my own Email service";
            request.IsBodyHtml = false;
            request.Body = "Hello...";

            var response = client.SendMail(request);


        }
    }
}
