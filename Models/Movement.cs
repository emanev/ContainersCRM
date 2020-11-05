﻿using System;
using System.Collections.Generic;

namespace ContainersCRM.Models
{
    public partial class Movement
    {
        public Movement()
        {
            SrsobjectIndustrialContainer = new HashSet<SrsobjectIndustrialContainer>();
        }

        public int Id { get; set; }
        public int ContainerId { get; set; }
        public int WarehouseToId { get; set; }
        public int WarehouseFromId { get; set; }
        public bool IsLastMovement { get; set; }
        public DateTime? EntryDate { get; set; }
        public int UserId { get; set; }

        public virtual Containers Container { get; set; }
        public virtual User User { get; set; }
        public virtual Warehouse WarehouseFrom { get; set; }
        public virtual Warehouse WarehouseTo { get; set; }
        public virtual ICollection<SrsobjectIndustrialContainer> SrsobjectIndustrialContainer { get; set; }
    }
}
