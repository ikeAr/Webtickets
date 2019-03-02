using System;
using System.Web.Mvc;
using WebTickets.Repo;

namespace WebTickets.Controllers
{
    [AllowAnonymous]
    public class RegisterController : ControllerBase
    {
        UserRepo userRepo = new UserRepo();
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CheckData(string ruijieId)
        {
            if ((userRepo.GetCount(x => x.RuiJieId == ruijieId) > 0))
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }

        }

        public ActionResult SaveRegisterData(UserModel newUser)
        {
            newUser.Password = newUser.Password.ToMD5HashCode();
            userRepo.Add(newUser);
            return RedirectToAction("Index", "Home");
        }
    }
}