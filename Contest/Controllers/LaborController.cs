using Contest.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contest.Controllers
{
    public class LaborController : Controller
    {
        
        public IActionResult SelectLabor(int id)
        {
            return View(new LaborViewModel());
        }
    }
}
