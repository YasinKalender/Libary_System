using Libary_System.DAL.Context;
using Libary_System.Entities.ORM.Entities.Concrete;
using Libary_System.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Libary_System.Repository.Concrete
{
    public class AuthorRepsoitory : BaseRepository<Author, ProjectContext>, IAuthorRepository
    {
       
    }
}
