using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace EmailService
{
    [DataContract]
    public class SendMailRQ
    {
        [DataMember]
        public string UserMailAddress { get; set; }

        [DataMember]
        public string UserPassword { get; set; }

        [DataMember]
        public string MailTo { get; set; }

        [DataMember]
        public string ccTo { get; set; }

        [DataMember]
        public string Subject { get; set; }

        [DataMember]
        public string Body { get; set; }

        [DataMember]
        public bool IsBodyHtml { get; set; }
    }
}
