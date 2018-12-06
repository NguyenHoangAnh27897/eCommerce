using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerce.Models;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;

namespace eCommerce.Controllers
{
    public class CheckoutController : Controller
    {
        DochoiSMEntities db = new DochoiSMEntities();
        //
        // GET: /Checkout/
        public ActionResult Cart()
        {
            string session = Session["OrderSession"].ToString();
            var lst = db.SM_Order.Where(s => s.SessionOrder == session).ToList();
            return View(lst);
        }

        [HttpPost]
        public ActionResult AddtoCart(string item_name_1, int? amount_1,int? quantity_1,int? discount_amount_1, string item_name_2, int? amount_2, int? quantity_2, int? discount_amount_2, string item_name_3, int? amount_3, int? quantity_3, int? discount_amount_3, string item_name_4, int? amount_4, int? quantity_4, int? discount_amount_4, string item_name_5, int? amount_5, int? quantity_5, int? discount_amount_5)
        {
            string session = DateTime.Now.ToString("yyyyMMddHHmmss");
            Session["OrderSession"] = session;
            if(item_name_1 != null)
            {
                SM_Order order = new SM_Order();
                order.PrductName = item_name_1;
                order.Price = amount_1;
                order.Quantity = quantity_1;
                string avatar;
                avatar = db.SM_Product.Where(s => s.ProductName == item_name_1).FirstOrDefault().Avatar;
                order.Avatar = avatar;
                order.SessionOrder = session;
                order.Discount = discount_amount_1;
                db.SM_Order.Add(order);
                db.SaveChanges();
            }
            if (item_name_2 != null)
            {
                SM_Order order = new SM_Order();
                order.PrductName = item_name_2;
                order.Price = amount_2;
                order.Quantity = quantity_2;
                string avatar;
                avatar = db.SM_Product.Where(s => s.ProductName == item_name_2).FirstOrDefault().Avatar;
                order.Avatar = avatar;
                order.SessionOrder = session;
                order.Discount = discount_amount_2;
                db.SM_Order.Add(order);
                db.SaveChanges();
            }
            if (item_name_3 != null)
            {
                SM_Order order = new SM_Order();
                order.PrductName = item_name_3;
                order.Price = amount_3;
                order.Quantity = quantity_3;
                string avatar;
                avatar = db.SM_Product.Where(s => s.ProductName == item_name_3).FirstOrDefault().Avatar;
                order.Avatar = avatar;
                order.SessionOrder = session;
                order.Discount = discount_amount_3;
                db.SM_Order.Add(order);
                db.SaveChanges();
            }
            if (item_name_4 != null)
            {
                SM_Order order = new SM_Order();
                order.PrductName = item_name_4;
                order.Price = amount_4;
                order.Quantity = quantity_4;
                string avatar;
                avatar = db.SM_Product.Where(s => s.ProductName == item_name_4).FirstOrDefault().Avatar;
                order.Avatar = avatar;
                order.SessionOrder = session;
                order.Discount = discount_amount_4;
                db.SM_Order.Add(order);
                db.SaveChanges();
            }
            if (item_name_5 != null)
            {
                SM_Order order = new SM_Order();
                order.PrductName = item_name_5;
                order.Price = amount_5;
                order.Quantity = quantity_5;
                string avatar;
                avatar = db.SM_Product.Where(s => s.ProductName == item_name_5).FirstOrDefault().Avatar;
                order.Avatar = avatar;
                order.SessionOrder = session;
                order.Discount = discount_amount_5;
                db.SM_Order.Add(order);
                db.SaveChanges();
            }

            return RedirectToAction("Cart","Checkout");
        }

        public ActionResult Payment()
        {
            string session = Session["OrderSession"].ToString();
            var lst = db.SM_Order.Where(s => s.SessionOrder == session).ToList();
           
            return View(lst);
        }
        [HttpGet]
        public async Task<ActionResult> SendEmail(string name, string email, string phone, string address, string district, string city, string gridRadios, string tp)
        {
            string session = Session["OrderSession"].ToString();
            var lst = db.SM_Order.Where(s => s.SessionOrder == session).ToList();
            string product = "";
            foreach(var item in lst)
            {
                product +="<br> Tên sản phẩm: "+ item.PrductName + ", Số lượng: "+item.Quantity + ", Giá: "+item.Price;
            }
            var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
            var message = new MailMessage();
            message.To.Add(new MailAddress("hoanganh27897@gmail.com"));  // replace with valid value 
            message.From = new MailAddress("smdochoi@gmail.com");  // replace with valid value
            message.Subject = "Đơn hàng mới được cập nhật";
            string payment = "";
            if(gridRadios == "option1")
            {
                payment = "Thanh toán khi nhận hàng";
            }else if (gridRadios == "option2")
            {
                payment = "Ship tốc hành bằng LalaMove";
            }else if(gridRadios == "option3")
            {
                payment = "Chuyển khoản trước";
            }else if(gridRadios == "option4")
            {
                payment = "Khu vực 1";
            }else if(gridRadios == "option5")
            {
                payment = "Khu vực 2";
            }else if (gridRadios == "option6")
            {
                payment = "Khu vực 3";
            }

            if (tp == "city1")
            {
               
            }

            message.Body = string.Format(body, "Đồ chơi SM", "smdochoi@gmail.com", @"Thông tin đơn hàng: "+"<br>" +" Tên khách hàng: " + name+ "<br> Số điện thoại: " + phone+ "<br> Địa chỉ Email: " + email+ "<br> Địa chỉ nhận hàng: " + address+ "<br> Quận: " + district+ "<br> Thành phố: " + city +"<br> Hình thức thanh toán: "+payment+"<br>+ Thông tin giỏ hàng: "+product);
            message.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "smdochoi@gmail.com",  // replace with valid value
                    Password = "Dochoism1997"  // replace with valid value
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                await smtp.SendMailAsync(message);
                Session["OrderSession"] = null;
                return RedirectToAction("Index", "Home");
            }   
        }
	}
}