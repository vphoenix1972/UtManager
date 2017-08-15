'use strict';

import './utmMenu.css';

import templateUrl from './utmMenu.tpl.html'

import angular from 'angular';
import appModule from 'frontend/app/appModule';

function UtmMenuDirectiveController() {
    'ngInject';
}

UtmMenuDirectiveController.prototype.$onInit = function () {

}

UtmMenuDirectiveController.prototype.$postLink = function () {

}

UtmMenuDirectiveController.prototype.$onDestroy = function () {

}


angular.module(appModule)
    .directive('utmMenu',
        function () {
            return {
                require: {
                    },
                restrict: 'E',
                scope: {
                },
                controller: UtmMenuDirectiveController,
                controllerAs: 'vm',
                bindToController: true,
                templateUrl: templateUrl
            }
        })
    // Hack
    // Try to preload the directive template to prevent blinking of the directive
    // during the first load of page
    .run([
        '$http', '$templateCache', function ($http, $templateCache) {
            $http.get(templateUrl)
                .then(function (response) {
                    $templateCache.put(templateUrl, response.data);
                });
        }
    ]);