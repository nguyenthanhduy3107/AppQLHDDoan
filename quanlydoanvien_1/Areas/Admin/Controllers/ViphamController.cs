using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mode;

namespace quanlydoanvien_1.Areas.Admin.Controllers
{
    public class ViphamController : Controller
    {
        // GET: Admin/Vipham
        public ActionResult Index()
        {
            vi_pham pm = new vi_pham();
            var model = pm.ListAllvipham();
            return View(model);
        }

        // GET: Admin/Vipham/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Vipham/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Admin/Vipham/Create
        [HttpPost]
        public ActionResult Create(vipham collection)
        {
            try
            {



                if (ModelState.IsValid)
                {
                    vi_pham cm = new vi_pham();
                    cm.Insert_vipham(collection.sobienban,
                        collection.madv,collection.makl,collection.ngaykl);
                    
                }
               
                return RedirectToAction("Index");

            }
            catch
            {
                return View(collection);
            }
        }
        public void setViewBag(string nv = null, string ct = null)
        {
            var la = new ThongtindvModel();
            var li = new ky_luat();
            ViewBag.madv = new SelectList(la.ListAllDoanvien(), "madv", "hoten", nv);
            
            ViewBag.makl = new SelectList(li.ListAllkiluat(), "makl", "htkl", ct);
        }

        // GET: Admin/Vipham/Edit/5
        public ActionResult Edit(string id)
        {
            setViewBag();
            dvtnEntities3 nt = new dvtnEntities3();
            vipham ct = nt.viphams.Find(id);
            return View(ct);

        }

        // POST: Admin/chidoan/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, vipham collection)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {


                    vi_pham cm = new vi_pham();
                    cm.Update_vipham(collection.sobienban,
                        collection.madv,collection.makl, collection.ngaykl);
                }
                setViewBag();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(collection);
            }
        }

        // GET: Admin/Vipham/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Vipham/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
