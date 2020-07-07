using Libary_System.Entities.ORM.Entities.Concrete;
using Libary_System.Repository.Abstract;
using Libary_System.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary_System.Business.Concrete
{
    public class ContactManager : IContactRepository<Contact>
    {
        ContactRepository contactRepository = new ContactRepository();

        public void Add(Contact entity)
        {
            contactRepository.Add(entity);
        }
    }
}
