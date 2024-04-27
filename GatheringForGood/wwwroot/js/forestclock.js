(function runForestClock() {
    updateUI();
});

$(function () {
    // Set the date we're counting down to
    var countUpDateExt = new Date("Oct 31, 2021 20:00:00").getTime();
    var countDownDateForestLost = new Date("Sept 24, 2426 20:00:00").getTime();

    // Update the count down every 1 second
    var x = setInterval(function () {

        // Get today's date and time
        var now = new Date().getTime();

        // Find the distance between now and the count down date
        var distance4 = now - countUpDateExt;
        var distance5 = countDownDateForestLost - now;

        // Time calculations for days, hours, minutes and seconds
        var yearsForest = Math.floor(distance5 / (1000 * 60 * 60 * 24 * 365.2422));
        var monthsForest = Math.floor(distance5 % (1000 * 60 * 60 * 24 * 365.2422) / (1000 * 60 * 60 * 24 * 30.42));
        var daysForest = Math.floor(distance5 % (1000 * 60 * 60 * 24 * 30.42) / (1000 * 60 * 60 * 24));
        var hoursForest = Math.floor((distance5 % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
        var minutesForest = Math.floor((distance5 % (1000 * 60 * 60)) / (1000 * 60));
        var secondsForest = Math.floor((distance5 % (1000 * 60)) / 1000);
        
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
        document.getElementById("ForestClockAllLost").innerHTML = yearsForest + "y " + monthsForest + "m " + daysForest + "d " + hoursForest + "h "
            + minutesForest + "m " + secondsForest + "s ";

        if (extinctionYrs > 0) {
            var finalValueHectares = ((years4 * 10000000) + (months4 * 833333.3333) + (days4 * 27397.2602) + (hours4 * 1141.5525) + (minutes4 * 19.0258) + (seconds4 * 0.3171)).toFixed(0);
            var finalValuePitches = (((years4 * 10000000) + (months4 * 833333.3333) + (days4 * 27397.2602) + (hours4 * 1141.5525) + (minutes4 * 19.0258) + (seconds4 * 0.3171)) * .62).toFixed(0);
            finalValueHectares = parseInt(finalValueHectares).toLocaleString();
            finalValuePitches = parseInt(finalValuePitches).toLocaleString();
            document.getElementById("ForestClockSinceLaunch").innerHTML = finalValueHectares + " hectares - or - " + finalValuePitches + " football pitches";
        } else if (extinctionMths > 0) {
            var finalValueHectares = ((months4 * 833333.3333) + (days4 * 27397.2602) + (hours4 * 1141.5525) + (minutes4 * 19.0258) + (seconds4 * 0.3171)).toFixed(0);
            var finalValuePitches = (((months4 * 833333.3333) + (days4 * 27397.2602) + (hours4 * 1141.5525) + (minutes4 * 19.0258) + (seconds4 * 0.3171)) * .62).toFixed(0);
            finalValueHectares = parseInt(finalValueHectares).toLocaleString();
            finalValuePitches = parseInt(finalValuePitches).toLocaleString();
            document.getElementById("ForestClockSinceLaunch").innerHTML = finalValueHectares + " hectares - or - " + finalValuePitches + " football pitches";
        } else if (extinctionDays > 0) {
            var finalValueHectares = ((days4 * 27397.2602) + (hours4 * 1141.5525) + (minutes4 * 19.0258) + (seconds4 * 0.3171)).toFixed(0);
            var finalValuePitches = (((days4 * 27397.2602) + (hours4 * 1141.5525) + (minutes4 * 19.0258) + (seconds4 * 0.3171)) * .62).toFixed(0);
            finalValueHectares = parseInt(finalValueHectares).toLocaleString();
            finalValuePitches = parseInt(finalValuePitches).toLocaleString();
            document.getElementById("ForestClockSinceLaunch").innerHTML = finalValueHectares + " hectares - or - " + finalValuePitches + " football pitches";
        } else if (extinctionHours > 0) {
            var finalValueHectares = ((hours4 * 1141.5525) + (minutes4 * 19.0258) + (seconds4 * 0.3171)).toFixed(0);
            var finalValuePitches = (((hours4 * 1141.5525) + (minutes4 * 19.0258) + (seconds4 * 0.3171)) * .62).toFixed(0);
            finalValueHectares = parseInt(finalValueHectares).toLocaleString();
            finalValuePitches = parseInt(finalValuePitches).toLocaleString();
            document.getElementById("ForestClockSinceLaunch").innerHTML = finalValueHectares + " hectares - or - " + finalValuePitches + " football pitches";
        } else if (extinctionMins > 0) {
            var finalValueHectares = ((minutes4 * 19.0258) + (seconds4 * 0.3171)).toFixed(0);
            var finalValuePitches = (((minutes4 * 19.0258) + (seconds4 * 0.3171)) * .62).toFixed(0);
            finalValueHectares = parseInt(finalValueHectares).toLocaleString();
            finalValuePitches = parseInt(finalValuePitches).toLocaleString();
            document.getElementById("ForestClockSinceLaunch").innerHTML = finalValueHectares + " hectares - or - " + finalValuePitches + " football pitches";
        } else if (extinctionSecs > 0) {
            var finalValueHectares = ((seconds4 * 0.3171)).toFixed(0);
            var finalValuePitches = (((seconds4 * 0.3171)) * .62).toFixed(0);
            finalValueHectares = parseInt(finalValueHectares).toLocaleString();
            finalValuePitches = parseInt(finalValuePitches).toLocaleString();
            document.getElementById("ForestClockSinceLaunch").innerHTML = finalValueHectares + " hectares - or - " + finalValuePitches + " football pitches";
        }
        // If the count down is finished, write some text
    }, 1000);

});
