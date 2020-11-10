using ContainersCRM.Data;
using ContainersCRM.Models;
using ContainersCRM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContainersCRM.Services
{
    public class ContainersService : IContainersService
    {
        private readonly ContainersCRMContext db;

        public ContainersService(ContainersCRMContext db)
        {
            this.db = db;
        }

        public void Create(ContainersInputModel input)
        {
            var container = new Containers
            {                
                ContainerCapacityId = (int)input.ContainerCapacityType,
                //BrandingPolicy = (CompanyBranding)x.BrandingStateId,
                ContainerColourId = (int)input.ContainerColourType,
                InventarNumber = input.InventarNumber
            };           

            this.db.Containers.Add(container);
            this.db.SaveChanges();
        }

        public IEnumerable<ContainersViewModel> GetAll()
        {
            var containers = this.db.Containers.Select(x => new ContainersViewModel
            {
                InventarNumber = x.InventarNumber,
                ContainerCapacityType = x.ContainerCapacity,
                ContainerColourType = x.ContainerColour
            }).ToList();

            return containers;
        }
    }
}
