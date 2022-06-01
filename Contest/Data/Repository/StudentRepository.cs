using Contest.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contest.Data.Repository
{
    public class StudentRepository
    {
        private readonly AppDBContent _appDBContent;

        public StudentRepository(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }

        public IEnumerable<Student> Students => _appDBContent.Student.Include(s => s.Group);
    }
}
