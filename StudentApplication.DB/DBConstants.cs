namespace StudentApplication.DB
{
    public class DBConstants
    {
         
        public class Tables
        {
            public class Student
            {
                public const string TableName = "Student";

                public class Columns
                {
                    public const string StudentId = "StudentId";
                    public const string  Name = "Name";
                    public const string  Class = "Class";
                    public const string  EnrollYear = "EnrollYear";
                    public const string  City = "City";
                    public const string  Country = "Country";
                    public const string  Email = "Email";
                }
            }
            public class City
            {
                public const string TableName = "City";

                public class Columns
                {
                    public const string CityId = "CityId";
                    public const string  CityName = "CityName";
                 }
            }
        }
    }
}