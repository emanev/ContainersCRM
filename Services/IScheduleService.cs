﻿using ContainersCRM.ViewModels.Schedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContainersCRM.Services
{
    public interface IScheduleService
    {
        IEnumerable<ScheduleViewModel> GetAll();
    }
}
