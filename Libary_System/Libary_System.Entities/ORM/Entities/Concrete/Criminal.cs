using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary_System.Entities.ORM.Entities.Concrete
{
    public class Criminal:BaseEntity
    {

        public int MemberID { get; set; }

        public virtual Member Member { get; set; }

        public int ActionActionStatusID { get; set; }

        public virtual ActionStatus ActionStatus { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        public decimal Money { get; set; }
    }
}
