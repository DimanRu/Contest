using Contest.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contest.ViewModels
{    public class StudentViewModel
    {
        public IEnumerable<Student> Students { get; set; }

        public StudentViewModel()
        {
        }
    }
}
