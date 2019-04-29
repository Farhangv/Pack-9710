'use strict';
(function () {
    //$.ajax // Like an object
    //$(.....) //Like function //jQuery Object

    //$(document).ready(function () {

    //});

    $(function () {
        $('#submit-btn').on('click', function () {
            $('<div>')
                .addClass('alert alert-success')
                .html(`<b> کاربر گرامی ${$('#name').val()} ${$('#family').val()} ثبت نام شما با موفقیت انجام شد`)
                .appendTo($('#message-container'));

            $(this).off('click');
        });
    });

})();