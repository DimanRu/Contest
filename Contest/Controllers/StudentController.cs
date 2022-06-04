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
    public class StudentController : Controller
    {
        IStudent _repos;

        public StudentController(IStudent repos)
        {
            _repos = repos;
        }

        public IActionResult Index()
        {
            return View(new StudentViewModel() { Students = _repos.Students });
        }

        public IActionResult Edit(int? id)
        {            
            var student = _repos.Students.FirstOrDefault(s => s.Id == id) ?? new Student();
            return View("Edit", student);
        }
        public IActionResult Delete(int id)
        {
            _repos.Delete(_repos.Students.FirstOrDefault(s => s.Id == id));
            return View("Index", new StudentViewModel() { Students = _repos.Students });
        }

        [HttpPost]
        public RedirectToActionResult Save(Student model)
        {
            var student = _repos.Students.FirstOrDefault(s => s.Id == model.Id);
            if (student != null)
            {
                student.Name = model.Name;
                student.Group = model.Group;
                _repos.SaveChanges();
            }
            else
                _repos.AddStudent(model);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
