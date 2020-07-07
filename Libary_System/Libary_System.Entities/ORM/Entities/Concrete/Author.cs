using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary_System.Entities.ORM.Entities.Concrete
{
    public class Author:BaseEntity
    {

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual List<Book> Book { get; set; }
    }
}
