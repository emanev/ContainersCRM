using System;
using System.Collections.Generic;

namespace ContainersCRM.Models
{
    public partial class ContainerMaterialType
    {
        public ContainerMaterialType()
        {
            Containers = new HashSet<Containers>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Containers> Containers { get; set; }
    }
}
