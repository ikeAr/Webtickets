using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebTickets.Repo;

namespace WebTickets.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }

        public ActionResult SaveRegisterDate(UserModel newUser)
        { 
            newUser.Password = newUser.Password.ToMD5HashCode();
            newUser.ConfirmPassword = newUser.ConfirmPassword.ToMD5HashCode();
            var handler = new UserRepo();
            handler.Add(newUser);
            return RedirectToAction("Index", "Home");
        }
    }
}