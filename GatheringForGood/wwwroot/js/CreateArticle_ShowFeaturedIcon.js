function showFeaturedIcon() {

    const enteredCode = document.getElementById("FeaturedArticleCodeField").value;
    console.log("enteredCode: " + enteredCode)
    let TreePurchaseCheckedStatus = document.getElementById("TreePurchaseCheckedStatus").value;
    console.log("TreePurchaseCheckedStatus: " + TreePurchaseCheckedStatus)

    if (enteredCode != "") {
        const lastTwoChars = enteredCode.slice(-2);
        const lastFourChars = enteredCode.slice(-4);
        console.log("lastTwoChars: " + lastTwoChars + " | lastFourChars: " + lastFourChars)

        if (lastFourChars == "TPFA") {
            document.getElementById("CreateArticleTreePlantedCardIcon").className = 'display';
            document.getElementById("CreateArticleFeaturedCardIcon").className = 'display';
        } else if (lastTwoChars == "TP") {
            document.getElementById("CreateArticleTreePlantedCardIcon").className = 'display';
        } else if (lastTwoChars == "FA" && lastFourChars != "TPFA") {
            document.getElementById("CreateArticleFeaturedCardIcon").className = 'display';
        } else if (TreePurchaseCheckedStatus == "Y") {
            document.getElementById("CreateArticleFeaturedCardIcon").className = 'hide';
        } else {
            document.getElementById("CreateArticleFeaturedCardIcon").className = 'hide';
            document.getElementById("CreateArticleTreePlantedCardIcon").className = 'hide';
        }
    }
    else
    {
        document.getElementById("CreateArticleFeaturedCardIcon").className = 'hide';

        if (TreePurchaseCheckedStatus != "Y") {
            document.getElementById("CreateArticleTreePlantedCardIcon").className = 'hide';
        }
    }
}