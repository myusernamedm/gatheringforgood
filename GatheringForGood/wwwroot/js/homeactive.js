function homeactive(pname) {

    sessionStorage.setItem("activepage", pname);
    updateUI();
}

$(function () {
    var pname = sessionStorage.getItem("activepage");

    $("ul.navbar-nav li.nav-item:nth-child(1) a").addClass("active-item");
    $("ul.navbar-nav li.nav-item:nth-child(2) a").addClass("normal-item");
    $("ul.navbar-nav li.nav-item:nth-child(3) a").addClass("normal-item");
    $("ul.navbar-nav li.nav-item:nth-child(4) a").addClass("normal-item");

});