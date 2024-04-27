function populateNewRegionField() {
    var newSelection = $("#InfoPageinputGroupRegionSelect option:selected").val();
    var existingValue = $("#InfoPageReplaceRegionHiddenInputField").val();
    var select = document.getElementById("InfoPageinputGroupRegionSelect");
    console.log("select: " + select);

    if (newSelection == "Choose...") {
        $("#InfoPageReplaceRegionHiddenInputField").val("");
    }
    else {
        $("#InfoPageReplaceRegionHiddenInputField").val(newSelection);
    }
}