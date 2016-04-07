using System.Collections.Generic;
using StudentApplication.Core.Domain;

namespace StudentApplication.Core.Interfaces
{
    public interface ICityRepsitory
    {
  
        City Get(int id);
       
        List<City> GetAllCities();


    }
}