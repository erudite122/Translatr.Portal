var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('Portal');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);