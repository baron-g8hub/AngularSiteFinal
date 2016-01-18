using MFlorist.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaynoothFloristSite.Controllers
{
    public class TesterController : Controller
    {
        private FlowersdbEntities db = new FlowersdbEntities();

        // GET: Tester
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Upload(Product product, HttpPostedFileBase file)
        {
            string path = Server.MapPath("~/Products/" + file.FileName);
            file.SaveAs(path);
            ViewBag.Path = path;
            return View();
        }
    }
}