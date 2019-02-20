using System.Web.Mvc;
using WebTickets.Repo;

namespace WebTickets.Controllers
{
    public class RequestController : Controller
    {
        RequestRepo requestRepo = new RequestRepo();
        // GET: UserHome
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SaveRequest(RequestModel newRequestModel)
        {
            this.requestRepo.Add(newRequestModel);
            return RedirectToAction("Index", "Home");
        }

    }
}