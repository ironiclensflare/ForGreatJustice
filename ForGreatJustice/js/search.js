$(document).ready(function () {
    $("#search").submit(function (event) {
        $.getJSON("/search.aspx/?search=" + $("input:text[name=search]").val(), function (json) {
            location.replace("/default.aspx/?lat=" + json.results[0].geometry.location.lat.toString() + "&lng=" + json.results[0].geometry.location.lng.toString());
        });
        event.preventDefault();
    });
});