using System.Web.Mvc;
using WebTickets.Repo;

namespace WebTickets.Controllers
{
    public class MaintainerController : Controller
    {
        // GET: Maintainer
        public ActionResult Index()
        {
            var requestRepo = new RequestRepo();
            var requests = requestRepo.GetAll();
            //ViewBag.
            return View();
        }
    }
}