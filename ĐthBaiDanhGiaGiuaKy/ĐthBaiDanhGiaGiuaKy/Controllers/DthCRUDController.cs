using ĐthBaiDanhGiaGiuaKy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ĐthBaiDanhGiaGiuaKy.Controllers
{
    public class DthCRUDController : Controller
    {

        private static List<ĐthProduct> đthProducts = new List<ĐthProduct>
        {
            new ĐthProduct (){ĐthID=029,ĐthName="Đỗ Trọng Huy",ĐthImage="12345543523fdsgfda", ĐthQuanlity=60,ĐthPrice=1000,DdthIssActive=true},
            new ĐthProduct (){ĐthID=1,ĐthName="Đỗ Trọng Chính",ĐthImage="123534245543523fdsgfda", ĐthQuanlity=70,ĐthPrice=2000,DdthIssActive=true}
        };


        // GET: DthCRUD
        public ActionResult DthIndex()
        {
            return View(đthProducts);
        }
        public ActionResult DthCreate()
        {
            var dthModel = new ĐthProduct();
            return View(dthModel);
        }
        public ActionResult DthEdit(int id)
        {
            var product = đthProducts.Find(p => p.ĐthID == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
        [HttpPost]
        public ActionResult DthCreate(ĐthProduct dthProduct)
        {
            if (!ModelState.IsValid)
            {
                return View(dthProduct);
            }
            đthProducts.Add(dthProduct);
            return RedirectToAction("DthIndex");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DthEdit(ĐthProduct dthProduct)
        {
            if (!ModelState.IsValid)
            {
                return View(dthProduct);
            }

            var product = đthProducts.Find(p => p.ĐthID == dthProduct.ĐthID);
            if (product == null)
            {
                return HttpNotFound();
            }

            // Cập nhật các giá trị
            product.ĐthName = dthProduct.ĐthName;
            product.ĐthImage = dthProduct.ĐthImage;
            product.ĐthQuanlity = dthProduct.ĐthQuanlity;
            product.ĐthPrice = dthProduct.ĐthPrice;

            return RedirectToAction("DthIndex");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DthDelete(int id)
        {
            var product = đthProducts.FirstOrDefault(p => p.ĐthID == id);
            if (product == null)
            {
                return HttpNotFound();
            }

            đthProducts.Remove(product);

            return RedirectToAction("DthIndex");
        }

    }
}