'use strict';
(function () {
    $(document).ajaxStart(function () {
        $('#ajax-loader').fadeIn(1000);
    });
    $(document).ajaxComplete(function () {
        $('#ajax-loader').fadeOut(1000);
    });
    $(function () {

        $("#submit").on('click', function () { 

            var data = {
                "title": $("#title").val(),
                "subtitle": $("#subtitle").val(),
                "content": $("#content").val()
            };

            $.ajax({
                'url': 'SubmitNews.aspx',
                'method': 'POST',
                'data': data
            })
                .done(function (response) {
                    $("<div>").addClass('alert alert-success')
                        .html(response)
                        .prependTo($('#main-content'));
                })
                .fail(function () {
                    $("<div>").addClass('alert alert-danger')
                        .html("خطایی رخ داده")
                        .prependTo($('#main-content'));
                })
                .always(function () {
                    setTimeout(function () {
                        $('.alert').remove();
                    }, 5000);
                });
        });
    });
})();