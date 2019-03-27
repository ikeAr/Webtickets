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
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AllUser()
        {
            return View();
        }
        public ActionResult DeletelUser(string id)
        {
            var userRepo = new UserRepo();
            userRepo.Delete(id);
            return Json("true",JsonRequestBehavior.AllowGet);
        }
    }
}