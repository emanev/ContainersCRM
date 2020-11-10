using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContainersCRM.Services;
using ContainersCRM.ViewModels.Warehouse;
using Microsoft.AspNetCore.Mvc;

namespace ContainersCRM.Controllers
{
    public class WarehouseController : Controller
    {
        private readonly IWarehouseService warehouseService;

        public WarehouseController(WarehouseService warehouseService)
        {
            this.warehouseService = warehouseService;
        }


        public IActionResult All()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(WarehouseViewModel model)
        {
            if (!ModelState.IsValid)
            {
                //TODO: return error
            }

            return View("Add", model);
        }

        [HttpPut]
        public IActionResult Details(WarehouseViewModel model)
        {
            if (!ModelState.IsValid)
            {
                //TODO: return error
            }

            return View("Details", model);
        }

        [HttpPut]
        public IActionResult Move(WarehouseViewModel model)
        {
            if (!ModelState.IsValid)
            {
                //TODO: return error
            }

            return View("Move", model);
        }
    }
}
