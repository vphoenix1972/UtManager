'use strict';

import 'bootstrap';
import angular from 'angular';
import uiRouter from 'angular-ui-router';

import appConfig from './appConfig';
import appRun from './appRun';

var appModule = angular.module('utmanager.app',
        [
            uiRouter
        ])
    .config(appConfig)
    .run(appRun);

export default appModule.name;