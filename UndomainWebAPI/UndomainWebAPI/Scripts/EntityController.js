undomainApp.controller("EntityController", function ($scope, entityFactory) {
    $scope.entities = [];

    init();

    function init() {
        getEntities();
    }

    function getEntities() {
        entityFactory.query(function (response) {
            $scope.entities = response;
        })
    };

    $scope.addEntity = function () {
        entityFactory.save($scope.newEntity, function () {
            getEntities();
        });
    };
});