using Contest.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contest.Data.Interfaces
{
    public interface IStudent
    {
        IEnumerable<Student> Students { get; }
        void AddStudent(Student student);
        void Delete(Student student);
        void SaveChanges();
    }
}
