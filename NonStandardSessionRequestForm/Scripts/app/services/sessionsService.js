﻿'use strict';

sessionModule.factory('Sessions', ['$resource', function ($resource) {

    return $resource(
        'api/sessionrequests/5',  null,
        { "query": { method: "GET" } }
    );

}])