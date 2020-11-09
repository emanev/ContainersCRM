using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContainersCRM.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ContainersCRM.Controllers
{
    public class ContainersController : Controller
    {
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

            return View("Add", model);
        }
    }
}
