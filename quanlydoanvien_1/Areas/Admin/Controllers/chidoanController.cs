using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mode;

namespace quanlydoanvien_1.Areas.Admin.Controllers
{
    public class chidoanController : Controller
    {
        // GET: Admin/chidoan
        public ActionResult Index()
        {
            chi_doan pm = new chi_doan();
            var model = pm.ListAllchidoan();
            return View(model);
        
        }

        // GET: Admin/chidoan/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/chidoan/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/chidoan/Create
        [HttpPost]
        public ActionResult Create(chidoan collection)
        {
            try
            {



                if (ModelState.IsValid)
                {
                    chi_doan cm = new chi_doan();
                    cm.Insert_chidoan(collection.chidoan1,
                        collection.tenchidoan);
                    return RedirectToAction("Index");
                }
                return View(collection);

            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/chidoan/Edit/5
        public ActionResult Edit(string id)
        {
            dvtnEntities3 nt = new dvtnEntities3();
            chidoan ct = nt.chidoans.Find(id);
            return View(ct);
            
        }

        // POST: Admin/chidoan/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, chidoan collection)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                   
                   
                    chi_doan cm = new chi_doan();
                    cm.Update_chidoan(collection.chidoan1,
                        collection.tenchidoan);
                }
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View(collection);
            }
        }

        // GET: Admin/chidoan/Delete/5
        public ActionResult Delete(string id)
        {
            dvtnEntities3 nt = new dvtnEntities3();
            chidoan ct = nt.chidoans.Find(id);
            return View(ct);
        }

        // POST: Admin/chidoan/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, chidoan collection)
        {
            try
            {
                // TODO: Add delete logic here
                chi_doan cm = new chi_doan();
                cm.Deleted_chidoan(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(collection);
            }
        }
    }
}
