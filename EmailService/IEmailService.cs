using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace EmailService
{
    [ServiceContract]
    public interface IEmailService
    {
        [OperationContract]
        bool SendMail(SendMailRQ request);
    }
}