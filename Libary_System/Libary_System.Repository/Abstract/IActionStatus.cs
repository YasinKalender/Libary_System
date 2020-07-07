using Libary_System.Entities.ORM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Libary_System.Repository.Abstract
{
    public interface IActionStatus:IRepository<ActionStatus>
    {
        List<ActionStatus> MemberBookPersonel(Expression<Func<ActionStatus,bool>>expression);

        ActionStatus MemberBookPersonel(int id);

    }
}
