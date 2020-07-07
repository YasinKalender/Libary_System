using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary_System.Entities.ORM.Entities.Concrete
{
    public class Message:BaseEntity
    {

        public string Gönderen { get; set; }

        public string Alici { get; set; }

        public string Konu { get; set; }

        public string Icerik { get; set; }

        public DateTime Date { get; set; }

    }
}
