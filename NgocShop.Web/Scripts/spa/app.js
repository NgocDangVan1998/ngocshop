/// <reference path="../plugins/angular.js" />

var myApp = angular.module('myModule', []);

//Đưa controller vào Module
myApp.controller("schoolController", schoolController);
myApp.service('Validator', Validator);

schoolController.$inject = ['$scope','Validator']

function schoolController($scope, Validator) {
    $scope.checkNumber = function () {
        $scope.message = Validator.checkNunber($scope.num);
    }
    $scope.num = 1;
}

function Validator($window) {
    return {
        checkNunber: checkNunber
    }
    function checkNunber(input) {
        if (input % 2 == 0) {
            return 'This is even';
        } else {
            return 'This is odd';
        }
    }
}