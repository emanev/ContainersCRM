using System;
using System.Collections.Generic;

namespace ContainersCRM.Models
{
    public partial class ObjectTypes
    {
        public ObjectTypes()
        {
            Schedule = new HashSet<Schedule>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Schedule> Schedule { get; set; }
    }
}
