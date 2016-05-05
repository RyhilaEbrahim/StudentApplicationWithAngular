using System;
using System.Collections.Generic;
using System.Linq;
using StudentApplication.Core.Domain;
using StudentApplication.Core.Interfaces;

namespace StudentApplication.DB.Repositories
{
    public class StudentRepository:IStudentRepository
    {
        private readonly IStudentDbContext _studentDbContext;
        public StudentRepository(IStudentDbContext studentDbContext)
        {
            if (studentDbContext == null) throw new ArgumentNullException(nameof(studentDbContext));
            _studentDbContext = studentDbContext;
        }
        public void Delete(int studentId)
        {
            var student = Get(studentId);
            _studentDbContext.Students.Remove(student);
            _studentDbContext.SaveChanges();
        }

        public Student Get(int id)
        {
            return _studentDbContext.Students.FirstOrDefault(student => student.Id == id);
        }
      
        public void Save(Student student)
        {
           _studentDbContext.AttachEntity(student);
           _studentDbContext.SaveChanges();
        }


        public List<Student> GetAllStudents()
        {
            return _studentDbContext.Students.ToList();
        }
    }
}