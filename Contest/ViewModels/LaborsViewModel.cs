using Contest.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contest.ViewModels
{    public class LaborsViewModel
    {
        public IEnumerable<Labor> Labors { get; set; }
        public LaborsViewModel()
        {
        }
    }
}
