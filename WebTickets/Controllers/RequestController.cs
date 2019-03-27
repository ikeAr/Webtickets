
using System;
using System.IO;
using System.Web.Mvc;
using WebTickets.Repo;

namespace WebTickets.Controllers
{
    public class RequestController : ControllerBase
    {
        RequestRepo requestRepo = new RequestRepo();
        // GET: UserHome
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SaveRequestData(RequestModel newRequestModel)
        {
            this.requestRepo.Add(newRequestModel);
            return Json("true", JsonRequestBehavior.AllowGet);
        }

    }
}