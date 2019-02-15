using System.Web.Mvc;
using WebTickets.Repo;

namespace WebTickets.Controllers
{
    public class UserHomeController : Controller
    {
        RequestRepo requestRepo = new RequestRepo();
        // GET: UserHome
        public ActionResult Index(RequestModel newRequestModel)
        {
            requestRepo.Add(newRequestModel);
            return RedirectToAction("Index", "Home");
        }

    }
}