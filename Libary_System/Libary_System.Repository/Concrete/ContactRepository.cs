using Libary_System.DAL.Context;
using Libary_System.Entities.ORM.Entities.Concrete;
using Libary_System.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary_System.Repository.Concrete
{
    public class ContactRepository : IContactRepository<Contact>
    {

        private readonly ProjectContext projectContext;

        public ContactRepository()
        {
            projectContext = new ProjectContext();
        }



        public void Add(Contact entity)
        {
            projectContext.Contact.Add(entity);
            projectContext.SaveChanges();
        }
    }
}
