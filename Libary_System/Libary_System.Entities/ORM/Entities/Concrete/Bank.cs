using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary_System.Entities.ORM.Entities.Concrete
{
    public class Bank:BaseEntity
    {
        public string Month { get; set; }

        public decimal TotalMoney { get; set; }

    }
}
