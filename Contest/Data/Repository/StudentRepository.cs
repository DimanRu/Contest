using Contest.Data.Interfaces;
using Contest.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contest.Data.Repository
{
    public class StudentRepository : IStudent
    {
        private readonly AppDBContent _appDBContent;

        public StudentRepository(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }

        public IEnumerable<Student> Students => _appDBContent.Students;

        public void AddStudent(Student student)
        {
            _appDBContent.Students.Add(student);
            _appDBContent.SaveChanges();
        }
        public void SaveChanges()
        {
            _appDBContent.SaveChanges();
        }
        public void Delete(Student student)
        {
            _appDBContent.Students.Remove(student);
            _appDBContent.SaveChanges();
        }
    }
}
