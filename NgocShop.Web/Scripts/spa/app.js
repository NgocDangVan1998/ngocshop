/// <reference path="../plugins/angular.js" />

var myApp = angular.module('myModule', []);

//Đưa controller vào Module
myApp.controller("schoolController", schoolController);
myApp.directive("ngocShopDirective", ngocShopDirective);
myApp.service('validatorService', validatorService);

schoolController.$inject = ['$scope','Validator']

function schoolController($scope, Validator) {
    $scope.checkNumber = function () {
        $scope.message = Validator.checkNunber($scope.num);
    }
    $scope.num = 1;
}

function validatorService($window) {
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

function ngocShopDirective() {
    return {
        restrict: "A",
        templateUrl: "/Scripts/spa/ngocShopDirective.html"
    }
}