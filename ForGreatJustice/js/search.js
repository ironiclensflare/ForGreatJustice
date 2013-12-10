$("#search").submit(function(event) {
    var lat = "";
    var lng = "";
    $.getJSON("search.aspx?search=" + $("input:text[name=search]").val(), function (json) {
        lat = json.results[0].geometry.location.lat.toString();
        lng = json.results[0].geometry.location.lng.toString();
        //location.replace("default.aspx/?lat=" + json.results[0].geometry.location.lat + "&lng=" + json.results[0].geometry.location.lng;
    });
    location.replace("/default.aspx/?lat=" + lat + "&lng=" + lng)
    event.preventDefault();
});