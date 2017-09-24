using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBW.Entities
{
    public class EntityBase
    {
        public EntityBase()
        {
            Status = 1;
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }
        public int ID { get; set; }

        public int Status { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
    }
}
