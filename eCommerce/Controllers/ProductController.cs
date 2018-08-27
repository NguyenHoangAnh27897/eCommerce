using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerce.Models;

namespace eCommerce.Controllers
{
    public class ProductController : Controller
    {
        DochoiSMEntities db = new DochoiSMEntities();
        //
        // GET: /Product/
        public ActionResult AllProduct()
        {
            return View();
        }

        public ActionResult SaleProduct()
        {
            return View();
        }
        public ActionResult SMSet()
        {
            var lst = db.SM_Product.Where(s => s.ProductTypeID == 1).OrderByDescending(s=>s.CreateDate).ToList();
            return View(lst);
        }

        public ActionResult SMAccessory()
        {
            var lst = db.SM_Product.Where(s => s.ProductTypeID == 2).OrderByDescending(s => s.CreateDate).ToList();
            return View(lst);
        }

        public ActionResult VibTR()
        {
            var lst = db.SM_Product.Where(s => s.ProductTypeID == 3).OrderByDescending(s => s.CreateDate).ToList();
            return View(lst);
        }

        public ActionResult VibMR()
        {
            var lst = db.SM_Product.Where(s => s.ProductTypeID == 4).OrderByDescending(s => s.CreateDate).ToList();
            return View(lst);
        }

        public ActionResult AnalButt()
        {
            var lst = db.SM_Product.Where(s => s.ProductTypeID == 5).OrderByDescending(s => s.CreateDate).ToList();
            return View(lst);
        }

        public ActionResult AnalBead()
        {
            var lst = db.SM_Product.Where(s => s.ProductTypeID == 6).OrderByDescending(s => s.CreateDate).ToList();
            return View(lst);
        }

        public ActionResult TailFox()
        {
            var lst = db.SM_Product.Where(s => s.ProductTypeID == 7).OrderByDescending(s => s.CreateDate).ToList();
            return View(lst);
        }

        public ActionResult TailDog()
        {
            var lst = db.SM_Product.Where(s => s.ProductTypeID == 8).OrderByDescending(s => s.CreateDate).ToList();
            return View(lst);
        }
        public ActionResult Paddle()
        {
            var lst = db.SM_Product.Where(s => s.ProductTypeID == 9).OrderByDescending(s => s.CreateDate).ToList();
            return View(lst);
        }
        public ActionResult Whip()
        {
            var lst = db.SM_Product.Where(s => s.ProductTypeID == 10).OrderByDescending(s => s.CreateDate).ToList();
            return View(lst);
        }
        public ActionResult Cane()
        {
            var lst = db.SM_Product.Where(s => s.ProductTypeID == 11).OrderByDescending(s => s.CreateDate).ToList();
            return View(lst);
        }
        public ActionResult FakeDildo()
        {
            var lst = db.SM_Product.Where(s => s.ProductTypeID == 12).OrderByDescending(s => s.CreateDate).ToList();
            return View(lst);
        }
        public ActionResult BlockDildo()
        {
            var lst = db.SM_Product.Where(s => s.ProductTypeID == 13).OrderByDescending(s => s.CreateDate).ToList();
            return View(lst);
        }
        public ActionResult Strapon()
        {
            var lst = db.SM_Product.Where(s => s.ProductTypeID == 14).OrderByDescending(s => s.CreateDate).ToList();
            return View(lst);
        }
        public ActionResult BallGag()
        {
            var lst = db.SM_Product.Where(s => s.ProductTypeID == 15).OrderByDescending(s => s.CreateDate).ToList();
            return View(lst);
        }
        public ActionResult RungGag()
        {
            var lst = db.SM_Product.Where(s => s.ProductTypeID == 16).OrderByDescending(s => s.CreateDate).ToList();
            return View(lst);
        }
	}
}