using Libary_System.Entities.ORM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Libary_System.Repository.Abstract
{
    public interface IMemberRepository:IRepository<Member>
    {
        Member Info(string mail, string pass);

        Member PassBook(Expression<Func<Member,bool>> expression);

    }
}
