using Libary_System.DAL.Context;
using Libary_System.Entities.ORM.Entities.Concrete;
using Libary_System.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Libary_System.Repository.Concrete
{
    public class ActionStatusRepository : BaseRepository<ActionStatus, ProjectContext>, IActionStatus
    {
        public List<ActionStatus> MemberBookPersonel(Expression<Func<ActionStatus, bool>> expression)
        {
            using(var context = new ProjectContext())
            {
                var action = context.ActionStatus.Where(expression).AsQueryable();

                action = action.Include(i => i.Book).Include(i => i.Member).Include(i => i.Personel);

                return action.ToList();



            }
        }

        public ActionStatus MemberBookPersonel(int id)
        {
            using (var context = new ProjectContext())
            {
                var action = context.ActionStatus.AsQueryable();

                 action = action.Include(i => i.Book).Include(i => i.Member).Include(i => i.Personel);

                return action.FirstOrDefault(i=>i.ID==id);

                



            }
        }

       
    }
}
