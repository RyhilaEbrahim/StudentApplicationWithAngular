using System.Data.Entity.ModelConfiguration;
using StudentApplication.Core.Domain;
using _City = StudentApplication.DB.DBConstants.Tables.City;
namespace StudentApplication.DB.Mapping
{
    public class CityMap : EntityTypeConfiguration<City>
    {
        public CityMap()
        {
            this.HasKey(city => city.Id);
            this.ToTable(_City.TableName);
            this.Property(city => city.Id).HasColumnName(_City.Columns.CityId);
            this.Property(city => city.CityName).HasColumnName(_City.Columns.CityName);
           
        }
    }
}