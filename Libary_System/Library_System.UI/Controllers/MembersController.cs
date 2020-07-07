using Libary_System.Entities.ORM.Entities.Concrete;
using Libary_System.Entities.ORM.Entities.Enum;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library_System.UI.Controllers
{
    public class MembersController : BaseController
    {
        // GET: Members
        public ActionResult Index(string p,int page=1)
        {
            var members = memberManager.GetAll(i => i.Status == Libary_System.Entities.ORM.Entities.Enum.Status.Active || i.Status == Libary_System.Entities.ORM.Entities.Enum.Status.Update).AsQueryable();

            if (!string.IsNullOrEmpty(p))
            {
                members = members.Where(i => i.FirstName.ToLower().Contains(p));
            }


            return View(members.ToList().ToPagedList(page,3));
        }

        public ActionResult MembersAdd()
        {

            return View();
        }

        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult MembersAdd(Member member)
        {

            if (ModelState.IsValid)
            {
                member.AddUser = "Yasin";
                memberManager.Add(member);
                return Redirect("/Members/Index");
            }

            return View(member);
        }

        public ActionResult MembersDelete(int id)
        {
            var members = memberManager.GetByid(id);

            if (members!=null)
            {
                memberManager.Delete(members);
                return Redirect("/Members/Index");
            }


            return View();
        }

        public ActionResult MembersUpdate(int id)
        {


            return View(memberManager.GetByid(id));
        }

        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult MembersUpdate(Member member)
        {
            if (ModelState.IsValid)
            {
                member.UpdateDate = DateTime.Now;
                member.UpdateUser = "Yasin";
                member.Status = Libary_System.Entities.ORM.Entities.Enum.Status.Update;
                memberManager.Update(member);
                return Redirect("/Members/Index");
            }

            return View(member);
        }

        public ActionResult PastBook(int? id)
        {
            var book = actionStatusManager.MemberBookPersonel(i => i.Status == Status.Active).AsQueryable();

            if (id!=null)
            {
                book = book.Where(i => i.BookID == id);
            }


            return View(book.ToList());
        }
    }
}