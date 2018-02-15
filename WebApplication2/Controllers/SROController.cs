using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class SROController : Controller
    {
        //
        // GET: /SRO/
        public string SubmitLeave(int Id = 123456, string batch = "2015-10C",int days = 3)
        {

            return "Your have been issued "+days+" of leave";
        }

        public string Complain(int Id = 123456, string batch = "2015-10C", string issue = "internet")
        {

            return "Your Complain against "+issue+" has been submitted";
        }
	}
}