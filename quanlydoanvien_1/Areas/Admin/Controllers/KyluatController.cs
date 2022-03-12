using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mode;

namespace quanlydoanvien_1.Areas.Admin.Controllers
{
    public class KyluatController : Controller
    {
        // GET: Admin/Kyluat
        public ActionResult Index()
        {
            ky_luat pm = new ky_luat();
            var model = pm.ListAllkiluat();
            return View(model);
            
        }

        // GET: Admin/Kyluat/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Kyluat/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Kyluat/Create
        [HttpPost]
        public ActionResult Create(kiluat collection)
        {
            try
            {



                if (ModelState.IsValid)
                {
                    ky_luat cm = new ky_luat();
                    cm.Insert_Kyluat(collection.makl,
                        collection.htkl);
                    return RedirectToAction("Index");
                }
                return View(collection);

            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Kyluat/Edit/5
        public ActionResult Edit(string id)
        {
            dvtnEntities3 nt = new dvtnEntities3();
            kiluat ct = nt.kiluats.Find(id);
            return View(ct);

        }

        // POST: Admin/chidoan/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, kiluat collection)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {


                    ky_luat cm = new ky_luat();
                    cm.Update_Kyluat(collection.makl,
                        collection.htkl);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View(collection);
            }
        }

        // GET: Admin/Kyluat/Delete/5
        public ActionResult Delete(string id)
        {
            return View();
        }

        // POST: Admin/Kyluat/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, kiluat collection)
        {
            try
            {
                // TODO: Add delete logic here
                ky_luat cm = new ky_luat();
                cm.Deleted_kyluat(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(collection);
            }
        }
    }
}