using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mode;
using System.IO;


namespace quanlydoanvien_1.Areas.Admin.Controllers
{
    public class ThongTinDVController : Controller
    {
        // GET: ThongTinDV
        public ActionResult Index()
        {
            ThongtindvModel pm = new ThongtindvModel();
            var model = pm.ListAllDoanvien();
            return View(model);

        }
        public ActionResult Create()
        {
            setViewBag();
            return View();
        }

        // POST: Admin/Category/Create
        [HttpPost]
        public ActionResult Create(doanvien collection)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    byte[] imageData = null;
                    if (Request.Files.Count > 0)
                    {
                        HttpPostedFileBase poImgFile = Request.Files["fileim"];

                        using (var binary = new BinaryReader(poImgFile.InputStream))
                        {
                            imageData = binary.ReadBytes(poImgFile.ContentLength);
                        }
                    }
                    collection.hinhanh = imageData;
                    ThongtindvModel cm = new ThongtindvModel();
                    cm.Insert_Doanvien(collection.madv,
                        collection.hoten, collection.gioitinh, collection.ngaysinh, collection.xa, collection.huyen, collection.dantoc, collection.tongiao, collection.trinhdovh, collection.ngayvaodoan, collection.chidoan, collection.chucvu, collection.namhoc, collection.hinhanh);
                   ;
                }
                setViewBag();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(collection);
            }
        }
        public void setViewBag(string nv = null )
        {
            
            var li = new chi_doan();
            ViewBag.chidoan = new SelectList(li.ListAllchidoan(), "chidoan", "tenchidoan", nv);
           
        }
       
        public ActionResult Edit(string id)
        {
            setViewBag();

            dvtnEntities3 nt = new dvtnEntities3();
            doanvien ct = nt.doanviens.Find(id);
            return View(ct);
        }
        // POST: Admin/Category/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, doanvien collection)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    byte[] imageData = null;
                    if (Request.Files.Count > 0)
                    {
                        HttpPostedFileBase poImgFile = Request.Files["fileium"];

                        using (var binary = new BinaryReader(poImgFile.InputStream))
                        {
                            imageData = binary.ReadBytes(poImgFile.ContentLength);
                        }
                    }
                    collection.hinhanh = imageData;
                    ThongtindvModel cm = new ThongtindvModel();
                    cm.Update_Doanvien(collection.madv,
                        collection.hoten, collection.gioitinh, collection.ngaysinh, collection.xa, collection.huyen, collection.dantoc, collection.tongiao, collection.trinhdovh, collection.ngayvaodoan, collection.chidoan, collection.chucvu, collection.namhoc, collection.hinhanh);
                }
                setViewBag();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(collection);
            }
        }
        public ActionResult Delete(string id)
        {
            return View();
        }

        // POST: Admin/Category/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                ThongtindvModel cm = new ThongtindvModel();
                cm.Deleted_Doanvien(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(collection);
            }
        }
    }
}