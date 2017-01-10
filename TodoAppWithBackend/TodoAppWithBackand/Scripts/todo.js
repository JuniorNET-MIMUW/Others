angular.module('AngularApp', [])
    .controller('TodoController',
    function ($scope, $http) {
        $scope.todoList = [];

        $http.get('/Home/GetList')
            .success(function (data) {
                console.log(data);
                $scope.todoList = data;
            });

        $scope.number = 4;

        $scope.add = function () {
            if ($scope.input == '') return;
            $scope.todoList.push({ name: $scope.input, isCompleted: false });
            $scope.input = '';
        };

        var getKeyNumber = function (event) {
            return event.keyCode ? event.keyCode : event.which;
        }

        $scope.onKeyDown = function (event) {
            var keyNumber = getKeyNumber(event);
            if (keyNumber == 13) $scope.add();
        }

        $scope.remove = function () {
            var oldTodos = $scope.todoList;
            $scope.todoList = [];
            for (var i = 0; i < oldTodos.length; i++) {
                if (!oldTodos[i].isCompleted)
                    $scope.todoList.push(oldTodos[i]);
            }
        }
    })
