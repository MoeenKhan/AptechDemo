using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class ExamController : Controller
    {
        //
        // GET: /Exam/

        public string Index(int Id = 123456, string batch = "2015-10C")
        {
            int Attend = 80;
            int ReqAttend = 75;
            if(Attend > ReqAttend)
                return "Your Exam is scheduled";
            else
                return "Your Exam isn't scheduled";
        }

        public string ScheduleExam(int Id = 123456, string batch = "2015-10C")
        {

            return "Your Exam has been Scheduled";
        }
	}
}