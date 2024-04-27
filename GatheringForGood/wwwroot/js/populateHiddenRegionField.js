function populateHiddenRegionField() {
    var regionSelection = $("#inputGroupRegionSelect option:selected").val();
    $("#RegionHiddenInputField").val(regionSelection);
}