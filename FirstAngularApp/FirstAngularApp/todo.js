angular.module('AngularApp', [])
    .controller('TodoController',
    function($scope) {
        $scope.number = 4;

        $scope.todoList = [
            { name: 'Completed', isCompleted: true },
            { name: 'Incomplete', isCompleted: false }
        ];

        $scope.add = function () {
            if ($scope.input == '') return;
            $scope.todoList.push({ name: $scope.input, isCompleted: false });
            $scope.input = '';
        };

        var getKeyNumber = function(event) {
            return event.keyCode ? event.keyCode : event.which;
        }

        $scope.onKeyDown = function (event) {
            var keyNumber = getKeyNumber(event);
            if (keyNumber == 13) $scope.add();
        }

        $scope.remove = function() {
            var oldTodos = $scope.todoList;
            $scope.todoList = [];
            for (var i = 0; i < oldTodos.length; i++) {
                if (!oldTodos[i].isCompleted)
                    $scope.todoList.push(oldTodos[i]);
            }
        }
    })
    .directive('helloWorld',
    function() {
        return {
            restrict: 'E',
            template: '<span>Hello World!<span>'
        }
    })
    