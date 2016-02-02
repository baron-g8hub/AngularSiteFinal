﻿using MFlorist.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaynoothFloristSite.Controllers
{
    public class HomeController : Controller
    {
        private FlowersdbEntities db = new FlowersdbEntities();
         /// <summary>
         /// //////////////////////////////////////////////////////////////////////
         /// </summary>
         /// <returns></returns>
        // GET: Home
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        public ActionResult ShowItem()
        {
            return PartialView("_ShowItem");
        }

        public ActionResult IndexVM()
        {
            using (db)
            {
                var employeeList = db.Products.ToList();
                return Json(employeeList, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult getItemByNo(int? itemId)
        {
            using (db)
            {
                int no = Convert.ToInt32(itemId);
                var employeeList = db.Products.Find(no);
                return Json(employeeList, JsonRequestBehavior.AllowGet);
            }
        }
    }
}