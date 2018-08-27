using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerce.Models;

namespace eCommerce.Controllers
{
    public class HomeController : Controller
    {
        DochoiSMEntities db = new DochoiSMEntities();
        public ActionResult Index()
        {
            var lst = db.SM_Product.Where(s=>s.IsSale == false).OrderByDescending(s => s.CreateDate).ToList();
            return View(lst);
        }

        [HttpGet]
        public ActionResult Search(string search = "")
        {
            var lst = db.SM_Product.Where(s => s.ProductName.Contains(search)).ToList();
            return View(lst);
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}