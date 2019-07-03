(function () {

    "use strict";

    angular.module("app-tasks")
        .controller("tasksController", tasksController);

    function tasksController($http) {

        var vm = this;

        vm.tasks = [];

        vm.newTask = {};

        vm.getTasks = function () {

            vm.errorMessage = "";
            vm.isBusy = true;

            $http.get("/api/tasks")
                .then(function (response) {
                    angular.copy(response.data, vm.tasks);
                }, function (error) {
                    vm.errorMessage = "Falha ao carregar os dados: " + error;
                })
                .finally(function () {
                    vm.isBusy = false;
                });
        }

        vm.getTasks();

        vm.addTask = function () {

            vm.errorMessage = "";

            vm.isBusy = true;

            $http.post("/api/Tasks/", vm.newTask)
                .then(function (response) {
                    vm.getTasks();
                    vm.newTask = {};
                }, function (error) {
                    vm.errorMessage = "Falha ao salvar os dados: " + error;
                })
                .finally(function () {
                    vm.isBusy = false;
                });
        };

        vm.changeStatus = function (task) {
            vm.errorMessage = "";

            vm.isBusy = true;

            $http.put("/api/tasks/status/", task)
                .then(function (response) {
                    vm.getTasks();
                }, function (error) {
                    vm.errorMessage = "Falha ao mudar o status: " + error;
                })
                .finally(function () {
                    vm.isBusy = false;
                });

        };

        vm.editTask = function (task) {
            vm.errorMessage = "";

            vm.isBusy = true;

            $http.put("/api/tasks/", task)
                .then(function (response) {
                    vm.getTasks();
                }, function (error) {
                        vm.errorMessage = "Falha ao mudar o status: " + error;
                })
                .finally(function () {
                    vm.isBusy = false;
                });
            
        };

        vm.deleteTask = function (id) {
            vm.errorMessage = "";

            vm.isBusy = true;

            $http.delete("/api/tasks/" + id)
                .then(function (response) {
                    vm.getTasks();
                }, function (error) {
                    vm.errorMessage = "Falha ao excluir: " + error;
                })
                .finally(function () {
                    vm.isBusy = false;
                });
        };

    }

})();