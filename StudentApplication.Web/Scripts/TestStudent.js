StudentApp = angular.module("App", []);
StudentApp.controller("TestStudentController", ["StudentService",
    function(StudentService) 
    {
        var vm = this;
     
        getAllStudents();

       
        //To Get all student records  
        function getAllStudents() {
            /// debugger;
            var getStudentData = StudentService.getStudents();
            getStudentData.then(function(student) {
                vm.students = student.data;
                selected : { }
            }, function() {
                alert("Error in getting student records");
            });

        };

       

        // gets the template to ng-include for a table row / item
       vm.getTemplate = function (student) {
           if (student.id !== vm.students.id) return 'display';
            else return 'edit';
        };

       vm.editContact = function (contact) {
           vm.students = angular.copy(contact);
        };

       vm.saveContact = function (idx) {
            console.log("Saving contact");
            vm.students[idx] = angular.copy(vm.students);
           vm.reset();
        };

       vm.reset = function () {
           vm.students = {};
        };

    }
]);
