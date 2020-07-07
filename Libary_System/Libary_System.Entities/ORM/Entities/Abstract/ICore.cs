using Libary_System.Entities.ORM.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary_System.Entities.ORM.Entities.Abstract
{
    public interface ICore
    {
        int ID { get; set; }

        DateTime AddDate { get; set;}

        DateTime? DeleteDate { get; set; }

        DateTime? UpdateDate { get; set; }

        Status Status { get; set; }

        string AddUser { get; set; }

        string UpdateUser { get; set; }

        string DeleteUser { get; set; }

    }
}
