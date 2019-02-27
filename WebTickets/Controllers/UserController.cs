using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTickets.Controllers
{
    public class UserController : ControllerBase
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
    }
}