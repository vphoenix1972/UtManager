'use strict';

import angular from 'angular';
import appModule from './appModule';

function AppController() {
    var self = this;

    self.text = 'Hello World!';
}

angular.module(appModule)
    .controller('appController', AppController);