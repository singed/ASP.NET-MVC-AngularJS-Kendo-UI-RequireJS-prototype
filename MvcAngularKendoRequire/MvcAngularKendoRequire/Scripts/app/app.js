'use strict';
define([], function() {
    var app = angular.module('app', ['ngRoute', 'kendo.directives']);
    app.config([
        '$routeProvider', '$controllerProvider',
        '$compileProvider', '$filterProvider', '$provide',
        function($routeProvider,  $controllerProvider,
            $compileProvider, $filterProvider, $provide) {

            //Change default views and controllers directory using the following:
            //routeResolverProvider.routeConfig.setBaseDirectories('/app/views', '/app/controllers');

            app.register =
            {
                controller: $controllerProvider.register,
                directive: $compileProvider.directive,
                filter: $filterProvider.register,
                factory: $provide.factory,
                service: $provide.service
            };
        }
    ]);

    return app;
});

