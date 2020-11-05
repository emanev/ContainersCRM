﻿using System;
using System.Collections.Generic;

namespace ContainersCRM.Models
{
    public partial class SrsobjectIndustrial
    {
        public SrsobjectIndustrial()
        {
            Schedule = new HashSet<Schedule>();
            SrsobjectIndustrialContainer = new HashSet<SrsobjectIndustrialContainer>();
            SrsobjectIndustrialSchema = new HashSet<SrsobjectIndustrialSchema>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public string Note { get; set; }
        public DateTime? EntryDate { get; set; }
        public int UserId { get; set; }
        public int DistrictId { get; set; }

        public virtual District District { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Schedule> Schedule { get; set; }
        public virtual ICollection<SrsobjectIndustrialContainer> SrsobjectIndustrialContainer { get; set; }
        public virtual ICollection<SrsobjectIndustrialSchema> SrsobjectIndustrialSchema { get; set; }
    }
}
