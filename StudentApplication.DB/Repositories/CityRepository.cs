using System;
using System.Collections.Generic;
using System.Linq;
using StudentApplication.Core.Domain;
using StudentApplication.Core.Interfaces;

namespace StudentApplication.DB.Repositories
{
    public class CityRepository:ICityRepsitory
    {
        private readonly IStudentDbContext _studentDbContext;

        public CityRepository(IStudentDbContext studentDbContext)
        {
            if (studentDbContext == null) throw new ArgumentNullException(nameof(studentDbContext));
            _studentDbContext = studentDbContext;
        }
        public City Get(int id)
        {
            return _studentDbContext.City.FirstOrDefault(city => city.Id == id);
        }

        public List<City> GetAllCities()
        {
            return _studentDbContext.City.ToList();
        }
    }
}