using System;
using System.Collections.Generic;

namespace ContainersCRM.Models
{
    public partial class SrsobjectIndustrialSchema
    {
        public int Id { get; set; }
        public int SrsobjectIndustrialId { get; set; }
        public DateTime? EntryDate { get; set; }
        public byte WeekDay { get; set; }
        public byte[] Hour { get; set; }
        public int UserId { get; set; }

        public virtual SrsobjectIndustrial SrsobjectIndustrial { get; set; }
        public virtual User User { get; set; }
    }
}
