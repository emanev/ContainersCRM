using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ContainersCRM.Controllers
{
    public class ContainersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //[HttpPost("Containers/AddContainer")]
        //public IActionResult AddContainer()
        //{
        //    return View();
        //}

    }
}
