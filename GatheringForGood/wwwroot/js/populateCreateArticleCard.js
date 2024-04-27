function PopulateCard(elem) {

    switch (elem) {
        case "Title":
            var ArticleTitleField = document.getElementById("CreateArticleTitleField");
            var CardTitleText = ArticleTitleField.value;
            var CreateArticleCardTitle = document.getElementById("CreateArticleCardTitle");
            if (CardTitleText == "") {
                CreateArticleCardTitle.innerText = "Card Title";
            } else {
                CreateArticleCardTitle.innerText = CardTitleText;
            }
            break;
        case "Snippet":
            var ArticleSnippetField = document.getElementById("ArticleSnippetField");
            var CardSnippetText = ArticleSnippetField.value;
            var CreateArticleCardDescription = document.getElementById("CreateArticleCardSnippet");

            if (CardSnippetText == "") {
                CreateArticleCardDescription.innerText = "Card Description";
            } else {
                CreateArticleCardDescription.innerText = CardSnippetText;
            }
            break;
        case "Name":
            var FirstNameFieldText = document.getElementById("FirstNameField").value;
            var LastNameFieldText = document.getElementById("LastNameField").value;
            var CreateArticleCardAuthor = document.getElementById("CreateArticleCardAuthor");
            CreateArticleCardAuthor.innerText = "Author: ";

            if (FirstNameFieldText != "" || LastNameFieldText != "") {
                CreateArticleCardAuthor.innerText = "Author: " + FirstNameFieldText + " " + LastNameFieldText;
            }

            break;
        default:
            break;
    }
}