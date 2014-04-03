(function (i, s, o, g, r, a, m) {
    i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
        (i[r].q = i[r].q || []).push(arguments)
    }, i[r].l = 1 * new Date(); a = s.createElement(o),
    m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
})(window, document, 'script', '//www.google-analytics.com/analytics.js', 'ga');

ga('create', 'UA-47847572-1', 'dotnetfloripa.com.br');
ga('send', 'pageview');


window.appInsights={queue:[],applicationInsightsId:null,accountId:null,appUserId:null,configUrl:null,start:function(n){function u(n,t){n[t]=function(){var i=arguments;n.queue.push(function(){n[t].apply(n,i)})}}function f(n){var t=document.createElement("script");return t.type="text/javascript",t.src=n,t.async=!0,t}function r(){i.appendChild(f("//az416426.vo.msecnd.net/scripts/ai.0.js"))}var i,t;this.applicationInsightsId=n;u(this,"logEvent");u(this,"logPageView");i=document.getElementsByTagName("script")[0].parentNode;this.configUrl===null?r():(t=f(this.configUrl),t.onload=r,t.onerror=r,i.appendChild(t));this.start=function(){}}};

appInsights.start("e25457b3-55b2-4b61-b930-f5e5dc45545e");
appInsights.logPageView();
