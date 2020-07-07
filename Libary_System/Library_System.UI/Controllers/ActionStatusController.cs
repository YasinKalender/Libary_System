using Libary_System.Entities.ORM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library_System.UI.Controllers
{
    public class ActionStatusController : BaseController
    {
        // GET: ActionStatus
        public ActionResult Index()
        {
            return View(actionStatusManager.MemberBookPersonel(i=>i.Status==Libary_System.Entities.ORM.Entities.Enum.Status.Active).ToList());
        }

        public ActionResult TurnIndex()
        {

            return View(actionStatusManager.MemberBookPersonel(i => i.Status == Libary_System.Entities.ORM.Entities.Enum.Status.Passive).ToList());
        }

        public ActionResult GiveToBook()
        {
            

            return View();
        }

        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult GiveToBook(ActionStatus actionStatus)
        {

            
            if (ModelState.IsValid)
            {
                
                actionStatusManager.Add(actionStatus);
                return RedirectToAction("Index", "ActionStatus");
            }

            return View(actionStatus);
        }

        public ActionResult TurnBook(int id,ActionStatus actionStatus)
        {
            var book = actionStatusManager.MemberBookPersonel(id);
            DateTime d1 = DateTime.Parse(book.TurnDate.ToString());
            DateTime d2 = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            TimeSpan d3 = (d2 - d1);
            ViewBag.dgr = d3.TotalDays;

            return View(book);
        }

        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult TurnBook(ActionStatus actionStatus)
        {

        


            if (ModelState.IsValid)
            {
                
                actionStatus.Status = Libary_System.Entities.ORM.Entities.Enum.Status.Passive;
                actionStatusManager.Update(actionStatus);
                return RedirectToAction("Index", "ActionStatus");
            }

            return View();
        }
    }
}