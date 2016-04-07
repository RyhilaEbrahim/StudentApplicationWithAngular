using FluentMigrator;
using _Student = StudentApplication.DB.DBConstants.Tables.Student;
namespace StudentApplication.DB.Migrations.Migrations
{
    [Migration(201504051006)]
    public class _201504051006_CreateStudentTable: Migration
    {
        public override void Up()
        {
            Create.Table(_Student.TableName)
               .WithColumn(_Student.Columns.StudentId).AsInt32().PrimaryKey("PK_StudentId").Identity()
               .WithColumn(_Student.Columns.Name).AsString(50)
               .WithColumn(_Student.Columns.Email).AsString(500)
               .WithColumn(_Student.Columns.Class).AsString(50)
               .WithColumn(_Student.Columns.EnrollYear).AsString(50)
               .WithColumn(_Student.Columns.City).AsString(50)
               .WithColumn(_Student.Columns.Country).AsString(50)
               .WithDefaultEntityColumns();
        }

        public override void Down()
        {
            throw new System.NotImplementedException();
        }
    }
}