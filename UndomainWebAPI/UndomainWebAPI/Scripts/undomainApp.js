var undomainApp = angular.module('undomainApp', ['ngResource', 'ngRoute']);


undomainApp.config(function ($routeProvider) {
    $routeProvider
        .when('/view1',
            {
                controller: 'EntityController',
                templateUrl: 'Partials/View1.html'
            })
        .when('/view2',
                {
                    controller: 'EntityController',
                    templateUrl: 'Partials/View2.html'
                })
        .otherwise({ redirectTo: '/view1' });
});


undomainApp.factory('entityFactory', function ($resource) {
    return $resource('/api/entity', {});
});

//undomainApp.factory('entityFactory', ['$http', function($http) {

//    var urlBase = '/api/entity'
//    var factory = {};

//    factory.getEntities = function () {
//        return $http.get(urlBase);
//    };

//    factory.getEntity = function (id) {
//        return $http.get(urlBase + '/' + id);
//    }

//    factory.insertEntity = function (entity) {
//        return $http.post(urlBase, entity)
//    };

//    factory.updateEntity = function (entity) {
//        return $http.put(urlBase + '/' + entity.id, entity)
//    };

//    factory.deleteEntity = function (id) {
//        return $http.delete(urlBase + '/' + id)
//    };

//    return factory;
//}]);


//undomainApp.factory('simpleFactory', function () {
//    var entities = [
//           {    id: 1, valueFamily: "Customer", value: "C347186", type: 0, parentID: 0 },
//           {    id: 2, valueFamily: "Name", value: "Acme Corp", type: 1, parentID: 1 },
//           {    id: 3, valueFamily: "Address Type", value: "Corp HQ", type: 1, parentID: 1 },
//           {    id: 4, valueFamily: "Address Line 1", value: "1234 Walnut Ave", type: 1, parentID: 1 }
//    ];

//    var factory = {};
//    factory.getEntities = function () {
//        return entities;
//    };
//    factory.postEntity = function (entity) {
//    };

//    return factory;
//});