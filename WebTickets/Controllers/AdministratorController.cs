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
    }
}