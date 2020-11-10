using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContainersCRM.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContainersCRM.Controllers
{
    public class ScheduleController : Controller
    {
        private readonly IScheduleService scheduleService;

        public ScheduleController(IScheduleService scheduleService)
        {
            this.scheduleService = scheduleService;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
