﻿/// <reference path="../../../assets/admin/libs/angular.js" />

(function () {
    angular.module('ngocShop.product_categories', ['ngocshop.common']).config(config);
    config.$inject('$stateProvider','$urlRouterProvider')
    function config($stateProvider, $urlRouterProvider){
        $stateProvider.state('product_categories', {
            url: "/product_categories",
            templateUrl: "/app/components/product_categories/productCategoryListView.html",
            controller: "productCategoryListController"
        });
    }
})()