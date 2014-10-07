$(document).ready(function () {
    $.get('/Home/Home', function (data) {
        $('#content').html(data);
    });

    $('.nav').on('click', '.ajax', function () {
        $.get($(this).data('url'), function (data) {
            $('#content').html(data);
        });
    });

    $('.tabs').on('click', '.tabid', function () {
        $.get($(this).data('url'), function (data) {
            $('#tab').html(data);
        });
    });
    $('#contactContainer').on('submit', '#contactForm', function (event) {
        event.preventDefault();
        if ($(this).valid()) {
            var urlToPostTo = $(this).attr('action');
            var dataToSend = $(this).serialize();
            $.post(urlToPostTo, dataToSend, function (data) {
                $('#contactContainer').html(data);
            });
        }
    });
});


var loadFirstTab = function () {
    $.get('/About/Who', function (data) {
        $('#tab').html(data);
    });

    $('.tabs').on('click', '.tabid', function () {
        $.get($(this).data('url'), function (data) {
            $('#tab').html(data);
        });
    });
};