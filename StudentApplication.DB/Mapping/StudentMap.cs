using System.Data.Entity.ModelConfiguration;
using StudentApplication.Core.Domain;
using _Student=StudentApplication.DB.DBConstants.Tables.Student;

namespace StudentApplication.DB.Mapping
{
    public class StudentMap: EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            this.HasKey(student => student.Id);
            this.ToTable(_Student.TableName);
            this.Property(student => student.Id).HasColumnName(_Student.Columns.StudentId);
            this.Property(student => student.Name).HasColumnName(_Student.Columns.Name);
            this.Property(student => student.Email).HasColumnName(_Student.Columns.Email);
            this.Property(student => student.City).HasColumnName(_Student.Columns.City);
            this.Property(student => student.Class).HasColumnName(_Student.Columns.Class);
            this.Property(student => student.EnrollYear).HasColumnName(_Student.Columns.EnrollYear);
            this.Property(student => student.Country).HasColumnName(_Student.Columns.Country);
        }
    }
}