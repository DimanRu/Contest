using Contest.Data;
using Contest.Data.Interfaces;
using Contest.Data.Models;
using Contest.Data.Repository;
using Contest.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Contest.Controllers
{
    public class LaborsController : Controller
    {
        ILabor _repos;

        public LaborsController(ILabor repos)
        {
            _repos = repos;
        }

        public IActionResult Index()
        {
            return View(new LaborsViewModel() { Labors = _repos.Labors });
        }

        public IActionResult Edit(int? id)
        {            
            var labor = _repos.Labors.FirstOrDefault(s => s.Id == id) ?? new Labor();
            return View("Edit", labor);
        }
        public IActionResult Delete(int id)
        {
            _repos.Delete(_repos.Labors.FirstOrDefault(s => s.Id == id));
            return View("Index", new LaborsViewModel() { Labors = _repos.Labors });
        }

        [HttpPost]
        public RedirectToActionResult Save(Labor model)
        {
            var labor = _repos.Labors.FirstOrDefault(s => s.Id == model.Id);
            if (labor != null)
            {
                labor.Title = model.Title;
                labor.Description = model.Description;
                labor.Code = model.Code;
                _repos.SaveChanges();
            }
            else
                _repos.AddLabor(model);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
