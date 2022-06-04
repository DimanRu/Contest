using Contest.Data.Interfaces;
using Contest.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contest.Data.Repository
{
    public class LaborRepository : ILabor
    {
        private readonly AppDBContent _appDBContent;

        public LaborRepository(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }

        public IEnumerable<Labor> Labors => _appDBContent.Labors;

        public void AddLabor(Labor labor)
        {
            _appDBContent.Labors.Add(labor);
            _appDBContent.SaveChanges();
        }

        public void SaveChanges()
        {
            _appDBContent.SaveChanges();
        }

        public void Delete(Labor labor)
        {
            _appDBContent.Labors.Remove(labor);
            _appDBContent.SaveChanges();
        }
    }
}
