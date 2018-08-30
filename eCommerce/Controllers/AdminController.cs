using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerce.Models;
using PagedList;
using System.IO;

namespace eCommerce.Controllers
{
    public class AdminController : Controller
    {
        DochoiSMEntities db = new DochoiSMEntities();
        //
        // GET: /Admin/
        public ActionResult Index(int? page = 1)
        {
            int pageSize = 7;
            int pageNumber = (page ?? 1);
            var lst = db.SM_Product.ToList();
            return View(lst.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult AddProduct()
        {
            var lst = db.SM_ProductType.ToList();
            return View(lst);
        }
        [HttpPost]
        public ActionResult AddProduct(string ProductName = "", int? Price = 0, string Description="", HttpPostedFileBase Avatar=null, string ProductTypeID="",int? Discount=0)
        {
            string ava = "";
            if (Avatar.ContentLength > 0)
            {
                var filename = Path.GetFileName(Avatar.FileName);
                var path = Path.Combine(Server.MapPath("~/images/avatar"), Avatar.FileName);
                Avatar.SaveAs(path);
                ava = Avatar.FileName;
            }
            int pdtypeid = int.Parse(ProductTypeID);
            DochoiSMEntities db = new DochoiSMEntities();
            var sm = new SM_Product();
            sm.ProductName = ProductName;
            sm.Price = Price;
            sm.Avatar = ava;
            sm.Description = Description;
            sm.CreateDate = DateTime.Now;
            sm.ProductTypeID = pdtypeid;
            sm.Discount = Discount;
            if(Discount != 0)
            {
                sm.IsSale = true;
            }
            else
            {
                sm.IsSale = false;
            }
            db.SM_Product.Add(sm);
            db.SaveChanges();
            return RedirectToAction("Index","Admin");
        }
	}
}