var app = angular.module('UndomainApp', []);

app.config(function ($routeProvider) {
    $routeProvider
        .when('/',
            {
                controller: 'EntityController',
                templateUrl: 'Partials/View1.html'
            })
        .when('/partial2',
                {
                    controller: 'EntityController',
                    templateUrl: 'Partials/View2.html'
                })
        .otherwise({ redirectTo: '/' });
});