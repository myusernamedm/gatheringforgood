function offsetMyCarbonFormControl(num) {

    var PercentSelectorCycleWalkPublic = document.getElementById('PercentSelectorCycleWalkPublic');
    var PercentSelectorCycleWalkDrive = document.getElementById('PercentSelectorCycleWalkDrive');
    var PercentSelectorPublicDrive = document.getElementById('PercentSelectorPublicDrive');
    var newSelection = $("#OffsetMyCarbonPageInputGroupPublicSelect option:selected").val();

    switch (num) {
        case 1:
            $("#SelectedRadio1Field").val(num);
            $("#SelectedPercentValueField").val(null);

            PercentSelectorCycleWalkPublic.className = "hide";
            PercentSelectorCycleWalkDrive.className = "hide";
            PercentSelectorPublicDrive.className = "hide";
            document.getElementById("flexRadioCycleWalk_CycleIcon").src = "../../images/cycleicon.png";
            document.getElementById("flexRadioCycleWalk_WalkIcon").src = "../../images/walkicon.png";
            document.getElementById("flexRadioCycleWalk_CycleIconsm").src = "../../images/cycleicon.png";
            document.getElementById("flexRadioCycleWalk_WalkIconsm").src = "../../images/walkicon.png";

            document.getElementById("flexRadioCycleWalkPublic_CycleIcon").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_WalkIcon").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_BusIcon").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioPublic_BusIcon").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_CycleIcon").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_WalkIcon").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_CarIcon").src = "../../images/cariconorange.png";
            document.getElementById("flexRadioPublicDrive_BusIcon").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioPublicDrive_CarIcon").src = "../../images/cariconorange.png";
            document.getElementById("flexRadioDrive_CarIcon").src = "../../images/cariconorange.png";

            document.getElementById("flexRadioCycleWalkPublic_CycleIconsm").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_WalkIconsm").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_BusIconsm").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioPublic_BusIconsm").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_CycleIconsm").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_WalkIconsm").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_CarIconsm").src = "../../images/cariconorange.png";
            document.getElementById("flexRadioPublicDrive_BusIconsm").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioPublicDrive_CarIconsm").src = "../../images/cariconorange.png";
            document.getElementById("flexRadioDrive_CarIconsm").src = "../../images/cariconorange.png";
            break;
        case 2:
            $("#SelectedRadio1Field").val(num);
            $("#SelectedPercentValueField").val(5);

            PercentSelectorCycleWalkPublic.className = "display";
            PercentSelectorCycleWalkDrive.className = "hide";
            PercentSelectorPublicDrive.className = "hide";
            document.getElementById("flexRadioCycleWalkPublic_CycleIcon").src = "../../images/cycleicon.png";
            document.getElementById("flexRadioCycleWalkPublic_WalkIcon").src = "../../images/walkicon.png";
            document.getElementById("flexRadioCycleWalkPublic_BusIcon").src = "../../images/busicon.png";
            document.getElementById("flexRadioCycleWalkPublic_CycleIconsm").src = "../../images/cycleicon.png";
            document.getElementById("flexRadioCycleWalkPublic_WalkIconsm").src = "../../images/walkicon.png";
            document.getElementById("flexRadioCycleWalkPublic_BusIconsm").src = "../../images/busicon.png";

            document.getElementById("flexRadioCycleWalk_CycleIcon").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalk_WalkIcon").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioPublic_BusIcon").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_CycleIcon").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_WalkIcon").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_CarIcon").src = "../../images/cariconorange.png";
            document.getElementById("flexRadioPublicDrive_BusIcon").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioPublicDrive_CarIcon").src = "../../images/cariconorange.png";
            document.getElementById("flexRadioDrive_CarIcon").src = "../../images/cariconorange.png";

            document.getElementById("flexRadioCycleWalk_CycleIconsm").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalk_WalkIconsm").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioPublic_BusIconsm").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_CycleIconsm").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_WalkIconsm").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_CarIconsm").src = "../../images/cariconorange.png";
            document.getElementById("flexRadioPublicDrive_BusIconsm").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioPublicDrive_CarIconsm").src = "../../images/cariconorange.png";
            document.getElementById("flexRadioDrive_CarIconsm").src = "../../images/cariconorange.png";
            break;
        case 3:
            $("#SelectedRadio1Field").val(num);
            $("#SelectedPercentValueField").val(null);

            PercentSelectorCycleWalkPublic.className = "hide";
            PercentSelectorCycleWalkDrive.className = "hide";
            PercentSelectorPublicDrive.className = "hide";
            document.getElementById("flexRadioPublic_BusIcon").src = "../../images/busicon.png";
            document.getElementById("flexRadioPublic_BusIconsm").src = "../../images/busicon.png";

            document.getElementById("flexRadioCycleWalk_CycleIcon").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalk_WalkIcon").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_CycleIcon").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_WalkIcon").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_BusIcon").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_CycleIcon").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_WalkIcon").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_CarIcon").src = "../../images/cariconorange.png";
            document.getElementById("flexRadioPublicDrive_BusIcon").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioPublicDrive_CarIcon").src = "../../images/cariconorange.png";
            document.getElementById("flexRadioDrive_CarIcon").src = "../../images/cariconorange.png";

            document.getElementById("flexRadioCycleWalk_CycleIconsm").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalk_WalkIconsm").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_CycleIconsm").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_WalkIconsm").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_BusIconsm").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_CycleIconsm").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_WalkIconsm").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_CarIconsm").src = "../../images/cariconorange.png";
            document.getElementById("flexRadioPublicDrive_BusIconsm").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioPublicDrive_CarIconsm").src = "../../images/cariconorange.png";
            document.getElementById("flexRadioDrive_CarIconsm").src = "../../images/cariconorange.png";
            break;
        case 4:
            $("#SelectedRadio1Field").val(num);
            $("#SelectedPercentValueField").val(5);

            PercentSelectorCycleWalkPublic.className = "hide";
            PercentSelectorCycleWalkDrive.className = "display";
            PercentSelectorPublicDrive.className = "hide";
            document.getElementById("flexRadioCycleWalkDrive_CycleIcon").src = "../../images/cycleicon.png";
            document.getElementById("flexRadioCycleWalkDrive_WalkIcon").src = "../../images/walkicon.png";
            document.getElementById("flexRadioCycleWalkDrive_CarIcon").src = "../../images/caricon.png";
            document.getElementById("flexRadioCycleWalkDrive_CycleIconsm").src = "../../images/cycleicon.png";
            document.getElementById("flexRadioCycleWalkDrive_WalkIconsm").src = "../../images/walkicon.png";
            document.getElementById("flexRadioCycleWalkDrive_CarIconsm").src = "../../images/caricon.png";

            document.getElementById("flexRadioCycleWalk_CycleIcon").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalk_WalkIcon").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_CycleIcon").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_WalkIcon").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_BusIcon").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioPublic_BusIcon").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioPublicDrive_BusIcon").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioPublicDrive_CarIcon").src = "../../images/cariconorange.png";
            document.getElementById("flexRadioDrive_CarIcon").src = "../../images/cariconorange.png";

            document.getElementById("flexRadioCycleWalk_CycleIconsm").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalk_WalkIconsm").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_CycleIconsm").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_WalkIconsm").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_BusIconsm").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioPublic_BusIconsm").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioPublicDrive_BusIconsm").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioPublicDrive_CarIconsm").src = "../../images/cariconorange.png";
            document.getElementById("flexRadioDrive_CarIconsm").src = "../../images/cariconorange.png";
            break;
        case 5:
            $("#SelectedRadio1Field").val(num);
            $("#SelectedPercentValueField").val(5);

            PercentSelectorCycleWalkPublic.className = "hide";
            PercentSelectorCycleWalkDrive.className = "hide";
            PercentSelectorPublicDrive.className = "display";
            document.getElementById("flexRadioPublicDrive_BusIcon").src = "../../images/busicon.png";
            document.getElementById("flexRadioPublicDrive_CarIcon").src = "../../images/caricon.png";
            document.getElementById("flexRadioPublicDrive_BusIconsm").src = "../../images/busicon.png";
            document.getElementById("flexRadioPublicDrive_CarIconsm").src = "../../images/caricon.png";

            document.getElementById("flexRadioCycleWalk_CycleIcon").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalk_WalkIcon").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_CycleIcon").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_WalkIcon").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_BusIcon").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioPublic_BusIcon").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_CycleIcon").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_WalkIcon").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_CarIcon").src = "../../images/cariconorange.png";
            document.getElementById("flexRadioDrive_CarIcon").src = "../../images/cariconorange.png";

            document.getElementById("flexRadioCycleWalk_CycleIconsm").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalk_WalkIconsm").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_CycleIconsm").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_WalkIconsm").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_BusIconsm").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioPublic_BusIconsm").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_CycleIconsm").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_WalkIconsm").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_CarIconsm").src = "../../images/cariconorange.png";
            document.getElementById("flexRadioDrive_CarIconsm").src = "../../images/cariconorange.png";
            break;
        case 6:
            $("#SelectedRadio1Field").val(num);
            $("#SelectedPercentValueField").val(null);

            PercentSelectorCycleWalkPublic.className = "hide";
            PercentSelectorCycleWalkDrive.className = "hide";
            PercentSelectorPublicDrive.className = "hide";
            document.getElementById("flexRadioDrive_CarIcon").src = "../../images/caricon.png";
            document.getElementById("flexRadioDrive_CarIconsm").src = "../../images/caricon.png";

            document.getElementById("flexRadioCycleWalk_CycleIcon").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalk_WalkIcon").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_CycleIcon").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_WalkIcon").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_BusIcon").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioPublic_BusIcon").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_CycleIcon").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_WalkIcon").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_CarIcon").src = "../../images/cariconorange.png";
            document.getElementById("flexRadioPublicDrive_BusIcon").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioPublicDrive_CarIcon").src = "../../images/cariconorange.png";

            document.getElementById("flexRadioCycleWalk_CycleIconsm").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalk_WalkIconsm").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_CycleIconsm").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_WalkIconsm").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkPublic_BusIconsm").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioPublic_BusIconsm").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_CycleIconsm").src = "../../images/cycleiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_WalkIconsm").src = "../../images/walkiconorange.png";
            document.getElementById("flexRadioCycleWalkDrive_CarIconsm").src = "../../images/cariconorange.png";
            document.getElementById("flexRadioPublicDrive_BusIconsm").src = "../../images/busiconorange.png";
            document.getElementById("flexRadioPublicDrive_CarIconsm").src = "../../images/cariconorange.png";
            break;
    } 
}