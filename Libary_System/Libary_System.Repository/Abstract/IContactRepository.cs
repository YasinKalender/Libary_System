using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary_System.Repository.Abstract
{
    public interface IContactRepository<T>
    {

        void Add(T entity);

    }
}
