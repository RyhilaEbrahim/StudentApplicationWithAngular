using System.Collections.Generic;
using StudentApplication.Core.Domain;

namespace StudentApplication.Core.Interfaces
{
    public interface IStudentRepository
    {
        void Delete(int studentId);
        Student Get(int id);
        void Save(Student student);
        List<Student> GetAllStudents();
      
     
    }
}