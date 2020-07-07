using Libary_System.Entities.ORM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library_System.UI.Controllers
{
    public class CategoryController : BaseController
    {
        // GET: Category
        public ActionResult Index(string p)
        {
            var category =categoryManager.GetAll(i => i.Status == Libary_System.Entities.ORM.Entities.Enum.Status.Active || i.Status == Libary_System.Entities.ORM.Entities.Enum.Status.Update).AsQueryable();

            if (!string.IsNullOrEmpty(p))
            {
                category = category.Where(i => i.CategoryName.Contains(p));
            }

            return View(category.ToList());
        }

        public ActionResult CategoryAdd()
        {


            return View();
        }


        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult CategoryAdd(Category category)
        {

            if (ModelState.IsValid)
            {
                category.AddUser = "Yasin";
                categoryManager.Add(category);
                return Redirect("Index");
            }


            return View(category);
        }



        public ActionResult Delete(int id)
        {
            var category = categoryManager.GetByid(id);

            if (category!=null)
            {
                categoryManager.Delete(category);
                return RedirectToAction("Index", "Category");
            }

            return View();
        }

        public ActionResult Update(int id)
        {
            var category = categoryManager.GetByid(id);

            return View(category);
        }


        [ValidateAntiForgeryToken,HttpPost]
        public ActionResult Update(Category category)
        {
            if (ModelState.IsValid)
            {

                category.UpdateDate = DateTime.Now;
                category.UpdateUser = "Yasin";
                category.Status = Libary_System.Entities.ORM.Entities.Enum.Status.Update;
                categoryManager.Update(category);
                return RedirectToAction("Index", "Category");

            }


            return View(category);
        }

    }
}