using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library_System.UI.Controllers
{
    public class StatisticsController : BaseController
    {
        // GET: Statistics
        public ActionResult Index()
        {
            var d1 = memberManager.GetAll(i => i.Status == Libary_System.Entities.ORM.Entities.Enum.Status.Active || i.Status == Libary_System.Entities.ORM.Entities.Enum.Status.Update).Count();
            ViewBag.dgr = d1;

            var d2 = bookManager.GetAll(i => i.Status == Libary_System.Entities.ORM.Entities.Enum.Status.Active || i.Status == Libary_System.Entities.ORM.Entities.Enum.Status.Update).Count();

            ViewBag.dgr1 = d2;

            var d3 = actionStatusManager.MemberBookPersonel(i => i.Status == Libary_System.Entities.ORM.Entities.Enum.Status.Active).Count();

            ViewBag.dgr3 = d3;

            return View();
        }

        public ActionResult Weather()
        {
            return View();
        }

        public ActionResult WeatherCard()
        {
            return View();
        }

        public ActionResult LinqCard()
        {

            var book = bookManager.GetAll(i => i.Status == Libary_System.Entities.ORM.Entities.Enum.Status.Active || i.Status == Libary_System.Entities.ORM.Entities.Enum.Status.Update).Count();

            ViewBag.dgr1 = book;

            var member = memberManager.GetAll(i => i.Status == Libary_System.Entities.ORM.Entities.Enum.Status.Active || i.Status == Libary_System.Entities.ORM.Entities.Enum.Status.Update).Count();
            ViewBag.dgr2 = member;

            var givebook = actionStatusManager.GetAll(i=>i.Status==Libary_System.Entities.ORM.Entities.Enum.Status.Active).Count();

            ViewBag.dgr4 = givebook;

            var category = categoryManager.GetAll(i => i.Status == Libary_System.Entities.ORM.Entities.Enum.Status.Active || i.Status == Libary_System.Entities.ORM.Entities.Enum.Status.Update).Count();

            ViewBag.dgr5 = category;

           




            return View();
        }


    }
}