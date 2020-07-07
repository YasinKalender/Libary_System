using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Libary_System.Repository.Abstract
{
    public interface IRepository<T>
    {
        List<T> GetAll(Expression<Func<T, bool>> expression);

        T GetOne(Expression<Func<T, bool>> expression);

        T GetByid(int id);

        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);

    }
}
