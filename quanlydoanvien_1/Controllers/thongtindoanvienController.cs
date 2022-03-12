using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mode;

namespace quanlydoanvien_1.Controllers
{
    public class thongtindoanvienController : Controller
    {
        // GET: thongtindoanvien
        public ActionResult Index()
        {

            ThongtindvModel pm = new ThongtindvModel();
            var model = pm.ListAllDoanvien();
            return View(model);
           
        }
    }
}