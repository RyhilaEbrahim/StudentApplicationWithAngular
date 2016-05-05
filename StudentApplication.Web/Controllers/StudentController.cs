using System.Web.Mvc;
using AutoMapper;
using StudentApplication.Core.Domain;
using StudentApplication.Core.Interfaces;

namespace StudentApplication.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ICityRepsitory _cityRepository;

        public StudentController(IStudentRepository studentRepository, IMappingEngine mappingEngine, ICityRepsitory cityRepsitory)
        {
            _cityRepository = cityRepsitory;
            _studentRepository = studentRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EditableStudent()
        {
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
      
        public ActionResult Editable()
        {
            return View();
        }
       
        public JsonResult GetStudents()
        {
            var result = _studentRepository.GetAllStudents();
            return new JsonResult { Data = result, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

        public JsonResult GetCities()
        {
            var result = _cityRepository.GetAllCities();
            return new JsonResult { Data = result, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

        public JsonResult GetStudentById(int id)
        {
            var student = _studentRepository.Get(id);
            return Json(student, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetCityById(int id)
        {
            var city = _studentRepository.Get(id);
            return Json(city, JsonRequestBehavior.AllowGet);
        }

        public string AddStudent(Student student)
        {
            if (student == null) return "Invalid record";
            _studentRepository.Save(student);
            return "Student Added";
        }

        public string UpdateStudent(Student student)
        {
            if (student == null) return "Invalid record";
            _studentRepository.Save(student);
            return "Student Added";
        }

        public string UpdateName(Student student)
        {
            if (student == null) return "Invalid record";
            _studentRepository.Save(student);
            return "Student Added";
        }

        public string DeleteStudent(Student student)
         {
            if (student == null) return "Invalid operation";
            _studentRepository.Delete(student.Id);
            return "Student Deleted";
        }
    }
}
