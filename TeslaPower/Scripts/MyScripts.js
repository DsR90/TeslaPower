$(function () {
    $('#view').click(function () {
        var id = $('#ddList12').val();
        this.href = this.href + '?id=' + encodeURIComponent(id);
    });
});