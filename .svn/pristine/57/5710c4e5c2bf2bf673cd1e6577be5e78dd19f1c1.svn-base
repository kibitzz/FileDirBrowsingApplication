var fileBrowserApp = angular.module('fileBrowserApp', ['ngRoute', 'ngCookies']);

fileBrowserApp.constant("urlsAPI", {
    "dirstat": "/api/v1/Content/GetStat",
    "dircontent": "/api/v1/Content/Get",
   
})

fileBrowserApp.config(['$httpProvider', function ($httpProvider) {
    $httpProvider.defaults.useXDomain = true;
    delete $httpProvider.defaults.headers.common['X-Requested-With'];
}]);
