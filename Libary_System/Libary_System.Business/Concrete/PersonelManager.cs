using Libary_System.Business.Abstract;
using Libary_System.Entities.ORM.Entities.Concrete;
using Libary_System.Repository.Abstract;
using Libary_System.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Libary_System.Business.Concrete
{
    public class PersonelManager : IPersonelService
    {
        private PersonelRepsoitory personelRepsoitory;

        public PersonelManager()
        {
            personelRepsoitory = new PersonelRepsoitory();
        }

       

        public void Add(Personel entity)
        {
            personelRepsoitory.Add(entity);
        }

        public void Delete(Personel entity)
        {
            personelRepsoitory.Delete(entity);
        }

        public List<Personel> GetAll(Expression<Func<Personel, bool>> expression)
        {
            return personelRepsoitory.GetAll(expression).ToList();
        }

        public Personel GetByid(int id)
        {
           return personelRepsoitory.GetByid(id);
        }

        public Personel GetOne(Expression<Func<Personel, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(Personel entity)
        {
            personelRepsoitory.Update(entity);
        }
    }
}
