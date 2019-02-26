using System.Web.Mvc;

namespace WebTickets.Controllers
{
    [AllowAnonymous]
    public class HomeController : ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Problem()
        {
            return View();
        }

        public ActionResult Advice()
        {
            return View();
        }
        public ActionResult News()
        {
            return View();
        }
    }
}