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

        public ActionResult UpdateStatus(string id, int condition, string maintainerId)
        {
            var requestRepo = new RequestRepo();
            var ticket = requestRepo.Get(id);
            var userRepo = new UserRepo();
            var maintainer = userRepo.Get(x => x.Id == maintainerId);
            ticket.Maintainer = maintainer.Name;
            ticket.Condition = condition;
            requestRepo.Update(ticket);            
            //return this.Json("success",JsonRequestBehavior.AllowGet);
            return View("Index");
        }

        public ActionResult Introduction()
        {
            return View();
        }
        public ActionResult GetAllRequest()
        {
            return View();
        }
    }
}