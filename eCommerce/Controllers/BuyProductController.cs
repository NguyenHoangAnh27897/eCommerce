using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.Controllers
{
    public class BuyProductController : Controller
    {
        // GET: BuyProduct
        public ActionResult Transport()
        {
            return View();
        }

        public ActionResult GuideBuyproduct()
        {
            return View();
        }

        public ActionResult PersonalCare()
        {
            return View();
        }
    }
}