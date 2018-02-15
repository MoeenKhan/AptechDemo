using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class AdmissionController : Controller
    {
        //
        // GET: /Admission/
        
        public string Index(string name = "Moeen", string batch = "2015-10C")
        {

            return "You got Admission in Batch "+batch+" and your ID is "+123456;
        }

        public string CancelAdmission(int Id = 123456, string batch = "2015-10C")
        {

            return "Your Admission in Batch " + batch + " is cancelled";
        }
	}
}