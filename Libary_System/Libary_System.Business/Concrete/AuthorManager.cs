using Libary_System.Business.Abstract;
using Libary_System.Entities.ORM.Entities.Concrete;
using Libary_System.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Libary_System.Business.Concrete
{
    public class AuthorManager : IAuthorService
    {

        AuthorRepsoitory authorRepsoitory = new AuthorRepsoitory();
        public void Add(Author entity)
        {
            authorRepsoitory.Add(entity);
        }

        public void Delete(Author entity)
        {
            authorRepsoitory.Delete(entity);
        }

        public List<Author> GetAll(Expression<Func<Author, bool>> expression)
        {
            return authorRepsoitory.GetAll(expression).ToList();
        }

        public Author GetByid(int id)
        {
            return authorRepsoitory.GetByid(id);
        }

        public Author GetOne(Expression<Func<Author, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(Author entity)
        {
            authorRepsoitory.Update(entity);
        }
    }
}
