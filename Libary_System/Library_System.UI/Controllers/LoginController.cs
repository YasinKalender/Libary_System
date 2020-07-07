using Libary_System.Entities.ORM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Library_System.UI.Controllers
{
    public class LoginController : BaseController
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(Member member)
        {
            var user = memberManager.Info(member.Mail, member.Password);

            if (user!=null)
            {
                FormsAuthentication.SetAuthCookie(user.Mail, false);
                Session["ID"] = user.ID.ToString();
                Session["Mail"] = user.Mail.ToString();
                Session["Ad"] = user.FirstName.ToString();
                Session["Password"] = user.Password.ToString();
                Session["LastName"] = user.LastName.ToString();
                Session["UserName"] = user.Username.ToString();
                Session["Telephone"] = user.Telephone.ToString();
                Session["Image"] = user.Image.ToString();

                return RedirectToAction("Index", "Home");


            }


            return View(member);
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Member member)
        {
            if (ModelState.IsValid)
            {
                memberManager.Add(member);
                return RedirectToAction("Login", "Login");
            }

            return View(member);
        }

        public ActionResult Information()
        {
           

            return View();
        }

        public ActionResult InformationUpdate(int id)
        {


            return View(memberManager.GetByid(id));
        }

        [HttpPost]
        public ActionResult InformationUpdate(Member user)
        {
            if (ModelState.IsValid)
            {
                Session["ID"] = user.ID.ToString();
                Session["Ad"] = user.FirstName.ToString();
                Session["Password"] = user.Password.ToString();
                Session["LastName"] = user.LastName.ToString();
                Session["UserName"] = user.Username.ToString();
                Session["Telephone"] = user.Telephone.ToString();
                Session["Image"] = user.Image.ToString();
                memberManager.Update(user);
                return RedirectToAction("Information", "Login");
            }

            return View(user);
        }

        public ActionResult SignOut(Member member)
        {
            FormsAuthentication.SignOut();
           

            return RedirectToAction("Index", "Home");
        }

       



    }
}