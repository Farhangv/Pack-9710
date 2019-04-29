'use strict';

(function () {

    $(function () {
        $('#load-news').click(function () {
            $('#top-news').load('news.html');
        });
    });

})();