using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContainersCRM.Services;
using ContainersCRM.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ContainersCRM.Controllers
{
    public class ContainersController : Controller
    {
        private readonly IContainersService containersService;

        public ContainersController(IContainersService containersService)
        {
            this.containersService = containersService;
        }

        public IActionResult All()
        {


            return View();
        }

        [HttpPost]
        public IActionResult Add(ContainersInputModel model)
        {
            if (!ModelState.IsValid)
            {
                //TODO: return error
            }

            this.containersService.Create(model);
            return this.RedirectToAction("All");

            //return View("Add", model);
        }
    }
}
