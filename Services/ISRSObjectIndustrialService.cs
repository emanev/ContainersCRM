using ContainersCRM.ViewModels.SRSObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContainersCRM.Services
{
    public interface ISRSObjectIndustrialService
    {
        IEnumerable<SRSObjectIndustrialViewModel> GetAll();
    }
}
