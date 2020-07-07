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
    public class ActionStatusManager : IActionStatusService
    {
        ActionStatusRepository actionStatusRepository;

        public ActionStatusManager()
        {
            actionStatusRepository = new ActionStatusRepository();
        }

        public void Add(ActionStatus entity)
        {
            actionStatusRepository.Add(entity);
        }

        public void Delete(ActionStatus entity)
        {
            throw new NotImplementedException();
        }

        public List<ActionStatus> GetAll(Expression<Func<ActionStatus, bool>> expression)
        {
            return actionStatusRepository.GetAll(expression);
        }

        public ActionStatus GetByid(int id)
        {
            return actionStatusRepository.GetByid(id);
        }

        public ActionStatus GetOne(Expression<Func<ActionStatus, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public List<ActionStatus> MemberBookPersonel(Expression<Func<ActionStatus, bool>> expression)
        {
            return actionStatusRepository.MemberBookPersonel(expression).ToList();
        }

        public ActionStatus MemberBookPersonel(int id)
        {
            return actionStatusRepository.MemberBookPersonel(id);
        }

        public void Update(ActionStatus entity)
        {
            actionStatusRepository.Update(entity);
        }
    }
}
