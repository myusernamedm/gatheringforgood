function validationFieldPopulation(elem) {

    switch (elem) {
        case "TitleValidation":
            document.getElementById('TitleImageValidationField').value = document.getElementById('TitleImageUrl').value;
            var ArticleTitleVideoValidation = document.getElementById("ArticleTitleVideoValidation");
            ArticleTitleVideoValidation.style.display = 'none';
            $("#ArticleTitleVideoField").val("");
            var CardDynamicImageDiv = document.getElementById("CardDynamicImageDiv");
            CardDynamicImageDiv.style.display = 'block';
            var CardDynamicVideoDiv = document.getElementById("CardDynamicVideoDiv");
            CardDynamicVideoDiv.style.display = 'none';

            var fi = document.getElementById('TitleImageUrl');
            // Check if any file is selected.
            console.log("***** fi.files.length: " + fi.files.length.toString());
            if (fi.files.length > 0) {
                for (var i = 0; i <= fi.files.length - 1; i++) {

                    var fsize = fi.files.item(i).size;
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('TitleImageUrl').value = null;
                        document.getElementById('TitleImageValidationField').value = "";
                        document.getElementById('CardDynamicImage').src = '/images/cardimage.png';
                        document.getElementById('ArticleTitleImageSizeValidation').style.display = 'block';
                        document.getElementById('ArticleTitleImageTypeValidation').style.display = 'none';
                    } else {
                        document.getElementById('ArticleTitleImageSizeValidation').style.display = 'none';
                        var selectedFileType = document.getElementById('TitleImageUrl').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('ArticleTitleImageTypeValidation').style.display = 'none';
                    } else {
                        document.getElementById('TitleImageUrl').value = null;
                        document.getElementById('TitleImageValidationField').value = "";
                        document.getElementById('CardDynamicImage').src = '/images/cardimage.png';
                        document.getElementById('ArticleTitleImageTypeValidation').style.display = 'block';
                        document.getElementById('ArticleTitleImageSizeValidation').style.display = 'none';
                    }
                }
            } else {
                document.getElementById('TitleImageUrl').value = null;
                document.getElementById('TitleImageValidationField').value = "";
                document.getElementById('CardDynamicImage').src = '/images/cardimage.png';
                document.getElementById('ArticleTitleImageTypeValidation').style.display = 'none';
                document.getElementById('ArticleTitleImageSizeValidation').style.display = 'none';
            }
            break;

        case "Image2Validation":
            var fileInputCase2 = document.getElementById('Image2Url');
            // Check if any file is selected.
            console.log("***** fileInputCase2.files.length: " + fileInputCase2.files.length.toString());
            if (fileInputCase2.files.length > 0) {
                for (var i = 0; i <= fileInputCase2.files.length - 1; i++) {

                    var fsize = fileInputCase2.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image2Url').value = null;
                        document.getElementById('Image2UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage2SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage2TypeError').style.display = 'none';
                        document.getElementById('Video2ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage2SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image2Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage2TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image2Url').value = null;
                        document.getElementById('Image2UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage2TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage2SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video2ValidationField').value = "Ok";
            }
            else
            {
                document.getElementById('Image2Url').value = null;
                document.getElementById('Image2UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage2TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage2SizeError').style.display = 'none';
            }

            break;

        case "Image3Validation":
            var fileInputCase3 = document.getElementById('Image3Url');
            // Check if any file is selected.
            if (fileInputCase3.files.length > 0) {
                for (var i = 0; i <= fileInputCase3.files.length - 1; i++) {

                    var fsize = fileInputCase3.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image3Url').value = null;
                        document.getElementById('Image3UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage3SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage3TypeError').style.display = 'none';
                        document.getElementById('Video3ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage3SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image3Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage3TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image3Url').value = null;
                        document.getElementById('Image3UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage3TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage3SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video3ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image3Url').value = null;
                document.getElementById('Image3UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage3TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage3SizeError').style.display = 'none';
            }
            break;

        case "Image4Validation":
            var fileInputCase4 = document.getElementById('Image4Url');
            // Check if any file is selected.
            if (fileInputCase4.files.length > 0) {
                for (var i = 0; i <= fileInputCase4.files.length - 1; i++) {

                    var fsize = fileInputCase4.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image4Url').value = null;
                        document.getElementById('Image4UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage4SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage4TypeError').style.display = 'none';
                        document.getElementById('Video4ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage4SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image4Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage4TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image4Url').value = null;
                        document.getElementById('Image4UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage4TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage4SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video4ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image4Url').value = null;
                document.getElementById('Image4UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage4TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage4SizeError').style.display = 'none';
            }
            break;

        case "Image5Validation":
            var fileInputCase5 = document.getElementById('Image5Url');
            // Check if any file is selected.
            if (fileInputCase5.files.length > 0) {
                for (var i = 0; i <= fileInputCase5.files.length - 1; i++) {

                    var fsize = fileInputCase5.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image5Url').value = null;
                        document.getElementById('Image5UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage5SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage5TypeError').style.display = 'none';
                        document.getElementById('Video5ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage5SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image5Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage5TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image5Url').value = null;
                        document.getElementById('Image5UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage5TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage5SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video5ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image5Url').value = null;
                document.getElementById('Image5UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage5TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage5SizeError').style.display = 'none';
            }
            break;

        case "Image6Validation":
            var fileInputCase6 = document.getElementById('Image6Url');
            // Check if any file is selected.
            if (fileInputCase6.files.length > 0) {
                for (var i = 0; i <= fileInputCase6.files.length - 1; i++) {

                    var fsize = fileInputCase6.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image6Url').value = null;
                        document.getElementById('Image6UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage6SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage6TypeError').style.display = 'none';
                        document.getElementById('Video6ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage6SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image6Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage6TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image6Url').value = null;
                        document.getElementById('Image6UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage6TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage6SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video6ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image6Url').value = null;
                document.getElementById('Image6UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage6TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage6SizeError').style.display = 'none';
            }
            break;

        case "Image7Validation":
            var fileInputCase7 = document.getElementById('Image7Url');
            // Check if any file is selected.
            if (fileInputCase7.files.length > 0) {
                for (var i = 0; i <= fileInputCase7.files.length - 1; i++) {

                    var fsize = fileInputCase7.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image7Url').value = null;
                        document.getElementById('Image7UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage7SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage7TypeError').style.display = 'none';
                        document.getElementById('Video7ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage7SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image7Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage7TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image7Url').value = null;
                        document.getElementById('Image7UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage7TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage7SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video7ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image7Url').value = null;
                document.getElementById('Image7UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage7TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage7SizeError').style.display = 'none';
            }
            break;

        case "Image8Validation":
            var fileInputCase8 = document.getElementById('Image8Url');
            // Check if any file is selected.
            if (fileInputCase8.files.length > 0) {
                for (var i = 0; i <= fileInputCase8.files.length - 1; i++) {

                    var fsize = fileInputCase8.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image8Url').value = null;
                        document.getElementById('Image8UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage8SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage8TypeError').style.display = 'none';
                        document.getElementById('Video8ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage8SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image8Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage8TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image8Url').value = null;
                        document.getElementById('Image8UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage8TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage8SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video8ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image8Url').value = null;
                document.getElementById('Image8UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage8TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage8SizeError').style.display = 'none';
            }
            break;

        case "Image9Validation":
            var fileInputCase9 = document.getElementById('Image9Url');
            // Check if any file is selected.
            if (fileInputCase9.files.length > 0) {
                for (var i = 0; i <= fileInputCase9.files.length - 1; i++) {

                    var fsize = fileInputCase9.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image9Url').value = null;
                        document.getElementById('Image9UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage9SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage9TypeError').style.display = 'none';
                        document.getElementById('Video9ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage9SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image9Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage9TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image9Url').value = null;
                        document.getElementById('Image9UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage9TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage9SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video9ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image9Url').value = null;
                document.getElementById('Image9UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage9TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage9SizeError').style.display = 'none';
            }
            break;

        case "Image10Validation":
            var fileInputCase10 = document.getElementById('Image10Url');
            // Check if any file is selected.
            if (fileInputCase10.files.length > 0) {
                for (var i = 0; i <= fileInputCase10.files.length - 1; i++) {

                    var fsize = fileInputCase10.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image10Url').value = null;
                        document.getElementById('Image10UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage10SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage10TypeError').style.display = 'none';
                        document.getElementById('Video10ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage10SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image10Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage10TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image10Url').value = null;
                        document.getElementById('Image10UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage10TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage10SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video10ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image10Url').value = null;
                document.getElementById('Image10UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage10TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage10SizeError').style.display = 'none';
            }
            break;

        case "Image11Validation":
            var fileInputCase11 = document.getElementById('Image11Url');
            // Check if any file is selected.
            if (fileInputCase11.files.length > 0) {
                for (var i = 0; i <= fileInputCase11.files.length - 1; i++) {

                    var fsize = fileInputCase11.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image11Url').value = null;
                        document.getElementById('Image11UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage11SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage11TypeError').style.display = 'none';
                        document.getElementById('Video11ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage11SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image11Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage11TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image11Url').value = null;
                        document.getElementById('Image11UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage11TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage11SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video11ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image11Url').value = null;
                document.getElementById('Image11UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage11TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage11SizeError').style.display = 'none';
            }
            break;

        case "Image12Validation":
            var fileInputCase12 = document.getElementById('Image12Url');
            // Check if any file is selected.
            if (fileInputCase12.files.length > 0) {
                for (var i = 0; i <= fileInputCase12.files.length - 1; i++) {

                    var fsize = fileInputCase12.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image12Url').value = null;
                        document.getElementById('Image12UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage12SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage12TypeError').style.display = 'none';
                        document.getElementById('Video12ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage12SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image12Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage12TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image12Url').value = null;
                        document.getElementById('Image12UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage12TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage12SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video12ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image12Url').value = null;
                document.getElementById('Image12UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage12TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage12SizeError').style.display = 'none';
            }
            break;

        case "Image13Validation":
            var fileInputCase13 = document.getElementById('Image13Url');
            // Check if any file is selected.
            if (fileInputCase13.files.length > 0) {
                for (var i = 0; i <= fileInputCase13.files.length - 1; i++) {

                    var fsize = fileInputCase13.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image13Url').value = null;
                        document.getElementById('Image13UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage13SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage13TypeError').style.display = 'none';
                        document.getElementById('Video13ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage13SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image13Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage13TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image13Url').value = null;
                        document.getElementById('Image13UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage13TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage13SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video13ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image13Url').value = null;
                document.getElementById('Image13UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage13TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage13SizeError').style.display = 'none';
            }
            break;

        case "Image14Validation":
            var fileInputCase14 = document.getElementById('Image14Url');
            // Check if any file is selected.
            if (fileInputCase14.files.length > 0) {
                for (var i = 0; i <= fileInputCase14.files.length - 1; i++) {

                    var fsize = fileInputCase14.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image14Url').value = null;
                        document.getElementById('Image14UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage14SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage14TypeError').style.display = 'none';
                        document.getElementById('Video14ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage14SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image14Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage14TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image14Url').value = null;
                        document.getElementById('Image14UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage14TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage14SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video14ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image14Url').value = null;
                document.getElementById('Image14UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage14TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage14SizeError').style.display = 'none';
            }
            break;

        case "Image15Validation":
            var fileInputCase15 = document.getElementById('Image15Url');
            // Check if any file is selected.
            if (fileInputCase15.files.length > 0) {
                for (var i = 0; i <= fileInputCase15.files.length - 1; i++) {

                    var fsize = fileInputCase15.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image15Url').value = null;
                        document.getElementById('Image15UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage15SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage15TypeError').style.display = 'none';
                        document.getElementById('Video15ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage15SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image15Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage15TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image15Url').value = null;
                        document.getElementById('Image15UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage15TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage15SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video15ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image15Url').value = null;
                document.getElementById('Image15UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage15TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage15SizeError').style.display = 'none';
            }
            break;

        case "Image16Validation":
            var fileInputCase16 = document.getElementById('Image16Url');
            // Check if any file is selected.
            if (fileInputCase16.files.length > 0) {
                for (var i = 0; i <= fileInputCase16.files.length - 1; i++) {

                    var fsize = fileInputCase16.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image16Url').value = null;
                        document.getElementById('Image16UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage16SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage16TypeError').style.display = 'none';
                        document.getElementById('Video16ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage16SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image16Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage16TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image16Url').value = null;
                        document.getElementById('Image16UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage16TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage16SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video16ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image16Url').value = null;
                document.getElementById('Image16UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage16TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage16SizeError').style.display = 'none';
            }
            break;

        case "Image17Validation":
            var fileInputCase17 = document.getElementById('Image17Url');
            // Check if any file is selected.
            if (fileInputCase17.files.length > 0) {
                for (var i = 0; i <= fileInputCase17.files.length - 1; i++) {

                    var fsize = fileInputCase17.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image17Url').value = null;
                        document.getElementById('Image17UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage17SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage17TypeError').style.display = 'none';
                        document.getElementById('Video17ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage17SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image17Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage17TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image17Url').value = null;
                        document.getElementById('Image17UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage17TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage17SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video17ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image17Url').value = null;
                document.getElementById('Image17UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage17TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage17SizeError').style.display = 'none';
            }
            break;

        case "Image18Validation":
            var fileInputCase18 = document.getElementById('Image18Url');
            // Check if any file is selected.
            if (fileInputCase18.files.length > 0) {
                for (var i = 0; i <= fileInputCase18.files.length - 1; i++) {

                    var fsize = fileInputCase18.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image18Url').value = null;
                        document.getElementById('Image18UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage18SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage18TypeError').style.display = 'none';
                        document.getElementById('Video18ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage18SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image18Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage18TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image18Url').value = null;
                        document.getElementById('Image18UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage18TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage18SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video18ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image18Url').value = null;
                document.getElementById('Image18UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage18TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage18SizeError').style.display = 'none';
            }
            break;

        case "Image19Validation":
            var fileInputCase19 = document.getElementById('Image19Url');
            // Check if any file is selected.
            if (fileInputCase19.files.length > 0) {
                for (var i = 0; i <= fileInputCase19.files.length - 1; i++) {

                    var fsize = fileInputCase19.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image19Url').value = null;
                        document.getElementById('Image19UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage19SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage19TypeError').style.display = 'none';
                        document.getElementById('Video19ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage19SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image19Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage19TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image19Url').value = null;
                        document.getElementById('Image19UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage19TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage19SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video19ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image19Url').value = null;
                document.getElementById('Image19UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage19TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage19SizeError').style.display = 'none';
            }
            break;

        case "Image20Validation":
            var fileInputCase20 = document.getElementById('Image20Url');
            // Check if any file is selected.
            if (fileInputCase20.files.length > 0) {
                for (var i = 0; i <= fileInputCase20.files.length - 1; i++) {

                    var fsize = fileInputCase20.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image20Url').value = null;
                        document.getElementById('Image20UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage20SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage20TypeError').style.display = 'none';
                        document.getElementById('Video20ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage20SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image20Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage20TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image20Url').value = null;
                        document.getElementById('Image20UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage20TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage20SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video20ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image20Url').value = null;
                document.getElementById('Image20UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage20TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage20SizeError').style.display = 'none';
            }
            break;

        case "Image21Validation":
            var fileInputCase21 = document.getElementById('Image21Url');
            // Check if any file is selected.
            if (fileInputCase21.files.length > 0) {
                for (var i = 0; i <= fileInputCase21.files.length - 1; i++) {

                    var fsize = fileInputCase21.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image21Url').value = null;
                        document.getElementById('Image21UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage21SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage21TypeError').style.display = 'none';
                        document.getElementById('Video21ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage21SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image21Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage21TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image21Url').value = null;
                        document.getElementById('Image21UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage21TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage21SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video21ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image21Url').value = null;
                document.getElementById('Image21UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage21TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage21SizeError').style.display = 'none';
            }
            break;

        case "Image22Validation":
            var fileInputCase22 = document.getElementById('Image22Url');
            // Check if any file is selected.
            if (fileInputCase22.files.length > 0) {
                for (var i = 0; i <= fileInputCase22.files.length - 1; i++) {

                    var fsize = fileInputCase22.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image22Url').value = null;
                        document.getElementById('Image22UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage22SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage22TypeError').style.display = 'none';
                        document.getElementById('Video22ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage22SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image22Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage22TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image22Url').value = null;
                        document.getElementById('Image22UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage22TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage22SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video22ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image22Url').value = null;
                document.getElementById('Image22UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage22TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage22SizeError').style.display = 'none';
            } break;

        case "Image23Validation":
            var fileInputCase23 = document.getElementById('Image23Url');
            // Check if any file is selected.
            if (fileInputCase23.files.length > 0) {
                for (var i = 0; i <= fileInputCase23.files.length - 1; i++) {

                    var fsize = fileInputCase23.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image23Url').value = null;
                        document.getElementById('Image23UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage23SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage23TypeError').style.display = 'none';
                        document.getElementById('Video23ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage23SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image23Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage23TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image23Url').value = null;
                        document.getElementById('Image23UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage23TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage23SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video23ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image23Url').value = null;
                document.getElementById('Image23UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage23TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage23SizeError').style.display = 'none';
            } break;

        case "Image24Validation":
            var fileInputCase24 = document.getElementById('Image24Url');
            // Check if any file is selected.
            if (fileInputCase24.files.length > 0) {
                for (var i = 0; i <= fileInputCase24.files.length - 1; i++) {

                    var fsize = fileInputCase24.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image24Url').value = null;
                        document.getElementById('Image24UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage24SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage24TypeError').style.display = 'none';
                        document.getElementById('Video24ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage24SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image24Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage24TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image24Url').value = null;
                        document.getElementById('Image24UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage24TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage24SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video24ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image24Url').value = null;
                document.getElementById('Image24UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage24TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage24SizeError').style.display = 'none';
            } break;

        case "Image25Validation":
            var fileInputCase25 = document.getElementById('Image25Url');
            // Check if any file is selected.
            if (fileInputCase25.files.length > 0) {
                for (var i = 0; i <= fileInputCase25.files.length - 1; i++) {

                    var fsize = fileInputCase25.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image25Url').value = null;
                        document.getElementById('Image25UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage25SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage25TypeError').style.display = 'none';
                        document.getElementById('Video25ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage25SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image25Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage25TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image25Url').value = null;
                        document.getElementById('Image25UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage25TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage25SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video25ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image25Url').value = null;
                document.getElementById('Image25UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage25TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage25SizeError').style.display = 'none';
            } break;

        case "Image26Validation":
            var fileInputCase26 = document.getElementById('Image26Url');
            // Check if any file is selected.
            if (fileInputCase26.files.length > 0) {
                for (var i = 0; i <= fileInputCase26.files.length - 1; i++) {

                    var fsize = fileInputCase26.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image26Url').value = null;
                        document.getElementById('Image26UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage26SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage26TypeError').style.display = 'none';
                        document.getElementById('Video26ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage26SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image26Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage26TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image26Url').value = null;
                        document.getElementById('Image26UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage26TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage26SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video26ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image26Url').value = null;
                document.getElementById('Image26UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage26TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage26SizeError').style.display = 'none';
            } break;

        case "Image27Validation":
            var fileInputCase27 = document.getElementById('Image27Url');
            // Check if any file is selected.
            if (fileInputCase27.files.length > 0) {
                for (var i = 0; i <= fileInputCase27.files.length - 1; i++) {

                    var fsize = fileInputCase27.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image27Url').value = null;
                        document.getElementById('Image27UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage27SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage27TypeError').style.display = 'none';
                        document.getElementById('Video27ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage27SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image27Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage27TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image27Url').value = null;
                        document.getElementById('Image27UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage27TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage27SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video27ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image27Url').value = null;
                document.getElementById('Image27UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage27TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage27SizeError').style.display = 'none';
            } break;

        case "Image28Validation":
            var fileInputCase28 = document.getElementById('Image28Url');
            // Check if any file is selected.
            if (fileInputCase28.files.length > 0) {
                for (var i = 0; i <= fileInputCase28.files.length - 1; i++) {

                    var fsize = fileInputCase28.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image28Url').value = null;
                        document.getElementById('Image28UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage28SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage28TypeError').style.display = 'none';
                        document.getElementById('Video28ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage28SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image28Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage28TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image28Url').value = null;
                        document.getElementById('Image28UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage28TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage28SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video28ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image28Url').value = null;
                document.getElementById('Image28UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage28TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage28SizeError').style.display = 'none';
            } break;

        case "Image29Validation":
            var fileInputCase29 = document.getElementById('Image29Url');
            // Check if any file is selected.
            if (fileInputCase29.files.length > 0) {
                for (var i = 0; i <= fileInputCase29.files.length - 1; i++) {

                    var fsize = fileInputCase29.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image29Url').value = null;
                        document.getElementById('Image29UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage29SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage29TypeError').style.display = 'none';
                        document.getElementById('Video29ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage29SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image29Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage29TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image29Url').value = null;
                        document.getElementById('Image29UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage29TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage29SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video29ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image29Url').value = null;
                document.getElementById('Image29UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage29TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage29SizeError').style.display = 'none';
            } break;

        case "Image30Validation":
            var fileInputCase30 = document.getElementById('Image30Url');
            // Check if any file is selected.
            if (fileInputCase30.files.length > 0) {
                for (var i = 0; i <= fileInputCase30.files.length - 1; i++) {

                    var fsize = fileInputCase30.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image30Url').value = null;
                        document.getElementById('Image30UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage30SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage30TypeError').style.display = 'none';
                        document.getElementById('Video30ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage30SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image30Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage30TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image30Url').value = null;
                        document.getElementById('Image30UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage30TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage30SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video30ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image30Url').value = null;
                document.getElementById('Image30UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage30TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage30SizeError').style.display = 'none';
            } break;

        case "Image31Validation":
            var fileInputCase31 = document.getElementById('Image31Url');
            // Check if any file is selected.
            if (fileInputCase31.files.length > 0) {
                for (var i = 0; i <= fileInputCase31.files.length - 1; i++) {

                    var fsize = fileInputCase31.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image31Url').value = null;
                        document.getElementById('Image31UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage31SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage31TypeError').style.display = 'none';
                        document.getElementById('Video31ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage31SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image31Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage31TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image31Url').value = null;
                        document.getElementById('Image31UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage31TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage31SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video31ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image31Url').value = null;
                document.getElementById('Image31UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage31TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage31SizeError').style.display = 'none';
            } break;

        case "Image32Validation":
            var fileInputCase32 = document.getElementById('Image32Url');
            // Check if any file is selected.
            if (fileInputCase32.files.length > 0) {
                for (var i = 0; i <= fileInputCase32.files.length - 1; i++) {

                    var fsize = fileInputCase32.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image32Url').value = null;
                        document.getElementById('Image32UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage32SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage32TypeError').style.display = 'none';
                        document.getElementById('Video32ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage32SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image32Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage32TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image32Url').value = null;
                        document.getElementById('Image32UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage32TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage32SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video32ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image32Url').value = null;
                document.getElementById('Image32UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage32TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage32SizeError').style.display = 'none';
            } break;

        case "Image33Validation":
            var fileInputCase33 = document.getElementById('Image33Url');
            // Check if any file is selected.
            if (fileInputCase33.files.length > 0) {
                for (var i = 0; i <= fileInputCase33.files.length - 1; i++) {

                    var fsize = fileInputCase33.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image33Url').value = null;
                        document.getElementById('Image33UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage33SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage33TypeError').style.display = 'none';
                        document.getElementById('Video33ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage33SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image33Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage33TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image33Url').value = null;
                        document.getElementById('Image33UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage33TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage33SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video33ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image33Url').value = null;
                document.getElementById('Image33UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage33TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage33SizeError').style.display = 'none';
            } break;

        case "Image34Validation":
            var fileInputCase34 = document.getElementById('Image34Url');
            // Check if any file is selected.
            if (fileInputCase34.files.length > 0) {
                for (var i = 0; i <= fileInputCase34.files.length - 1; i++) {

                    var fsize = fileInputCase34.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image34Url').value = null;
                        document.getElementById('Image34UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage34SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage34TypeError').style.display = 'none';
                        document.getElementById('Video34ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage34SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image34Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage34TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image34Url').value = null;
                        document.getElementById('Image34UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage34TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage34SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video34ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image34Url').value = null;
                document.getElementById('Image34UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage34TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage34SizeError').style.display = 'none';
            } break;

        case "Image35Validation":
            var fileInputCase35 = document.getElementById('Image35Url');
            // Check if any file is selected.
            if (fileInputCase35.files.length > 0) {
                for (var i = 0; i <= fileInputCase35.files.length - 1; i++) {

                    var fsize = fileInputCase35.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image35Url').value = null;
                        document.getElementById('Image35UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage35SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage35TypeError').style.display = 'none';
                        document.getElementById('Video35ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage35SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image35Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage35TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image35Url').value = null;
                        document.getElementById('Image35UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage35TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage35SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video35ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image35Url').value = null;
                document.getElementById('Image35UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage35TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage35SizeError').style.display = 'none';
            } break;

        case "Image36Validation":
            var fileInputCase36 = document.getElementById('Image36Url');
            // Check if any file is selected.
            if (fileInputCase36.files.length > 0) {
                for (var i = 0; i <= fileInputCase36.files.length - 1; i++) {

                    var fsize = fileInputCase36.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image36Url').value = null;
                        document.getElementById('Image36UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage36SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage36TypeError').style.display = 'none';
                        document.getElementById('Video36ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage36SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image36Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage36TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image36Url').value = null;
                        document.getElementById('Image36UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage36TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage36SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video36ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image36Url').value = null;
                document.getElementById('Image36UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage36TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage36SizeError').style.display = 'none';
            } break;

        case "Image37Validation":
            var fileInputCase37 = document.getElementById('Image37Url');
            // Check if any file is selected.
            if (fileInputCase37.files.length > 0) {
                for (var i = 0; i <= fileInputCase37.files.length - 1; i++) {

                    var fsize = fileInputCase37.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image37Url').value = null;
                        document.getElementById('Image37UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage37SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage37TypeError').style.display = 'none';
                        document.getElementById('Video37ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage37SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image37Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage37TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image37Url').value = null;
                        document.getElementById('Image37UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage37TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage37SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video37ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image37Url').value = null;
                document.getElementById('Image37UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage37TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage37SizeError').style.display = 'none';
            } break;

        case "Image38Validation":
            var fileInputCase38 = document.getElementById('Image38Url');
            // Check if any file is selected.
            if (fileInputCase38.files.length > 0) {
                for (var i = 0; i <= fileInputCase38.files.length - 1; i++) {

                    var fsize = fileInputCase38.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image38Url').value = null;
                        document.getElementById('Image38UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage38SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage38TypeError').style.display = 'none';
                        document.getElementById('Video38ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage38SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image38Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage38TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image38Url').value = null;
                        document.getElementById('Image38UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage38TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage38SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video38ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image38Url').value = null;
                document.getElementById('Image38UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage38TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage38SizeError').style.display = 'none';
            } break;

        case "Image39Validation":
            var fileInputCase39 = document.getElementById('Image39Url');
            // Check if any file is selected.
            if (fileInputCase39.files.length > 0) {
                for (var i = 0; i <= fileInputCase39.files.length - 1; i++) {

                    var fsize = fileInputCase39.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image39Url').value = null;
                        document.getElementById('Image39UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage39SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage39TypeError').style.display = 'none';
                        document.getElementById('Video39ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage39SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image39Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage39TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image39Url').value = null;
                        document.getElementById('Image39UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage39TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage39SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video39ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image39Url').value = null;
                document.getElementById('Image39UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage39TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage39SizeError').style.display = 'none';
            } break;

        case "Image40Validation":
            var fileInputCase40 = document.getElementById('Image40Url');
            // Check if any file is selected.
            if (fileInputCase40.files.length > 0) {
                for (var i = 0; i <= fileInputCase40.files.length - 1; i++) {

                    var fsize = fileInputCase40.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image40Url').value = null;
                        document.getElementById('Image40UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage40SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage40TypeError').style.display = 'none';
                        document.getElementById('Video40ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage40SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image40Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage40TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image40Url').value = null;
                        document.getElementById('Image40UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage40TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage40SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video40ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image40Url').value = null;
                document.getElementById('Image40UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage40TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage40SizeError').style.display = 'none';
            } break;

        case "Image41Validation":
            var fileInputCase41 = document.getElementById('Image41Url');
            // Check if any file is selected.
            if (fileInputCase41.files.length > 0) {
                for (var i = 0; i <= fileInputCase41.files.length - 1; i++) {

                    var fsize = fileInputCase41.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image41Url').value = null;
                        document.getElementById('Image41UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage41SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage41TypeError').style.display = 'none';
                        document.getElementById('Video41ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage41SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image41Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage41TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image41Url').value = null;
                        document.getElementById('Image41UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage41TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage41SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video41ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image41Url').value = null;
                document.getElementById('Image41UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage41TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage41SizeError').style.display = 'none';
            } break;

        case "Image42Validation":
            var fileInputCase42 = document.getElementById('Image42Url');
            // Check if any file is selected.
            if (fileInputCase42.files.length > 0) {
                for (var i = 0; i <= fileInputCase42.files.length - 1; i++) {

                    var fsize = fileInputCase42.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image42Url').value = null;
                        document.getElementById('Image42UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage42SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage42TypeError').style.display = 'none';
                        document.getElementById('Video42ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage42SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image42Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage42TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image42Url').value = null;
                        document.getElementById('Image42UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage42TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage42SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video42ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image42Url').value = null;
                document.getElementById('Image42UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage42TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage42SizeError').style.display = 'none';
            } break;

        case "Image43Validation":
            var fileInputCase43 = document.getElementById('Image43Url');
            // Check if any file is selected.
            if (fileInputCase43.files.length > 0) {
                for (var i = 0; i <= fileInputCase43.files.length - 1; i++) {

                    var fsize = fileInputCase43.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image43Url').value = null;
                        document.getElementById('Image43UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage43SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage43TypeError').style.display = 'none';
                        document.getElementById('Video43ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage43SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image43Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage43TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image43Url').value = null;
                        document.getElementById('Image43UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage43TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage43SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video43ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image43Url').value = null;
                document.getElementById('Image43UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage43TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage43SizeError').style.display = 'none';
            } break;

        case "Image44Validation":
            var fileInputCase44 = document.getElementById('Image44Url');
            // Check if any file is selected.
            if (fileInputCase44.files.length > 0) {
                for (var i = 0; i <= fileInputCase44.files.length - 1; i++) {

                    var fsize = fileInputCase44.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image44Url').value = null;
                        document.getElementById('Image44UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage44SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage44TypeError').style.display = 'none';
                        document.getElementById('Video44ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage44SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image44Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage44TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image44Url').value = null;
                        document.getElementById('Image44UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage44TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage44SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video44ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image44Url').value = null;
                document.getElementById('Image44UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage44TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage44SizeError').style.display = 'none';
            } break;

        case "Image45Validation":
            var fileInputCase45 = document.getElementById('Image45Url');
            // Check if any file is selected.
            if (fileInputCase45.files.length > 0) {
                for (var i = 0; i <= fileInputCase45.files.length - 1; i++) {

                    var fsize = fileInputCase45.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image45Url').value = null;
                        document.getElementById('Image45UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage45SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage45TypeError').style.display = 'none';
                        document.getElementById('Video45ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage45SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image45Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage45TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image45Url').value = null;
                        document.getElementById('Image45UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage45TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage45SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video45ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image45Url').value = null;
                document.getElementById('Image45UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage45TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage45SizeError').style.display = 'none';
            } break;

        case "Image46Validation":
            var fileInputCase46 = document.getElementById('Image46Url');
            // Check if any file is selected.
            if (fileInputCase46.files.length > 0) {
                for (var i = 0; i <= fileInputCase46.files.length - 1; i++) {

                    var fsize = fileInputCase46.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image46Url').value = null;
                        document.getElementById('Image46UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage46SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage46TypeError').style.display = 'none';
                        document.getElementById('Video46ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage46SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image46Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage46TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image46Url').value = null;
                        document.getElementById('Image46UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage46TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage46SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video46ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image46Url').value = null;
                document.getElementById('Image46UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage46TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage46SizeError').style.display = 'none';
            } break;

        case "Image47Validation":
            var fileInputCase47 = document.getElementById('Image47Url');
            // Check if any file is selected.
            if (fileInputCase47.files.length > 0) {
                for (var i = 0; i <= fileInputCase47.files.length - 1; i++) {

                    var fsize = fileInputCase47.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image47Url').value = null;
                        document.getElementById('Image47UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage47SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage47TypeError').style.display = 'none';
                        document.getElementById('Video47ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage47SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image47Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage47TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image47Url').value = null;
                        document.getElementById('Image47UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage47TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage47SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video47ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image47Url').value = null;
                document.getElementById('Image47UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage47TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage47SizeError').style.display = 'none';
            } break;

        case "Image48Validation":
            var fileInputCase48 = document.getElementById('Image48Url');
            // Check if any file is selected.
            if (fileInputCase48.files.length > 0) {
                for (var i = 0; i <= fileInputCase48.files.length - 1; i++) {

                    var fsize = fileInputCase48.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image48Url').value = null;
                        document.getElementById('Image48UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage48SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage48TypeError').style.display = 'none';
                        document.getElementById('Video48ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage48SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image48Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage48TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image48Url').value = null;
                        document.getElementById('Image48UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage48TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage48SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video48ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image48Url').value = null;
                document.getElementById('Image48UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage48TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage48SizeError').style.display = 'none';
            } break;

        case "Image49Validation":
            var fileInputCase49 = document.getElementById('Image49Url');
            // Check if any file is selected.
            if (fileInputCase49.files.length > 0) {
                for (var i = 0; i <= fileInputCase49.files.length - 1; i++) {

                    var fsize = fileInputCase49.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image49Url').value = null;
                        document.getElementById('Image49UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage49SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage49TypeError').style.display = 'none';
                        document.getElementById('Video49ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage49SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image49Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage49TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image49Url').value = null;
                        document.getElementById('Image49UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage49TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage49SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video49ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image49Url').value = null;
                document.getElementById('Image49UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage49TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage49SizeError').style.display = 'none';
            } break;

        case "Image50Validation":
            var fileInputCase50 = document.getElementById('Image50Url');
            // Check if any file is selected.
            if (fileInputCase50.files.length > 0) {
                for (var i = 0; i <= fileInputCase50.files.length - 1; i++) {

                    var fsize = fileInputCase50.files.item(i).size
                    var file = Math.round((fsize / 1024));
                    // The size of the file.
                    if (file >= 2048) {
                        document.getElementById('Image50Url').value = null;
                        document.getElementById('Image50UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage50SizeError').style.display = 'block';
                        document.getElementById('CreateArticleImage50TypeError').style.display = 'none';
                        document.getElementById('Video50ValidationField').value = "Ok";
                    } else {
                        document.getElementById('CreateArticleImage50SizeError').style.display = 'none';
                        var selectedFileType = document.getElementById('Image50Url').value.split('.')[1];
                        selectedFileType = selectedFileType.toLowerCase();
                        var validFileType1 = 'jpg';
                        var validFileType2 = 'jpeg';
                        var validFileType3 = 'png';
                    }

                    if (selectedFileType == validFileType1 || selectedFileType == validFileType2 || selectedFileType == validFileType3) {
                        document.getElementById('CreateArticleImage50TypeError').style.display = 'none';
                    } else {
                        document.getElementById('Image50Url').value = null;
                        document.getElementById('Image50UrlImage').src = '/images/cardimage.png';
                        document.getElementById('CreateArticleImage50TypeError').style.display = 'block';
                        document.getElementById('CreateArticleImage50SizeError').style.display = 'none';
                    }
                }
                document.getElementById('Video50ValidationField').value = "Ok";
            }
            else {
                document.getElementById('Image50Url').value = null;
                document.getElementById('Image50UrlImage').src = '/images/cardimage.png';
                document.getElementById('CreateArticleImage50TypeError').style.display = 'none';
                document.getElementById('CreateArticleImage50SizeError').style.display = 'none';
            } break;
    }
}
