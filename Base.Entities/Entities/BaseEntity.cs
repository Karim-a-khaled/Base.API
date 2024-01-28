using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Entities.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CreatedById { get; set; }
        public DateTime CreationDate { get; set; }

        public int ModifiedById { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}
