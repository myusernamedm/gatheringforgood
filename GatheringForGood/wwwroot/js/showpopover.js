$(document).ready(function () {
    $('[data-toggle="popover"]').popover({
        placement: wheretoplace
    });
});
function wheretoplace() {
    var width = window.innerWidth;
    if (width > 800) return 'top';
    return 'right';
}