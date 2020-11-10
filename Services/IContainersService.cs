using ContainersCRM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContainersCRM.Services
{
    public interface IContainersService
    {
        void Create(ContainersInputModel model);

        IEnumerable<ContainersViewModel> GetAll();
    }
}
