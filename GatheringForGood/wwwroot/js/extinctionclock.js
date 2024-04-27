(function runExtinctionClock() {
    updateUI();
});

$(function () {
    // Set the date we're counting down to
    var countDownDateExt = new Date("Aug 19, 2272 12:00:00").getTime();
    var countUpDateExt = new Date("Oct 31, 2021 20:00:00").getTime();

    // Update the count down every 1 second
    var x = setInterval(function () {

        // Get today's date and time
        var now = new Date().getTime();

        // Find the distance between now and the count down date
        var distance3 = countDownDateExt - now;
        var distance4 = now - countUpDateExt;

        // Time calculations for days, hours, minutes and seconds

        var years3 = Math.floor(distance3 / (1000 * 60 * 60 * 24 * 365.2422));
        var months3 = Math.floor(distance3 % (1000 * 60 * 60 * 24 * 365.2422) / (1000 * 60 * 60 * 24 * 30.42));
        var days3 = Math.floor(distance3 % (1000 * 60 * 60 * 24 * 30.42) / (1000 * 60 * 60 * 24));
        var hours3 = Math.floor((distance3 % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
        var minutes3 = Math.floor((distance3 % (1000 * 60 * 60)) / (1000 * 60));
        var seconds3 = Math.floor((distance3 % (1000 * 60)) / 1000);

        var years4 = Math.floor(distance4 / (1000 * 60 * 60 * 24 * 365.2422));
        var months4 = Math.floor(distance4 % (1000 * 60 * 60 * 24 * 365.2422) / (1000 * 60 * 60 * 24 * 30.42));
        var days4 = Math.floor(distance4 % (1000 * 60 * 60 * 24 * 30.42) / (1000 * 60 * 60 * 24));
        var hours4 = Math.floor((distance4 % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
        var minutes4 = Math.floor((distance4 % (1000 * 60 * 60)) / (1000 * 60));
        var seconds4 = Math.floor((distance4 % (1000 * 60)) / 1000);
        var extinctionYrs = (years4 * 31755).toFixed(10);
        var extinctionMths = (months4 * 2646.25).toFixed(10);
        var extinctionDays = (days4 * 87).toFixed(10);
        var extinctionHours = (hours4 * 3.625).toFixed(10);
        var extinctionMins = (minutes4 * .0604).toFixed(10);
        var extinctionSecs = (seconds4 * .0010069).toFixed(10);

        // Display the result in the element with id="demo"
        document.getElementById("ExtinctionClockMostLost").innerHTML = years3 + "y " + months3 + "m " + days3 + "d " + hours3 + "h "
            + minutes3 + "m " + seconds3 + "s ";

        if (extinctionYrs > 0) {
            var finalValueExtinctions = ((years4 * 31755) + (months4 * 2646.25) + (days4 * 87) + (hours4 * 3.625) + (minutes4 * .0604) + (seconds4 * .0010069)).toFixed(0);
            finalValueExtinctions = parseInt(finalValueExtinctions).toLocaleString();
            document.getElementById("ExtinctionClockSinceLaunch").innerHTML = finalValueExtinctions;
        } else if (extinctionMths > 0) {
            var finalValueExtinctions = ((months4 * 2646.25) + (days4 * 87) + (hours4 * 3.625) + (minutes4 * .0604) + (seconds4 * .0010069)).toFixed(0);
            finalValueExtinctions = parseInt(finalValueExtinctions).toLocaleString();
            document.getElementById("ExtinctionClockSinceLaunch").innerHTML = finalValueExtinctions;
        } else if (extinctionDays > 0) {
            var finalValueExtinctions = ((days4 * 87) + (hours4 * 3.625) + (minutes4 * .0604) + (seconds4 * .0010069)).toFixed(0);
            finalValueExtinctions = parseInt(finalValueExtinctions).toLocaleString();
            document.getElementById("ExtinctionClockSinceLaunch").innerHTML = finalValueExtinctions;
        } else if (extinctionHours > 0) {
            var finalValueExtinctions = ((hours4 * 3.625) + (minutes4 * .0604) + (seconds4 * .0010069)).toFixed(0);
            finalValueExtinctions = parseInt(finalValueExtinctions).toLocaleString();
            document.getElementById("ExtinctionClockSinceLaunch").innerHTML = finalValueExtinctions;
        } else if (extinctionMins > 0) {
            var finalValueExtinctions = ((minutes4 * .0604) + (seconds4 * .0010069)).toFixed(0);
            finalValueExtinctions = parseInt(finalValueExtinctions).toLocaleString();
            document.getElementById("ExtinctionClockSinceLaunch").innerHTML = finalValueExtinctions;
        } else if (extinctionSecs > 0) {
            var finalValueExtinctions = ((seconds4 * .0010069)).toFixed(0);
            finalValueExtinctions = parseInt(finalValueExtinctions).toLocaleString();
            document.getElementById("ExtinctionClockSinceLaunch").innerHTML = finalValueExtinctions;
        }

    }, 1000);
    
});