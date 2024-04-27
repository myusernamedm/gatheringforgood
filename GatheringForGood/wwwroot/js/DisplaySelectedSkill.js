function displaySelectedSkill() {
    var newSelection = $("#inputGroupSkillSelect option:selected").val();
    var existingValue = $("#SkillInputField").val();
    var select = document.getElementById("inputGroupSkillSelect");
    console.log("select: " + select);

    if (newSelection != "Choose...") {
        if (existingValue == "") {
            $("#SkillInputField").val(newSelection);
            select.options[0].selected = true;
        }
        else {
            var existingArray = existingValue.split(',');
            console.log("existingArray: " + existingArray);
            var valuesMatch = checkArrayValues(existingArray, newSelection);
            console.log("valuesMatch: " + valuesMatch);
            if (valuesMatch != true) {
                if (existingValue.charAt(existingValue.length - 1) == ",") {
                    var combined = existingValue + newSelection;
                    $("#SkillInputField").val(combined);
                    select.options[0].selected = true;
                }
                else if (existingValue.charAt(existingValue.length - 1) == " ") {
                    existingValue = existingValue.slice(0, -1);
                    var combined = existingValue + newSelection;
                    $("#SkillInputField").val(combined);
                    select.options[0].selected = true;
                }
                else
                {
                    var combined = existingValue + "," + newSelection;
                    $("#SkillInputField").val(combined);
                    select.options[0].selected = true;
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