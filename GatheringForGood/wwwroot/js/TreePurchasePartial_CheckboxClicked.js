function checkboxClicked() {

    let TreePurchaseCheckedStatus = document.getElementById("TreePurchaseCheckedStatus").value;
    const enteredCode = document.getElementById("FeaturedArticleCodeField").value;
    const lastTwoChars = enteredCode.slice(-2);
    const lastFourChars = enteredCode.slice(-4);

    if (TreePurchaseCheckedStatus == "") {
        document.getElementById("TreePurchaseCheckedStatus").value = "Y";

        var src = "../../images/checked.png";
        var preview = document.getElementById("PlantATreePartialCheckedIcon");
        preview.src = src;
        preview.onload = function () {
            URL.revokeObjectURL(preview.src)
        }
        var src1 = "../../images/onetreesmallselected.webp";
        var preview = document.getElementById("OneTreeIconLarge");
        preview.src = src1;
        preview.onload = function () {
            URL.revokeObjectURL(preview.src)
        }
        document.getElementById("SelectPurchaseOption").className = 'form-group';

        document.getElementById("CreateArticleTreePlantedCardIcon").className = 'display';

        var elmnt = document.getElementById("PlantATreePartialCheckedIconGroup");
        elmnt.scrollIntoView();

    } else {
        document.getElementById("TreePurchaseCheckedStatus").value = "";

        var src = "../../images/unchecked.png";
        var preview = document.getElementById("PlantATreePartialCheckedIcon");
        preview.src = src;
        preview.onload = function () {
            URL.revokeObjectURL(preview.src)
        }
        var src1 = "../../images/onetreesmall.webp";
        var preview = document.getElementById("OneTreeIconLarge");
        preview.src = src1;
        preview.onload = function () {
            URL.revokeObjectURL(preview.src)
        }
        document.getElementById("SelectPurchaseOption").className = 'form-group hide';
        if (lastTwoChars != "TP" && lastFourChars != "TPFA") {
            document.getElementById("CreateArticleTreePlantedCardIcon").className = 'hide';
        }
    }

}