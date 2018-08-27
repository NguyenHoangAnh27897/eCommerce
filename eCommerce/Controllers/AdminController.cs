using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerce.Models;

namespace eCommerce.Controllers
{
    public class AdminController : Controller
    {
        DochoiSMEntities db = new DochoiSMEntities();
        //
        // GET: /Admin/
        public ActionResult Index()
        {
            var lst = db.SM_Product.ToList();
            return View(lst);
        }

        public ActionResult AddProduct()
        {
            return View();
        }
	}
}