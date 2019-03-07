using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTickets.Models;
using WebTickets.Repo;

namespace WebTickets.Controllers
{
    public class TeacherController : ControllerBase
    {
        // GET: Teacher
        public ActionResult AuditUser()
        {
            return View();
        }
        public ActionResult SaveAuditUser(string id ,int auditStatus)
        {
            var userRepo = new UserRepo();
            var user = userRepo.Get(x => x.Id == id);
            user.AuditStatus = auditStatus;
            userRepo.Update(user);
            return View("AuditUser");
        }

        public ActionResult AuditRequest()
        {
            return View();
        }

        public ActionResult Introduction()
        {
            return View();
        }
    }
}