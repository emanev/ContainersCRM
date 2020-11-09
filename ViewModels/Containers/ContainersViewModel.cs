using ContainersCRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContainersCRM.ViewModels
{
    public class ContainersViewModel
    {
        [Required]
        [MaxLength(50)]
        public string InventarNumber { get; set; }
        [EnumDataType(typeof(ContainerColour))]
        public ContainerColour ContainerColourType { get; set; }
        [EnumDataType(typeof(ContainerCapacity))]
        public ContainerCapacity ContainerCapacityType { get; set; }
    }
}
