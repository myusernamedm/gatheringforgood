(function runCarbonClock() {
    updateUI();
});

$(function () {
        // Set the date we're counting down to
        var countDownDate = new Date("Jul 20, 2029 14:46:03").getTime();
        var countDownDate2 = new Date("Apr 27, 2047 00:36:24").getTime();

        // Update the count down every 1 second
        var x = setInterval(function () {

            // Get today's date and time
            var now = new Date().getTime();

            // Find the distance between now and the count down date
            var distance = countDownDate - now;
            var distance2 = countDownDate2 - now;

            // Time calculations for days, hours, minutes and seconds
            var years = Math.floor(distance / (1000 * 60 * 60 * 24 * 365.2422));
            var months = Math.floor(distance % (1000 * 60 * 60 * 24 * 365.2422) / (1000 * 60 * 60 * 24 * 30.42));
            var days = Math.floor(distance % (1000 * 60 * 60 * 24 * 30.42) / (1000 * 60 * 60 * 24));
            var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
            var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
            var seconds = Math.floor((distance % (1000 * 60)) / 1000);

            var years2 = Math.floor(distance2 / (1000 * 60 * 60 * 24 * 365.2422));
            var months2 = Math.floor(distance2 % (1000 * 60 * 60 * 24 * 365.2422) / (1000 * 60 * 60 * 24 * 30.42));
            var days2 = Math.floor(distance2 % (1000 * 60 * 60 * 24 * 30.42) / (1000 * 60 * 60 * 24));
            var hours2 = Math.floor((distance2 % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
            var minutes2 = Math.floor((distance2 % (1000 * 60 * 60)) / (1000 * 60));
            var seconds2 = Math.floor((distance2 % (1000 * 60)) / 1000);

            // Display the result in the element with id="demo"
            document.getElementById("CarbonClock15").innerHTML = years + "y " + months + "m " + days + "d " + hours + "h "
                + minutes + "m " + seconds + "s ";
            document.getElementById("CarbonClock20").innerHTML = years2 + "y " + months2 + "m " + days2 + "d " + hours2 + "h "
                + minutes2 + "m " + seconds2 + "s ";

            // If the count down is finished, write some text
            if (distance < 0) {
                clearInterval(x);
                document.getElementById("CarbonClock15").innerHTML = "EXPIRED!!";
            }
            if (distance2 < 0) {
                clearInterval(x);
                document.getElementById("CarbonClock20").innerHTML = "EXPIRED!!";
            }
        }, 1000);

    });
