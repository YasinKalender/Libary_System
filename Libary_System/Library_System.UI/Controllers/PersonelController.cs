using Libary_System.Entities.ORM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library_System.UI.Controllers
{
    public class PersonelController : BaseController
    {
        // GET: Personel
        public ActionResult Index()
        {
            return View(personelManager.GetAll(i=>i.Status==Libary_System.Entities.ORM.Entities.Enum.Status.Active || i.Status==Libary_System.Entities.ORM.Entities.Enum.Status.Update).ToList());
        }

        public ActionResult PersonelAdd()
        {

            return View();
        }


        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult PersonelAdd(Personel personel)
        {

            if (ModelState.IsValid)
            {
                personel.AddUser = "Yasin";
                personelManager.Add(personel);
                return Redirect("/Personel/Index");
            }

            return View(personel);
        }

        public ActionResult PersonelDelete(int id)
        {
            var personel = personelManager.GetByid(id);

            if (personel!=null)
            {
                personelManager.Delete(personel);
                return Redirect("/Personel/Index");
            }

            return View();
        }

        public ActionResult PersonelEdit(int id)
        {

            

            return View(personelManager.GetByid(id));
        }

        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult PersonelEdit(Personel personel)
        {

            if (ModelState.IsValid)
            {
                personel.UpdateDate = DateTime.Now;
                personel.UpdateUser = "Yasin";
                personel.Status = Libary_System.Entities.ORM.Entities.Enum.Status.Update;
                personelManager.Update(personel);
                return Redirect("/Personel/Index");
            }

            return View(personel);
        }
    }
}