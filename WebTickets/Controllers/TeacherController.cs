using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTickets.Controllers
{
    public class TeacherController : ControllerBase
    {
        // GET: Teacher
       
        public ActionResult AuditUser()
        {
            return View();
        }

        public ActionResult AuditRequest()
        {
            return View();
        }
    }
}