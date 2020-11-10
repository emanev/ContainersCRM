using ContainersCRM.ViewModels.Warehouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContainersCRM.Services
{
    public interface IWarehouseService
    {
        void Create(WarehouseViewModel model);

        IEnumerable<WarehouseViewModel> GetAll();
    }
}
