using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mode;

namespace quanlydoanvien_1.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        
        public ActionResult Index(quanlydoanvien_1.Areas.Admin.Models.Loginmodel model)
        {
            UserModel user = new UserModel();
            var res = user.Check_Login(model.Username, model.Password);
            if (res == true && ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Sai tên đăng nhập hoặc mật khẩu");
            }
            return View(model);
        }
    }
}