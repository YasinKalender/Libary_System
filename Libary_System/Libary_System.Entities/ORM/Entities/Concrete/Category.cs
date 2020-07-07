using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary_System.Entities.ORM.Entities.Concrete
{
    public class Category:BaseEntity
    {

        [Required]
        public string CategoryName { get; set; }

        public List<Book> Book { get; set; }

    }
}
