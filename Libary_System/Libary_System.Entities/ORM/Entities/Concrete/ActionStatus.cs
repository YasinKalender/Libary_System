using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary_System.Entities.ORM.Entities.Concrete
{
    public class ActionStatus:BaseEntity
    {

        public DateTime GiveDate { get; set; }

        public DateTime TurnDate { get; set; }

        public DateTime? BookDate { get; set; }

        public int PersonelID { get; set; }

        public virtual Personel Personel { get; set; }

        public int BookID { get; set; }

        public virtual Book Book { get; set; }

        public int MemberID { get; set; }

        public virtual Member Member { get; set; }

        public virtual List<Criminal> Criminal { get; set; }



    }
}
