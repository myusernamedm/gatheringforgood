function populateInfoFields(pname) {

    sessionStorage.setItem("activepage", pname);
    updateUI();
}

$(function () {
    var pname = sessionStorage.getItem("activepage");

    var existingNameValue = $("#InfoPageExistingFirstNameInputField").val();
    var existingSurnameValue = $("#InfoPageExistingSurNameInputField").val();
    var existingAgeValue = $("#InfoPageExistingAgeInputField").val();
    var existingCountryValue = $("#InfoPageExistingCountryInputField").val();
    var existingRegionValue = $("#InfoPageExistingRegionInputField").val();
    var existingCompanyValue = $("#InfoPageExistingCompanyInputField").val();
    var existingSkillsValue = $("#InfoPageExistingSkillInputField").val();
    var existingInterestValue = $("#InfoPageExistingAreaOfInterestInputField").val();
    var existingMarketingValue = $("#InfoPageMarketingExistingCheckboxField").val();
    var existingYourHelpValue = $("#InfoPageHelpOthersExistingCheckboxField").val();
    var existingFeaturesValue = $("#InfoPageFeatureUpdatesExistingCheckboxField").val();
    var existingNewArticlesPostsValue = $("#InfoPageArticlesPostsExistingCheckboxField").val();
    var existingProductUpdatesValue = $("#InfoPageProductNewsExistingCheckboxField").val();
    console.log("existingMarketingValue: " + existingMarketingValue);
    console.log("existingYourHelpValue: " + existingYourHelpValue);
    console.log("existingFeaturesValue: " + existingFeaturesValue);
    console.log("existingNewArticlesPostsValue: " + existingNewArticlesPostsValue);
    console.log("existingProductUpdatesValue: " + existingProductUpdatesValue);

    $("#InfoPageReplaceFirstNameInputField").val(existingNameValue);
    $("#InfoPageReplaceSurNameInputField").val(existingSurnameValue);
    $("#InfoPageReplaceAgeInputField").val(existingAgeValue);
    $("#InfoPageReplaceCountryHiddenInputField").val(existingCountryValue);
    $("#InfoPageReplaceRegionHiddenInputField").val(existingRegionValue);
    $("#InfoPageReplaceCompanyNameInputField").val(existingCompanyValue);
    $("#InfoPageReplaceSkillInputField").val(existingSkillsValue);
    $("#InfoPageReplaceAreaOfInterestInputField").val(existingInterestValue);
    $("#InfoPageNewMarketingCheckboxHiddenInputField").val(existingMarketingValue);
    $("#InfoPageNewHelpOthersCheckboxHiddenInputField").val(existingYourHelpValue);
    $("#InfoPageNewFeatureUpdatesCheckboxHiddenInputField").val(existingFeaturesValue);
    $("#InfoPageNewArticlesPostsCheckboxHiddenInputField").val(existingNewArticlesPostsValue);
    $("#InfoPageNewProductNewsCheckboxHiddenInputField").val(existingProductUpdatesValue);

    if (existingMarketingValue == "true") {
        document.getElementById('InfoPageInput_MarketingComms').checked = true;
    } else {
        document.getElementById('InfoPageInput_MarketingComms').checked = false;
    }
    if (existingYourHelpValue == "true") {
        document.getElementById('InfoPageInput_HelpOthers').checked = true;
    } else {
        document.getElementById('InfoPageInput_HelpOthers').checked = false;
    }
    if (existingFeaturesValue == "true") {
        document.getElementById('InfoPageInput_FeatureUpdates').checked = true;
    } else {
        document.getElementById('InfoPageInput_FeatureUpdates').checked = false;
    }
    if (existingNewArticlesPostsValue == "true") {
        document.getElementById('InfoPageInput_ArticlesPosts').checked = true;
    } else {
        document.getElementById('InfoPageInput_ArticlesPosts').checked = false;
    }
    if (existingProductUpdatesValue == "true") {
        document.getElementById('InfoPageInput_ProductNews').checked = true;
    } else {
        document.getElementById('InfoPageInput_ProductNews').checked = false;
    }

});