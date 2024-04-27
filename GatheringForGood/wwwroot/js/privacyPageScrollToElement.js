function privacyPageScrollToElement(value) {

    switch (value) {
        case "introduction":
            var elmnt = document.getElementById("PrivacyIntroductionTitle");
            elmnt.scrollIntoView();
            break;
        case "wecollect":
            var elmnt = document.getElementById("DataWeCollectTitle");
            elmnt.scrollIntoView();
            break;
        case "TandC":
            var elmnt = document.getElementById("MessagesPara1");
            elmnt.scrollIntoView();
            break;
        case "weuse":
            var elmnt = document.getElementById("HowWeUseYourDataTitle");
            elmnt.scrollIntoView();
            break;
        case "weshare":
            var elmnt = document.getElementById("HowWeShareInformationTitle");
            elmnt.scrollIntoView();
            break;
        case "choices":
            var elmnt = document.getElementById("ChoicesAndObligationsTitle");
            elmnt.scrollIntoView();
            break;
        case "otherinformation":
            var elmnt = document.getElementById("OtherInformationTitle");
            elmnt.scrollIntoView();
            break;
        default:
            var elmnt = document.getElementById("PrivacyPageBanner");
            elmnt.scrollIntoView();
            break;
    }
}