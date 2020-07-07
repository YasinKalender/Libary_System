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
    public class BaseRepository<T, TContext> : IRepository<T> where T : class where TContext : DbContext, new()
    {
        public void Add(T entity)
        {
            using(var context = new TContext())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();


            }
        }

        public void Delete(T entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();


            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> expression)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().Where(expression).ToList();


            }
        }

        public T GetByid(int id)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().Find(id);


            }
        }

        public T GetOne(Expression<Func<T, bool>> expression)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().FirstOrDefault(expression);


            }
        }

        public void Update(T entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();


            }
        }
    }
}
