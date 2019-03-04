using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTickets.Models;
using WebTickets.Repo;

namespace WebTickets.Controllers
{
    public class AdministratorController : ControllerBase
    {
        // GET: Administrator
        TeacherRepo teacherRepo = new TeacherRepo();
        public ActionResult Index(TeacherModel teacher)
        {
            teacherRepo.Add(teacher);
            return View();
        }
    }
}