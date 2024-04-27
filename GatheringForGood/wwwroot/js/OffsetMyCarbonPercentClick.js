function offsetMyCarbonPercentClick(num) {

    var InputGroupPublicSelect = $("#OffsetMyCarbonPageInputGroupPublicSelect option:selected").val();
    var InputGroupDriving1Select = $("#OffsetMyCarbonPageInputGroupDriving1Select option:selected").val();
    var InputGroupDriving2Select = $("#OffsetMyCarbonPageInputGroupDriving2Select option:selected").val();

    switch (num) {
        case 1:
            $("#SelectedPercentValueField").val(InputGroupPublicSelect);
            break;
        case 2:
            $("#SelectedPercentValueField").val(InputGroupDriving1Select);
            break;
        case 3:
            $("#SelectedPercentValueField").val(InputGroupDriving2Select);
            break;
    }
}