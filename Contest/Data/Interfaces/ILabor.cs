using Contest.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contest.Data.Interfaces
{
    public interface ILabor
    {
        IEnumerable<Labor> Labors { get; }
        void AddLabor(Labor labor);
        void Delete(Labor labor);
        void SaveChanges();
    }
}
