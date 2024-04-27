function populateHiddenSearchField() {
    var searchSelection = $("#inputGroupSearchSelect option:selected").val();
    var searchSelection1 = $("#inputGroupSearchSelect1 option:selected").val();
    $("#SearchOptionHiddenInputField").val(searchSelection);
    $("#SearchOptionHiddenInputField1").val(searchSelection1);
}