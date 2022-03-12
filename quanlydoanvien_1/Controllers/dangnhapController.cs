using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mode;
namespace quanlydoanvien_1.Controllers
{
    public class dangnhapController : Controller
    {
        // GET: dangnhap
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(quanlydoanvien_1.Models.loginngoai model)
        {
            UserModel user = new UserModel();
            var res = user.Check_Login(model.Username, model.Password);
            if (res == true && ModelState.IsValid)
            {
                return RedirectToAction("Index", "Trangchu");
            }
            else
            {
                ModelState.AddModelError("Test", "Sai tên đăng nhập hoặc mật khẩu");
            }
            return View(model);
        }
    }
}