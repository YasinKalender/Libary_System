using Libary_System.Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library_System.UI.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base

        public CategoryManager categoryManager;
        public AuthorManager authorManager;
        public BookManager bookManager;
        public PersonelManager personelManager;
        public MemberManager memberManager;
        public ActionStatusManager actionStatusManager;
        public ContactManager contactManager;
        public MessageManager messageManager;
        public BaseController()
        {
            categoryManager = new CategoryManager();
            authorManager = new AuthorManager();
            bookManager = new BookManager();
            personelManager = new PersonelManager();
            memberManager = new MemberManager();
            actionStatusManager = new ActionStatusManager();
            contactManager = new ContactManager();
            messageManager = new MessageManager();
        }
       
    }
}