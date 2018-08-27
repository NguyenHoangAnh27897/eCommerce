using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerce.Models;

namespace eCommerce.Controllers
{
    public class DetailProductController : Controller
    {
        DochoiSMEntities db = new DochoiSMEntities();
        //
        // GET: /DetailProduct/
        public ActionResult Detail(int id)
        {
            var pd = db.SM_Product.Where(s => s.ID == id);
            return View(pd);
        }
	}
}