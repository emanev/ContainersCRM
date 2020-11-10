//using ContainersCRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static ContainersCRM.ViewModels.Containers.Enums;

namespace ContainersCRM.ViewModels
{
    public class ContainersInputModel
    {
        [Required]
        [MaxLength(50)]
        public string InventarNumber { get; set; }
        [EnumDataType(typeof(ContainerColour))]
        [Display(Name = "Colour Type:")]
        public ContainerColour ContainerColourType { get; set; }
        [EnumDataType(typeof(ContainerCapacity))]
        [Display(Name = "Capacity Type:")]
        public ContainerCapacity ContainerCapacityType { get; set; }
    }    
}
