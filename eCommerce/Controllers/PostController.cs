using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        public ActionResult List()
        {
            return View();
        }

        public ActionResult Detail(int id)
        {
            return View();
        }
    }
}