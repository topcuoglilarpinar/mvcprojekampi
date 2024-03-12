using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPorjekampiEğitimi.Class
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string UserName { get; set; }
        public string UserMail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}