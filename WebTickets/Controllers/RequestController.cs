
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
            //if (newRequestModel != null)
            //{
            //    string fileName = Path.GetFileNameWithoutExtension(newRequestModel.Image.ImageFile.FileName);
            //    string extension = Path.GetExtension(newRequestModel.Image.ImageFile.FileName);
            //    fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            //    newRequestModel.Image.ImagePath = "~/Image/" + fileName;
            //    fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);
            //    newRequestModel.Image.ImageFile.SaveAs(fileName);
            //}
            this.requestRepo.Add(newRequestModel);
            ModelState.Clear();
            return RedirectToAction("Index", "Home");
        }

    }
}