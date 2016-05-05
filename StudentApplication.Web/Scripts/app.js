var app = angular.module("app", ["xeditable"]);

app.run(function (editableOptions) {
    editableOptions.theme = 'bs3'; // bootstrap3 theme. Can be also 'bs2', 'default'
});

app.controller('Ctrl', ['$scope', 'StudentService', function ($scope, StudentService)
{
    $scope.user =
        {
        name: 'awesome user'
        };

    $scope.divstudent = false;
            getAllStudents();
    //To Get all student records  
            function getAllStudents()
            {
                /// debugger;
                var getStudentData = StudentService.getStudents();
                getStudentData.then(function(student) {
                    $scope.students = student.data;
                }, function() {
                    alert("Error in getting student records");
                });
            }


    $scope.editStudent = function(student) {
            //            debugger;
            var getStudentData = StudentService.getStudent(student.Id);
            getStudentData.then(function(_student) {
               $scope.student = _student.data;
               $scope.StudentId = student.Id;
               $scope.Name = student.Name;
               $scope.Email = student.Email;
               $scope.EnrollYear = student.EnrollYear;
               $scope.Class = student.Class;
               $scope.City = student.City;
               $scope.Country = student.Country;
               $scope.action = "Update";
               $scope.divstudent = true;

            }, function() {

                alert("Error in getting students records");
            });
        };
       $scope.save = function ()
        {
            var Student =
            {
                Name:$scope.Name,
                Email:$scope.Email,
                EnrollYear:$scope.EnrollYear,
                Class:$scope.Class,
                City:$scope.City,
                Country:$scope.Country,
                Id:$scope.StudentId,
                StudentId:$scope.StudentId
            };

            var getStudentAction =$scope.action;

            if (getStudentAction == "Update") {
                Student.StudentId =$scope.StudentId;
                var getStudentData = StudentService.updateStudent(Student);
                getStudentData.then(function(msg) {
                    getAllStudents();
                    alert(msg.data);
                   $scope.divstudent = false;
                }, function() {
                    alert("Error in updating student record");
                });
            } else {
                var getStudentData = StudentService.addStudent(Student);
                getStudentData.then(function(msg) {
                    getAllStudents();
                    alert(msg.data);
                   $scope.divstudent = false;
                }, function() {
                    alert("Error in adding student record");
                });
            }
        };

        function clearFields() {
           $scope.StudentId = "";
           $scope.Name = "";
           $scope.Email = "";
           $scope.Country = "";
           $scope.Class = "";
           $scope.City = "";
           $scope.EnrollYear = "";
        }

       $scope.addStudent = function() {
            //  debugger;

            clearFields();
           $scope.action = "Add";
           $scope.divstudent = true;
        };

       $scope.delete = function(student) {
            var getStudentData = StudentService.deleteStudent(student);
            getStudentData.then(function(_student) {
                alert(_student.data);
                getAllStudents();
            }, function() {
                alert("Error in deleting student record");
            });
        };

       $scope.cancel = function() {
           $scope.divstudent = false;
       };

       $scope.UpdateName = function (student) {

           var Student =
            {
                Name: student.Name,
                Email: student.Email,
                EnrollYear: student.EnrollYear,
                Class: student.Class,
                City: student.City,
                Country: student.Country,
                Id: student.Id,
                StudentId: $scope.StudentId
            };
           Student.StudentId = student.StudentId;

           var getStudentData = StudentService.updateStudent(Student);
           getStudentData.then(function () {
               getAllStudents();
               
               $scope.divstudent = false;
           }, function () {
               alert("Error in updating student record");
           });
       };
}]);