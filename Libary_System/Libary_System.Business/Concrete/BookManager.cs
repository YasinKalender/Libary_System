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
    public class BookManager : IBookService
    {

        private BookRepository bookRepository = new BookRepository();
        public void Add(Book entity)
        {
            bookRepository.Add(entity);
        }

        public List<Book> BookCategoryAuthor()
        {
            return bookRepository.BookCategoryAuthor();
        }


        public void Delete(Book entity)
        {
            bookRepository.Delete(entity);
        }

        public List<Book> GetAll(Expression<Func<Book, bool>> expression)
        {
            return bookRepository.GetAll(expression).ToList();
        }

        public Book GetByid(int id)
        {
            return bookRepository.GetByid(id);
        }


        public Book GetOne(Expression<Func<Book, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(Book entity)
        {
            bookRepository.Update(entity);
        }
    }
}
