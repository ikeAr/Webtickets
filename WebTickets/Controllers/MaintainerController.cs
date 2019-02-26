using System.Web.Mvc;
using WebTickets.Repo;

namespace WebTickets.Controllers
{
    public class MaintainerController : ControllerBase
    {
        // GET: Maintainer
        public ActionResult Index()
        {         
            return View();
        }

        public ActionResult UpdateStatus(string id, int condition)
        {
            var requestRepo = new RequestRepo();
            var ticket = requestRepo.Get(id);
            ticket.Condition = condition;
            requestRepo.Update(ticket);
            //return this.Json("success",JsonRequestBehavior.AllowGet);
            return View("Index");
        }
        public ActionResult Introduction()
        {
            return View();
        }
    }
}