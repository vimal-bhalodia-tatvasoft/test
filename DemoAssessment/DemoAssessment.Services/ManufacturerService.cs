using DemoAssessmentAPI.Models;
using Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAssessment.Services
{
    public class ManufacturerService : IManufacturerService
    {
        #region Fields

        private DemoDbContext _dbContext;

        #endregion

        #region Ctor

        public ManufacturerService()
        {
            _dbContext = new DemoDbContext();
        }

        #endregion
        public List<Manufacturer> GetManufacturers()
        {
            return _dbContext.Manufacturers.ToList();
        }
    }
}
