using Libary_System.DAL.Context;
using Libary_System.Entities.ORM.Entities.Concrete;
using Libary_System.Repository.Abstract;
using PagedList;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Libary_System.Repository.Concrete
{
    public class BookRepository : BaseRepository<Book, ProjectContext>, IBookRepository
    {
        

        public List<Book> BookCategoryAuthor()
        {
            using(var context = new ProjectContext())
            {

                var book = context.Book.AsQueryable();

                book = book.Include(i => i.Category).Include(i => i.Author);

                return book.ToList();


            }
        }

       
    }
}
