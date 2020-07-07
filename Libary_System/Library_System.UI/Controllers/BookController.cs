using Libary_System.Entities.ORM.Entities.Concrete;
using PagedList;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library_System.UI.Controllers
{
    public class BookController : BaseController
    {
        // GET: Book
        public ActionResult Index(string p,int page=1)
        {
            var book = bookManager.BookCategoryAuthor().AsQueryable();

            if (!string.IsNullOrEmpty(p))
            {
                book = book.Where(i => i.BookName.Contains(p));
            }

            return View(book.ToList().ToPagedList(page,3));
        }


        [HttpGet]
        public ActionResult BookAdd()
        {
            List<SelectListItem> category = categoryManager.GetAll(i => i.Status == Libary_System.Entities.ORM.Entities.Enum.Status.Active || i.Status == Libary_System.Entities.ORM.Entities.Enum.Status.Update).Select(i => new SelectListItem { Text = i.CategoryName, Value = i.ID.ToString() }).ToList();

            ViewBag.category = category;

            List<SelectListItem> author = authorManager.GetAll(i => i.Status == Libary_System.Entities.ORM.Entities.Enum.Status.Active || i.Status == Libary_System.Entities.ORM.Entities.Enum.Status.Update).Select(i => new SelectListItem { Text = i.FirstName, Value = i.ID.ToString() }).ToList();


            ViewBag.author = author;

            return View();
        }


        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult BookAdd(Book book,HttpPostedFileBase file)
        {

            if (file!=null)
            {
                book.Image = file.FileName;
                var filename = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Image/" + filename));

                file.SaveAs(path);
            }

            if (ModelState.IsValid)
            {
                book.AddUser = "Yasin";
                bookManager.Add(book);

                return Redirect("/Book/Index");
            }

            return View(book);
        }

        public ActionResult BookDelete(int id)
        {

            var book = bookManager.GetByid(id);

            if (book != null)
            {
                bookManager.Delete(book);
                return Redirect("/Book/Index");
            }

            return View();

        }


        public ActionResult BookEdit(int id)
        {
            var book = bookManager.GetByid(id);

            List<SelectListItem> category = categoryManager.GetAll(i => i.Status == Libary_System.Entities.ORM.Entities.Enum.Status.Active || i.Status == Libary_System.Entities.ORM.Entities.Enum.Status.Update).Select(i => new SelectListItem { Text = i.CategoryName, Value = i.ID.ToString() }).ToList();

            ViewBag.category = category;

            List<SelectListItem> author = authorManager.GetAll(i => i.Status == Libary_System.Entities.ORM.Entities.Enum.Status.Active || i.Status == Libary_System.Entities.ORM.Entities.Enum.Status.Update).Select(i => new SelectListItem { Text = i.FirstName, Value = i.ID.ToString() }).ToList();

            ViewBag.author = author;

            return View(book);
        }

        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult BookEdit(Book book)
        {
            if (ModelState.IsValid)
            {
                book.UpdateDate = DateTime.Now;
                book.Status = Libary_System.Entities.ORM.Entities.Enum.Status.Update;
                bookManager.Update(book);
                return Redirect("/Book/Index");
            }


            return View(book);
        }
    }
}