
'use strict';

run.$inject = ['$rootScope', '$state', '$location'];

function run($rootScope, $state, $location) {
    $rootScope.$state = $state;

    // Goto index page on application startup
    $location.url('/');
}

export default run;