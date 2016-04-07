using AutoMapper;
using StudentApplication.Core.Domain;
using StudentApplication.Web.Models;


namespace StudentApplication.Web.Bootstrappers.AutoMapperProfiles
{
    public class StudentMapper:Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Student, StudentViewModel>();
            Mapper.CreateMap<StudentViewModel, Student>();
        }
    }
}