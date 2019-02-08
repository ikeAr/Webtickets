using System.Web.Mvc;
using WebTickets.Repo;

namespace WebTickets.Controllers
{
    public class UserHomeController : Controller
    {
        // GET: UserHome
        public ActionResult Index(RequestModel newRequestModel)
        {
            var handler = new RequestRepo();
            handler.Add(newRequestModel);
            return RedirectToAction("Index","Home");
        }
      
    }
}