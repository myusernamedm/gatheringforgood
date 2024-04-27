function displaySelectedInterest() {
    var newSelection = $("#inputGroupInterestsSelect option:selected").val();
    var existingValue = $("#AreaOfInterestInputField").val();
    var interestSelect = document.getElementById("inputGroupInterestsSelect");
    console.log("select: " + interestSelect);

    if (newSelection != "Choose...") {
        if (existingValue == "") {
            $("#AreaOfInterestInputField").val(newSelection);
            interestSelect.options[0].selected = true;
        }
        else {
            var existingArray = existingValue.split(',');
            console.log("existingArray: " + existingArray);
            var valuesMatch = checkArrayValues(existingArray, newSelection);
            console.log("valuesMatch: " + valuesMatch);
            if (valuesMatch != true) {
                if (existingValue.charAt(existingValue.length - 1) == ",") {
                    var combined = existingValue + newSelection;
                    $("#AreaOfInterestInputField").val(combined);
                    interestSelect.options[0].selected = true;
                }
                else if (existingValue.charAt(existingValue.length - 1) == " ") {
                    existingValue = existingValue.slice(0, -1);
                    var combined = existingValue + newSelection;
                    $("#AreaOfInterestInputField").val(combined);
                    interestSelect.options[0].selected = true;
                }
                else
                {
                    var combined = existingValue + "," + newSelection;
                    $("#AreaOfInterestInputField").val(combined);
                    interestSelect.options[0].selected = true;
                }
            }
        }

    }
}

function checkArrayValues(existingArrayValue, newSelectionValue) {

    for (let i = 0; i < existingArrayValue.length; i++) {
        var individualArrayValue = existingArrayValue[i];

        console.log("individualArrayValue: " + individualArrayValue);
        console.log("newSelectionValue: " + newSelectionValue);

        if (individualArrayValue == newSelectionValue) {
            console.log("newSelectionValue: + individualArrayValue: " + newSelectionValue + " + " + individualArrayValue);
            return true;
        }
    }

    return false;
}