using ContainersCRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContainersCRM.ViewModels.Warehouse
{
    public class WarehouseViewModel
    {        
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [MaxLength(50)]
        public string ContactPerson { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        [MaxLength(50)]
        public string Phone { get; set; }


        // To Do with actual userId and type
        public int UserId { get; set; } = 1;

        // Remove from database
        //public int CityId { get; set; }

        [EnumDataType(typeof(District))]        
        public District DistrictName { get; set; }        
    }
}
