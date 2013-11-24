$(document).ready(function () {
    $('.menu-dropdown')
    .on('mouseenter', function () {
        $(this).find('.submenu').toggle('fade');
    })
    .on('mouseleave', function () {
        $(this).find('.submenu').toggle('fade');
    });
});