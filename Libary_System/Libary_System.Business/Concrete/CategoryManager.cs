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
    public class CategoryManager : ICategoryService
    {

        CategoryRepository categoryRepository = new CategoryRepository();

        public void Add(Category entity)
        {
            categoryRepository.Add(entity);
        }

        public void Delete(Category entity)
        {
            categoryRepository.Delete(entity);
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> expression)
        {
            return categoryRepository.GetAll(expression).ToList();
        }

        public Category GetByid(int id)
        {
            return categoryRepository.GetByid(id);
        }

        public Category GetOne(Expression<Func<Category, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            categoryRepository.Update(entity);
        }
    }
}
