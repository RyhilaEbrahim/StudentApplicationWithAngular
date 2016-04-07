
StudentApp.service("StudentService", function ($http)
{
    this.getStudents = function ()
    {
        return $http.get("/Student/GetStudents");
    };

    this.getStudent = function (studentId)
    {
        var response = $http({
            method: "post",
            url: "/Student/GetStudentById",
            params: {
                id: JSON.stringify(studentId)
            }
        });
        return response;
    }
    this.getCities = function ()
    {
        return $http.get("/Student/GetCities");
    };

    this.getCity = function (cityId)
    {
        var response = $http({
            method: "post",
            url: "/Student/GetCityById",
            params: {
                id: JSON.stringify(cityId)
            }
        });
        return response;
    }

    this.updateStudent = function (student) {

        var response = $http({
            method: "post",
            url: "/Student/UpdateStudent",
            data: JSON.stringify(student),
            dataType: "json"
        });
        return response;
        
    }

    this.addStudent = function (student) {
        var response = $http({
            method: "post",
            url: "/Student/AddStudent",
            data: JSON.stringify(student),
            dataType: "json"
        });
        return response;
    }

    //Delete Book
    this.deleteStudent = function (student) {
        var response = $http({
            method: "post",
            url: "/Student/DeleteStudent",
            data: JSON.stringify(student),
            dataType: "json"
        });
        return response;
    }
});