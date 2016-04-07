using System.ComponentModel;

namespace StudentApplication.Web.Models
{
    public class StudentViewModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Class { get; set; }
        public string City { get; set; }
        public string EnrollYear { get; set; }
        public string Country { get; set; }
    }
}