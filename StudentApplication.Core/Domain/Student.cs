namespace StudentApplication.Core.Domain
{
    public class Student:EntityBase
    {
       
        public string Name { get; set; }
        public string Email { get; set; }
        public string Class { get; set; }
        public string City { get; set; }
        public string EnrollYear { get; set; }
        public string Country { get; set; }
    }
}