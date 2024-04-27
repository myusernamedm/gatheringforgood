function carbonOffsetsPageScrollToElement(value) {

    switch (value) {
        case "MyCarbon":
            var elmnt = document.getElementById("OffsetMyCarbonTitle");
            elmnt.scrollIntoView();
            break;
        case "Journey":
            var elmnt = document.getElementById("OffsetAJourneyTitle");
            elmnt.scrollIntoView();
            break;
        case "Tonne":
            var elmnt = document.getElementById("OffsetByTonneTitle");
            elmnt.scrollIntoView();
            break;
        case "Business":
            var elmnt = document.getElementById("OffsetMyBusinessCarbonTitle");
            elmnt.scrollIntoView();
            break;
        default:
            var elmnt = document.getElementById("OffsetMyCarbonTitle");
            elmnt.scrollIntoView();
            break;
    }
}