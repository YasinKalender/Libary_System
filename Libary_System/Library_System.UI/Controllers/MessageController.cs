using Libary_System.Entities.ORM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library_System.UI.Controllers
{
    public class MessageController : BaseController
    {
        // GET: Message
        public ActionResult Index()
        {

            var mail = (string)Session["Mail"].ToString();

            return View(messageManager.GetAll(i=>i.Alici==mail.ToString()).ToList());
        }

        public ActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewMessage(Message message)
        {

        

            if (ModelState.IsValid)
            {
                var gönderen = (string)Session["Mail"].ToString();
                message.Gönderen = gönderen;
                message.Date = DateTime.Now;
                messageManager.Add(message);
                return RedirectToAction("Index", "Message");
            }

            return View(message);
        }

        public ActionResult SubMessage(Message message)
        {
            var üye = (string)Session["Mail"].ToString();


            return View(messageManager.GetAll(i => i.Gönderen == üye.ToString()).ToList());
        }

       
    }
}