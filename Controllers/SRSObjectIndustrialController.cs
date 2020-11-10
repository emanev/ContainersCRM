using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContainersCRM.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContainersCRM.Controllers
{
    public class SRSObjectIndustrialController : Controller
    {
        private readonly ISRSObjectIndustrialService srsObjectIndustrialService;

        public SRSObjectIndustrialController(ISRSObjectIndustrialService srsObjectIndustrialService)
        {
            this.srsObjectIndustrialService = srsObjectIndustrialService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
