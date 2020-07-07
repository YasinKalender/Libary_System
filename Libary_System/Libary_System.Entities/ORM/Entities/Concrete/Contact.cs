using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary_System.Entities.ORM.Entities.Concrete
{
    public class Contact : BaseEntity
    {

        public string FLName { get; set; }

        public string Email { get; set; }

        public string Telephone { get; set; }

        public string Message { get; set; }


    }
}
