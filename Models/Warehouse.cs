﻿using System;
using System.Collections.Generic;

namespace ContainersCRM.Models
{
    public partial class Warehouse
    {
        public Warehouse()
        {
            MovementWarehouseFrom = new HashSet<Movement>();
            MovementWarehouseTo = new HashSet<Movement>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int UserId { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }

        public virtual City City { get; set; }
        public virtual District District { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Movement> MovementWarehouseFrom { get; set; }
        public virtual ICollection<Movement> MovementWarehouseTo { get; set; }
    }
}
