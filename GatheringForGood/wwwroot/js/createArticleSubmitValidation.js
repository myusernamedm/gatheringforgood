$('#CreateArticleForm').submit(function () {
    var btnClicked = document.activeElement.textContent;
    //console.log(btnClicked);

    switch (btnClicked) {
        case 'Submit':
            //console.log('Handler for .submit() called.');

            var CreateArticleBackBtn = document.getElementById("CreateArticleBackBtn");
            var button = document.getElementById("CreateArticleSubmitButton");
            var pbutton = document.getElementById("CreateArticlePreviewButton");
            var ArticleTitleField = document.getElementById("CreateArticleTitleField");
            var TitleImageValidationField = document.getElementById("TitleImageValidationField");
            var ArticleSnippetField = document.getElementById("ArticleSnippetField");
            var Para1Field = document.getElementById("Para1Field");
            var AcceptTandCCheckbox = document.getElementById("AcceptTandCCheckbox");
            var validatorDiv = document.getElementById("ArticleTitleImageValidationDiv");
            var Video2ValidationField = document.getElementById("Video2ValidationField");
            var Video3ValidationField = document.getElementById("Video3ValidationField");
            var Video4ValidationField = document.getElementById("Video4ValidationField");
            var Video5ValidationField = document.getElementById("Video5ValidationField");
            var Video6ValidationField = document.getElementById("Video6ValidationField");
            var Video7ValidationField = document.getElementById("Video7ValidationField");
            var Video8ValidationField = document.getElementById("Video8ValidationField");
            var Video9ValidationField = document.getElementById("Video9ValidationField");
            var Video10ValidationField = document.getElementById("Video10ValidationField");
            var Video11ValidationField = document.getElementById("Video11ValidationField");
            var Video12ValidationField = document.getElementById("Video12ValidationField");
            var Video13ValidationField = document.getElementById("Video13ValidationField");
            var Video14ValidationField = document.getElementById("Video14ValidationField");
            var Video15ValidationField = document.getElementById("Video15ValidationField");
            var Video16ValidationField = document.getElementById("Video16ValidationField");
            var Video17ValidationField = document.getElementById("Video17ValidationField");
            var Video18ValidationField = document.getElementById("Video18ValidationField");
            var Video19ValidationField = document.getElementById("Video19ValidationField");
            var Video20ValidationField = document.getElementById("Video20ValidationField");
            var Video21ValidationField = document.getElementById("Video21ValidationField");
            var Video22ValidationField = document.getElementById("Video22ValidationField");
            var Video23ValidationField = document.getElementById("Video23ValidationField");
            var Video24ValidationField = document.getElementById("Video24ValidationField");
            var Video25ValidationField = document.getElementById("Video25ValidationField");
            var Video26ValidationField = document.getElementById("Video26ValidationField");
            var Video27ValidationField = document.getElementById("Video27ValidationField");
            var Video28ValidationField = document.getElementById("Video28ValidationField");
            var Video29ValidationField = document.getElementById("Video29ValidationField");
            var Video30ValidationField = document.getElementById("Video30ValidationField");
            var Video31ValidationField = document.getElementById("Video31ValidationField");
            var Video32ValidationField = document.getElementById("Video32ValidationField");
            var Video33ValidationField = document.getElementById("Video33ValidationField");
            var Video34ValidationField = document.getElementById("Video34ValidationField");
            var Video35ValidationField = document.getElementById("Video35ValidationField");
            var Video36ValidationField = document.getElementById("Video36ValidationField");
            var Video37ValidationField = document.getElementById("Video37ValidationField");
            var Video38ValidationField = document.getElementById("Video38ValidationField");
            var Video39ValidationField = document.getElementById("Video39ValidationField");
            var Video40ValidationField = document.getElementById("Video40ValidationField");
            var Video41ValidationField = document.getElementById("Video41ValidationField");
            var Video42ValidationField = document.getElementById("Video42ValidationField");
            var Video43ValidationField = document.getElementById("Video43ValidationField");
            var Video44ValidationField = document.getElementById("Video44ValidationField");
            var Video45ValidationField = document.getElementById("Video45ValidationField");
            var Video46ValidationField = document.getElementById("Video46ValidationField");
            var Video47ValidationField = document.getElementById("Video47ValidationField");
            var Video48ValidationField = document.getElementById("Video48ValidationField");
            var Video49ValidationField = document.getElementById("Video49ValidationField");
            var Video50ValidationField = document.getElementById("Video50ValidationField");

            if (ArticleTitleField.value == "" || TitleImageValidationField.value == "" || ArticleSnippetField.value == "" || Para1Field.value == "" || Para1Field.value.length < 300 || !AcceptTandCCheckbox.checked || Video2ValidationField.value == "" || Video3ValidationField.value == "" || Video4ValidationField.value == "" || Video5ValidationField.value == "" || Video6ValidationField.value == "" || Video7ValidationField.value == "" || Video8ValidationField.value == "" || Video9ValidationField.value == "" || Video10ValidationField.value == "" || Video11ValidationField.value == "" || Video12ValidationField.value == "" || Video13ValidationField.value == "" || Video14ValidationField.value == "" || Video15ValidationField.value == "" || Video16ValidationField.value == "" || Video17ValidationField.value == "" || Video18ValidationField.value == "" || Video19ValidationField.value == "" || Video20ValidationField.value == "" || Video21ValidationField.value == "" || Video22ValidationField.value == "" || Video23ValidationField.value == "" || Video24ValidationField.value == "" || Video25ValidationField.value == "" || Video26ValidationField.value == "" || Video27ValidationField.value == "" || Video28ValidationField.value == "" || Video29ValidationField.value == "" || Video30ValidationField.value == "" || Video31ValidationField.value == "" || Video32ValidationField.value == "" || Video33ValidationField.value == "" || Video34ValidationField.value == "" || Video35ValidationField.value == "" || Video36ValidationField.value == "" || Video37ValidationField.value == "" || Video38ValidationField.value == "" || Video39ValidationField.value == "" || Video40ValidationField.value == "" || Video41ValidationField.value == "" || Video42ValidationField.value == "" || Video43ValidationField.value == "" || Video44ValidationField.value == "" || Video45ValidationField.value == "" || Video46ValidationField.value == "" || Video47ValidationField.value == "" || Video48ValidationField.value == "" || Video49ValidationField.value == "" || Video50ValidationField.value == "") {

                button.disabled = false;
                pbutton.disabled = false;
                CreateArticleBackBtn.style.visibility = "visible";
                validatorDiv.style.display = 'block';

                return false;
            } else {

                button.disabled = true;
                pbutton.disabled = true;
                CreateArticleBackBtn.style.visibility = "hidden";

                return true;
            }

            return false;

        case 'Preview':
            //console.log('Handler for .preview() called.');

            var CreateArticleBackBtn = document.getElementById("CreateArticleBackBtn");
            var button = document.getElementById("CreateArticleSubmitButton");
            var pbutton = document.getElementById("CreateArticlePreviewButton");
            var ArticleTitleField = document.getElementById("CreateArticleTitleField");
            var TitleImageValidationField = document.getElementById("TitleImageValidationField");
            var ArticleSnippetField = document.getElementById("ArticleSnippetField");
            var Para1Field = document.getElementById("Para1Field");
            var AcceptTandCCheckbox = document.getElementById("AcceptTandCCheckbox");
            var validatorDiv = document.getElementById("ArticleTitleImageValidationDiv");
            var Video2ValidationField = document.getElementById("Video2ValidationField");
            var Video3ValidationField = document.getElementById("Video3ValidationField");
            var Video4ValidationField = document.getElementById("Video4ValidationField");
            var Video5ValidationField = document.getElementById("Video5ValidationField");
            var Video6ValidationField = document.getElementById("Video6ValidationField");
            var Video7ValidationField = document.getElementById("Video7ValidationField");
            var Video8ValidationField = document.getElementById("Video8ValidationField");
            var Video9ValidationField = document.getElementById("Video9ValidationField");
            var Video10ValidationField = document.getElementById("Video10ValidationField");
            var Video11ValidationField = document.getElementById("Video11ValidationField");
            var Video12ValidationField = document.getElementById("Video12ValidationField");
            var Video13ValidationField = document.getElementById("Video13ValidationField");
            var Video14ValidationField = document.getElementById("Video14ValidationField");
            var Video15ValidationField = document.getElementById("Video15ValidationField");
            var Video16ValidationField = document.getElementById("Video16ValidationField");
            var Video17ValidationField = document.getElementById("Video17ValidationField");
            var Video18ValidationField = document.getElementById("Video18ValidationField");
            var Video19ValidationField = document.getElementById("Video19ValidationField");
            var Video20ValidationField = document.getElementById("Video20ValidationField");
            var Video21ValidationField = document.getElementById("Video21ValidationField");
            var Video22ValidationField = document.getElementById("Video22ValidationField");
            var Video23ValidationField = document.getElementById("Video23ValidationField");
            var Video24ValidationField = document.getElementById("Video24ValidationField");
            var Video25ValidationField = document.getElementById("Video25ValidationField");
            var Video26ValidationField = document.getElementById("Video26ValidationField");
            var Video27ValidationField = document.getElementById("Video27ValidationField");
            var Video28ValidationField = document.getElementById("Video28ValidationField");
            var Video29ValidationField = document.getElementById("Video29ValidationField");
            var Video30ValidationField = document.getElementById("Video30ValidationField");
            var Video31ValidationField = document.getElementById("Video31ValidationField");
            var Video32ValidationField = document.getElementById("Video32ValidationField");
            var Video33ValidationField = document.getElementById("Video33ValidationField");
            var Video34ValidationField = document.getElementById("Video34ValidationField");
            var Video35ValidationField = document.getElementById("Video35ValidationField");
            var Video36ValidationField = document.getElementById("Video36ValidationField");
            var Video37ValidationField = document.getElementById("Video37ValidationField");
            var Video38ValidationField = document.getElementById("Video38ValidationField");
            var Video39ValidationField = document.getElementById("Video39ValidationField");
            var Video40ValidationField = document.getElementById("Video40ValidationField");
            var Video41ValidationField = document.getElementById("Video41ValidationField");
            var Video42ValidationField = document.getElementById("Video42ValidationField");
            var Video43ValidationField = document.getElementById("Video43ValidationField");
            var Video44ValidationField = document.getElementById("Video44ValidationField");
            var Video45ValidationField = document.getElementById("Video45ValidationField");
            var Video46ValidationField = document.getElementById("Video46ValidationField");
            var Video47ValidationField = document.getElementById("Video47ValidationField");
            var Video48ValidationField = document.getElementById("Video48ValidationField");
            var Video49ValidationField = document.getElementById("Video49ValidationField");
            var Video50ValidationField = document.getElementById("Video50ValidationField");

            if (ArticleTitleField.value == "" || TitleImageValidationField.value == "" || ArticleSnippetField.value == "" || Para1Field.value == "" || Para1Field.value.length < 300 || !AcceptTandCCheckbox.checked || Video2ValidationField.value == "" || Video3ValidationField.value == "" || Video4ValidationField.value == "" || Video5ValidationField.value == "" || Video6ValidationField.value == "" || Video7ValidationField.value == "" || Video8ValidationField.value == "" || Video9ValidationField.value == "" || Video10ValidationField.value == "" || Video11ValidationField.value == "" || Video12ValidationField.value == "" || Video13ValidationField.value == "" || Video14ValidationField.value == "" || Video15ValidationField.value == "" || Video16ValidationField.value == "" || Video17ValidationField.value == "" || Video18ValidationField.value == "" || Video19ValidationField.value == "" || Video20ValidationField.value == "" || Video21ValidationField.value == "" || Video22ValidationField.value == "" || Video23ValidationField.value == "" || Video24ValidationField.value == "" || Video25ValidationField.value == "" || Video26ValidationField.value == "" || Video27ValidationField.value == "" || Video28ValidationField.value == "" || Video29ValidationField.value == "" || Video30ValidationField.value == "" || Video31ValidationField.value == "" || Video32ValidationField.value == "" || Video33ValidationField.value == "" || Video34ValidationField.value == "" || Video35ValidationField.value == "" || Video36ValidationField.value == "" || Video37ValidationField.value == "" || Video38ValidationField.value == "" || Video39ValidationField.value == "" || Video40ValidationField.value == "" || Video41ValidationField.value == "" || Video42ValidationField.value == "" || Video43ValidationField.value == "" || Video44ValidationField.value == "" || Video45ValidationField.value == "" || Video46ValidationField.value == "" || Video47ValidationField.value == "" || Video48ValidationField.value == "" || Video49ValidationField.value == "" || Video50ValidationField.value == "") {
                button.disabled = false;
                pbutton.disabled = false;
                CreateArticleBackBtn.style.visibility = "visible";
                validatorDiv.style.display = 'block';
                return false;
            } else {

                return true;
            }

            return false;
    }

});