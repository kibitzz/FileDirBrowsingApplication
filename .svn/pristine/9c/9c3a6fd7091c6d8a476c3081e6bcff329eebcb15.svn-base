fileBrowserApp.factory('API', [
    '$http',
    'urlsAPI',
    function (
        $http,
        urlsAPI) {

        var API = {};

        API.loadcontent = function (path) {
            return $http({
                url: urlsAPI.dircontent,
                method: "POST",
                data: {
                    FullPath: path
                },
                headers: {
                    'Content-Type': 'application/json'
                }
            })
        };

        API.loadstat = function (path, ccursor) {
            return $http({
                url: urlsAPI.dirstat,
                method: "POST",
                data: {
                    FullPath: path,
                    Cursor: ccursor
                },              
                headers: {
                    'Content-Type': 'application/json'
                }
            })
        };
       
        return API;
    }
]);
