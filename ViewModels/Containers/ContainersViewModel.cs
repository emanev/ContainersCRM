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
        [Display(Name = "Inventar Number")]
        public string InventarNumber { get; set; }
        [EnumDataType(typeof(ContainerColour))]
        [Display(Name = "Colour Type")]
        public ContainerColour ContainerColourType { get; set; }
        [EnumDataType(typeof(ContainerCapacity))]
        [Display(Name = "Capacity Type")]
        public ContainerCapacity ContainerCapacityType { get; set; }
    }
}
