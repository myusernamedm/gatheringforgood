function populateHiddenCheckboxField(chkBoxId) {

    switch (chkBoxId) {
        case 1:
            var newSelection = document.getElementById("InfoPageInput_MarketingComms");
            $("#InfoPageNewMarketingCheckboxHiddenInputField").val("");
            console.log("newSelection: " + newSelection);
            if (newSelection.checked == true) {
                $("#InfoPageNewMarketingCheckboxHiddenInputField").val("true");
            }
            else {
                $("#InfoPageNewMarketingCheckboxHiddenInputField").val("false");
            }
            break;
        case 2:
            var newSelection = document.getElementById("InfoPageInput_HelpOthers");
            $("#InfoPageNewHelpOthersCheckboxHiddenInputField").val("");
            console.log("newSelection: " + newSelection);
            if (newSelection.checked == true) {
                $("#InfoPageNewHelpOthersCheckboxHiddenInputField").val("true");
            }
            else {
                $("#InfoPageNewHelpOthersCheckboxHiddenInputField").val("false");
            }
            break;
        case 3:
            var newSelection = document.getElementById("InfoPageInput_FeatureUpdates");
            $("#InfoPageNewFeatureUpdatesCheckboxHiddenInputField").val("");
            console.log("newSelection: " + newSelection);
            if (newSelection.checked == true) {
                $("#InfoPageNewFeatureUpdatesCheckboxHiddenInputField").val("true");
            }
            else {
                $("#InfoPageNewFeatureUpdatesCheckboxHiddenInputField").val("false");
            }
            break;
        case 4:
            var newSelection = document.getElementById("InfoPageInput_ArticlesPosts");
            $("#InfoPageNewArticlesPostsCheckboxHiddenInputField").val("");
            console.log("newSelection: " + newSelection);
            if (newSelection.checked == true) {
                $("#InfoPageNewArticlesPostsCheckboxHiddenInputField").val("true");
            }
            else {
                $("#InfoPageNewArticlesPostsCheckboxHiddenInputField").val("false");
            }
            break;
        case 5:
            var newSelection = document.getElementById("InfoPageInput_ProductNews");
            $("#InfoPageNewProductNewsCheckboxHiddenInputField").val("");
            console.log("newSelection: " + newSelection);
            if (newSelection.checked == true) {
                $("#InfoPageNewProductNewsCheckboxHiddenInputField").val("true");
            }
            else {
                $("#InfoPageNewProductNewsCheckboxHiddenInputField").val("false");
            }
            break;
        default:
    }
}