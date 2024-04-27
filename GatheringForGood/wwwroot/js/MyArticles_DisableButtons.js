$(document).ready(function () {
    console.log("Check clicked");

    var elements = document.getElementsByClassName("form");

    for (var i = 0; i < elements.length; i++) {

        elements[i].addEventListener("click", function () {

            var elements1 = document.getElementsByClassName("form");
            for (var i = 0; i < elements1.length; i++) {
                console.log(elements1[i].name);
                elements1[i].style.pointerEvents = "none";
            }

        })
    }
});