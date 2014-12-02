require.config({
    baseUrl: 'scripts/app',
    paths: {
        //Packages
        'sb-admin': 'modules/sb-admin-2',
        'mainController': 'controllers/mainController'
    },
    shim: {

    },
    priority:['app', 'mainController'],
    urlArgs: "bust=" + (new Date()).getTime()
});

require([
    'app',
    'sb-admin',
    'mainController'
], function () {
    angular.bootstrap(document, ['app']);
})