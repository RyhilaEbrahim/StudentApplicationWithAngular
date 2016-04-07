using System.Data.Common;
using System.Data.Entity;
using StudentApplication.Core.Domain;
using StudentApplication.DB.Mapping;

namespace StudentApplication.DB
{
    public  interface IStudentDbContext
    {
        int SaveChanges();
        void AttachEntity(EntityBase entity);
        IDbSet<Student> Students { get; set; }
        IDbSet<City> City { get; set; }
       void SetStateToDelete(EntityBase entityList);
    }

    public class StudentDbContext : DbContext, IStudentDbContext
    {
        public StudentDbContext(DbConnection connection) : base(connection, true)
        {

        }
        public StudentDbContext(string nameOrConnectionString = "DefaultConnection") : base(nameOrConnectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var config = modelBuilder.Configurations;
            config.Add(new StudentMap());
            config.Add(new CityMap());
          
            base.OnModelCreating(modelBuilder);
        }

        public void AttachEntity(EntityBase entity)
        {
            Entry(entity).State = entity.IsNew() ? EntityState.Added : EntityState.Modified;
        }

        public IDbSet<Student> Students { get; set; }
        public IDbSet<City> City { get; set; }

        public void SetStateToDelete(EntityBase entityList)
        {
            Entry(entityList).State = entityList.Id == 0 ? EntityState.Detached : EntityState.Deleted;
        }
    }
}