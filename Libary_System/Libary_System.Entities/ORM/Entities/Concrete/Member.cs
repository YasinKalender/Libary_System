using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary_System.Entities.ORM.Entities.Concrete
{
    public class Member:BaseEntity
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Mail { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Image { get; set; }

        public string Telephone { get; set; }

        public virtual List<Criminal> Criminal { get; set; }

        public virtual List<ActionStatus> ActionStatus { get; set; }
    }
}
