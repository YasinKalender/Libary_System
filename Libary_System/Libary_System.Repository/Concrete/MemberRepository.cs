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
    public class MemberRepository : BaseRepository<Member, ProjectContext>, IMemberRepository
    {
        public Member Info(string mail, string pass)
        {
            using(var context = new ProjectContext())
            {

                var user = context.Member.FirstOrDefault(i => i.Mail == mail && i.Password == pass);

                return user;

            }
        }

        public Member PassBook(Expression<Func<Member, bool>> expression)
        {
            using (var context = new ProjectContext())
            {

                var members = context.Member.Where(expression).FirstOrDefault();

                return members;

            }
        }
    }
}
