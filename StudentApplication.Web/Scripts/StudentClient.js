StudentApp = angular.module("StudentApp", []);
StudentApp.controller("StudentController", [
    "StudentService", function(StudentService) {
        var vm = this;
        //Added Code
        vm.selected = {};
        vm.divstudent = false;
        getAllStudents();

        //Added code
        vm.value = new Date().toISOString().split("T")[0];

        vm.reset = function () {
            vm.selected = {};
        };
        vm.editEmployee = function (student)
        {
            vm.selected = angular.copy(student);
        };

      
        //To Get all student records  
        function getAllStudents() {
            /// debugger;
            var getStudentData = StudentService.getStudents();
            getStudentData.then(function(student) {
                vm.students = student.data;
            }, function() {
                alert("Error in getting student records");
            });
        }

       
       
        vm.editStudent = function(student) {
            //            debugger;
            var getStudentData = StudentService.getStudent(student.Id);
            getStudentData.then(function(_student) {
                vm.student = _student.data;
                vm.StudentId = student.Id;
                vm.Name = student.Name;
                vm.Email = student.Email;
                vm.EnrollYear = student.EnrollYear;
                vm.Class = student.Class;
                vm.City = student.City;
                vm.Country = student.Country;
                vm.action = "Update";
                vm.divstudent = true;

            }, function() {

                alert("Error in getting students records");
            });
        };
        vm.save = function ()
        {
            var Student =
            {
                Name: vm.Name,
                Email: vm.Email,
                EnrollYear: vm.EnrollYear,
                Class: vm.Class,
                City: vm.City,
                Country: vm.Country,
                Id: vm.StudentId,
                StudentId: vm.StudentId
            };

            var getStudentAction = vm.action;

            if (getStudentAction == "Update") {
                Student.StudentId = vm.StudentId;
                var getStudentData = StudentService.updateStudent(Student);
                getStudentData.then(function(msg) {
                    getAllStudents();
                    getAllCities();
                    alert(msg.data);
                    vm.divstudent = false;
                }, function() {
                    alert("Error in updating student record");
                });
            } else {
                var getStudentData = StudentService.addStudent(Student);
                getStudentData.then(function(msg) {
                    getAllStudents();
                    getAllCities();
                    alert(msg.data);
                    vm.divstudent = false;
                }, function() {
                    alert("Error in adding student record");
                });
            }
        };

        function clearFields() {
            vm.StudentId = "";
            vm.Name = "";
            vm.Email = "";
            vm.Country = "";
            vm.Class = "";
            vm.City = "";
            vm.EnrollYear = "";
        }

        vm.addStudent = function() {
            //  debugger;

            clearFields();
            vm.action = "Add";
            
            vm.divstudent = true;
        };

        vm.delete = function(student) {
            var getStudentData = StudentService.deleteStudent(student);
            getStudentData.then(function(_student) {
                alert(_student.data);
                getAllStudents();
            }, function() {
                alert("Error in deleting student record");
            });
        };

        vm.cancel = function() {
            vm.divstudent = false;
        };

      
      
    }
]);