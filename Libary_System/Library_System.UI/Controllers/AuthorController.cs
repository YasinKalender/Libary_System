using Libary_System.Entities.ORM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library_System.UI.Controllers
{
    public class AuthorController : BaseController
    {
        // GET: Author
        public ActionResult Index()
        {
            return View(authorManager.GetAll(i=>i.Status==Libary_System.Entities.ORM.Entities.Enum.Status.Active || i.Status==Libary_System.Entities.ORM.Entities.Enum.Status.Update).ToList());
        }

        public ActionResult AuthorAdd()
        {


            return View();
        }


        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult AuthorAdd(Author author)
        {
            if (ModelState.IsValid)
            {
                author.AddUser = "Yasin";
                authorManager.Add(author);
                return RedirectToAction("Index", "Author");
            }

            return View(author);
        }

        public ActionResult Delete(int id)
        {

            var author = authorManager.GetByid(id);

            if (author!=null)
            {
                authorManager.Delete(author);
                return RedirectToAction("Index", "Author");

            }

            return View();


        }

        public ActionResult Update(int id)
        {
            var author = authorManager.GetByid(id);

            return View(author);
        }


        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Update(Author author)
        {
            if (ModelState.IsValid)
            {
                author.UpdateDate = DateTime.Now;
                author.UpdateUser = "Yasin";
                author.Status = Libary_System.Entities.ORM.Entities.Enum.Status.Update;
                authorManager.Update(author);
                return RedirectToAction("Index", "Author");
            }

            return View(author);
        }

        public ActionResult AuthorBook(int? id)
        {

            var book = bookManager.BookCategoryAuthor().AsQueryable();
            if (id!=null)
            {
                book = book.Where(i => i.AuthorID == id);
            }


            return View(book.ToList());
        }
    }
}