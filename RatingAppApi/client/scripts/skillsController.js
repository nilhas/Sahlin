skillsApp.controller("skillsCtrl", function ($scope, $http) {

    angular.element(document).ready(function () {
        GetAllSkills();
    });

    $scope.values = [0, 1, 2, 3, 4, 5]
    $scope.selected = null;

    $scope.setvalue = function (value) {
        $scope.selected = value;
    }

    $scope.add = function (input) {
        var data = { Expertise: input.expertise, Value: $scope.selected };

        $http.post("/api/add/skill", data).then(function () {
            GetAllSkills();
        });
    }

    $scope.delete = function (id) {
        $http.post("/api/delete/skill/" + id).then(function () {
            GetAllSkills();
        });
    }

    function GetAllSkills() {
        $http.get('/api/get/allskills').
           then(function (response) {
               $scope.skills = response.data;
           })
    }
});


