using System;
using System.Collections.Generic;

namespace ContainersCRM.Models
{
    public partial class SrsobjectIndustrialContainer
    {
        public int Id { get; set; }
        public int SrsobjectIndustrialId { get; set; }
        public int ContainerId { get; set; }
        public int MovementId { get; set; }
        public int UserId { get; set; }

        public virtual Containers Container { get; set; }
        public virtual Movement Movement { get; set; }
        public virtual SrsobjectIndustrial SrsobjectIndustrial { get; set; }
        public virtual User User { get; set; }
    }
}
