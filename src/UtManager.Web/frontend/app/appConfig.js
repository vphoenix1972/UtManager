'use strict';

import appTemplateUrl from 'frontend/app/app.tpl.html';

Config.$inject = ['$stateProvider', '$urlRouterProvider'];

function Config($stateProvider, $urlRouterProvider) {
    $urlRouterProvider.otherwise('/');

    $stateProvider
        .state('app',
            {
                abstract: false,
                url: '/',
                templateUrl: appTemplateUrl,
                controller: 'appController',
                controllerAs: 'vm'
            });
}

export default Config;