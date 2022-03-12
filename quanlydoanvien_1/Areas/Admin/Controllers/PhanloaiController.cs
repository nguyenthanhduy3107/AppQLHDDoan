using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mode;

namespace quanlydoanvien_1.Areas.Admin.Controllers
{
    public class PhanloaiController : Controller
    {
        // GET: Admin/Phanloai
        public ActionResult Index()
        {
            Phan_loai pm = new Phan_loai();
            var model = pm.ListAllphanloai();
            return View(model);
        }

        // GET: Admin/Phanloai/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Phanloai/Create
        public ActionResult Create()
        {
            setViewBag();
            return View();
        }

        // POST: Admin/Phanloai/Create
        [HttpPost]
        public ActionResult Create(phanloai collection)
        {
            try
            {



                if (ModelState.IsValid)
                {
                    Phan_loai cm = new Phan_loai();
                    cm.Insert_phanloai(collection.STT,collection.madv,collection.diem,collection.uudiem,collection.khuyetdiem,collection.khenthuong);
                    
                }
                setViewBag();
                return RedirectToAction("Index");

            }
            catch
            {
                return View(collection);
            }
        }
        public void setViewBag(string nv = null)
        {

            var li = new ThongtindvModel();
            ViewBag.madv = new SelectList(li.ListAllDoanvien(), "madv", "hoten", nv);

        }
        // GET: Admin/Phanloai/Edit/5
        public ActionResult Edit(string id)
        {
            setViewBag();
            dvtnEntities3 nt = new dvtnEntities3();
        phanloai ct = nt.phanloais.Find(id);
            return View(ct);

    }

        // POST: Admin/chidoan/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, phanloai collection)
    {
        try
        {
            // TODO: Add update logic here
            if (ModelState.IsValid)
            {


                Phan_loai cm = new Phan_loai();
                cm.Update_Phanloai(collection.STT,collection.madv,collection.diem,collection.uudiem,collection.khuyetdiem,collection.khenthuong);
            }
                setViewBag();
            return RedirectToAction("Index");
        }
        catch
        {
            return View(collection);
        }
    }

    // GET: Admin/Phanloai/Delete/5
    public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Phanloai/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, phanloai collection)
        {

            try
            {
                // TODO: Add delete logic here
                Phan_loai cm = new Phan_loai();
                cm.Deleted_phanloai(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(collection);
            }
        }
    }
}
