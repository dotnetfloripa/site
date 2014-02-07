$(function () {
    var setActiveMenu = function () {
        var url = window.location.href;
        $('.header ul.nav li')
            .removeClass('active');
        $('.header ul.nav a')
            .filter(function () {
                return this.href == url;
            })
            .parent()
            .addClass('active');
    };
    $(document)
        .pjax('a', '#pjax-container')
        .on('pjax:send', function () {
            NProgress.remove();
            NProgress.start();
        })
        .on('pjax:complete', function () {
            NProgress.done();
            setActiveMenu();
            ga('set', 'location', window.location.href);
            ga('send', 'pageview');
        })
        .on('pjax:timeout', function (event) {
            event.preventDefault();
            NProgress.remove();
        });
    setActiveMenu();
});