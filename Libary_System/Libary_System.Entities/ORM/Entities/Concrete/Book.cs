using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary_System.Entities.ORM.Entities.Concrete
{
    public class Book:BaseEntity
    {
        public string BookName { get; set; }

        public string Publication_Year { get; set; }

        public string Publisher { get; set; }

        public string Image { get; set; }

        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public int AuthorID { get; set; }

        public virtual Author Author { get; set; }
        public virtual List<ActionStatus> ActionStatus { get; set; }

    }
}
