function preview(elementId) {

    switch (elementId) {
        case "CardDynamicImage":
            var fi = document.getElementById('TitleImageUrl');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("CardDynamicImage");
                var validatorDiv = document.getElementById("ArticleTitleImageValidationDiv");
                preview.src = src;
                console.log("***** image src: " + src.toString());
                validatorDiv.style.display = 'none';
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
            }
            break;
        case "Image2UrlImage":
            var fi = document.getElementById('Image2Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image2UrlImage");
                preview.src = src;
                console.log("***** image src: " + src.toString());
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo2Field").value = null;
                var Image2UrlVideoDiv = document.getElementById("Image2UrlVideoDiv");
                Image2UrlVideoDiv.style.display = 'none';
                var Image2UrlImageDiv = document.getElementById("Image2UrlImageDiv");
                Image2UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo2Validation").style.display = 'none';
            }
            break;
        case "Image3UrlImage":
            var fi = document.getElementById('Image3Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image3UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo3Field").value = null;
                var Image3UrlVideoDiv = document.getElementById("Image3UrlVideoDiv");
                Image3UrlVideoDiv.style.display = 'none';
                var Image3UrlImageDiv = document.getElementById("Image3UrlImageDiv");
                Image3UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo3Validation").style.display = 'none';
            }
            break;
        case "Image4UrlImage":
            var fi = document.getElementById('Image4Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image4UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo4Field").value = null;
                var Image4UrlVideoDiv = document.getElementById("Image4UrlVideoDiv");
                Image4UrlVideoDiv.style.display = 'none';
                var Image4UrlImageDiv = document.getElementById("Image4UrlImageDiv");
                Image4UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo4Validation").style.display = 'none';
            }
            break;
        case "Image5UrlImage":
            var fi = document.getElementById('Image5Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image5UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo5Field").value = null;
                var Image5UrlVideoDiv = document.getElementById("Image5UrlVideoDiv");
                Image5UrlVideoDiv.style.display = 'none';
                var Image5UrlImageDiv = document.getElementById("Image5UrlImageDiv");
                Image5UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo5Validation").style.display = 'none';
            }
            break;
        case "Image6UrlImage":
            var fi = document.getElementById('Image6Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image6UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo6Field").value = null;
                var Image6UrlVideoDiv = document.getElementById("Image6UrlVideoDiv");
                Image6UrlVideoDiv.style.display = 'none';
                var Image6UrlImageDiv = document.getElementById("Image6UrlImageDiv");
                Image6UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo6Validation").style.display = 'none';
            }
            break;
        case "Image7UrlImage":
            var fi = document.getElementById('Image7Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image7UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo7Field").value = null;
                var Image7UrlVideoDiv = document.getElementById("Image7UrlVideoDiv");
                Image7UrlVideoDiv.style.display = 'none';
                var Image7UrlImageDiv = document.getElementById("Image7UrlImageDiv");
                Image7UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo7Validation").style.display = 'none';
            }
            break;
        case "Image8UrlImage":
            var fi = document.getElementById('Image8Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image8UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo8Field").value = null;
                var Image8UrlVideoDiv = document.getElementById("Image8UrlVideoDiv");
                Image8UrlVideoDiv.style.display = 'none';
                var Image8UrlImageDiv = document.getElementById("Image8UrlImageDiv");
                Image8UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo8Validation").style.display = 'none';
            }
            break;
        case "Image9UrlImage":
            var fi = document.getElementById('Image9Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image9UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo9Field").value = null;
                var Image9UrlVideoDiv = document.getElementById("Image9UrlVideoDiv");
                Image9UrlVideoDiv.style.display = 'none';
                var Image9UrlImageDiv = document.getElementById("Image9UrlImageDiv");
                Image9UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo9Validation").style.display = 'none';
            }
            break;
        case "Image10UrlImage":
            var fi = document.getElementById('Image10Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image10UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo10Field").value = null;
                var Image10UrlVideoDiv = document.getElementById("Image10UrlVideoDiv");
                Image10UrlVideoDiv.style.display = 'none';
                var Image10UrlImageDiv = document.getElementById("Image10UrlImageDiv");
                Image10UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo10Validation").style.display = 'none';
            }
            break;
        case "Image11UrlImage":
            var fi = document.getElementById('Image11Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image11UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo11Field").value = null;
                var Image11UrlVideoDiv = document.getElementById("Image11UrlVideoDiv");
                Image11UrlVideoDiv.style.display = 'none';
                var Image11UrlImageDiv = document.getElementById("Image11UrlImageDiv");
                Image11UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo11Validation").style.display = 'none';
            }
            break;
        case "Image12UrlImage":
            var fi = document.getElementById('Image12Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image12UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo12Field").value = null;
                var Image12UrlVideoDiv = document.getElementById("Image12UrlVideoDiv");
                Image12UrlVideoDiv.style.display = 'none';
                var Image12UrlImageDiv = document.getElementById("Image12UrlImageDiv");
                Image12UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo12Validation").style.display = 'none';
            }
            break;
        case "Image13UrlImage":
            var fi = document.getElementById('Image13Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image13UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo13Field").value = null;
                var Image13UrlVideoDiv = document.getElementById("Image13UrlVideoDiv");
                Image13UrlVideoDiv.style.display = 'none';
                var Image13UrlImageDiv = document.getElementById("Image13UrlImageDiv");
                Image13UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo13Validation").style.display = 'none';
            }
            break;
        case "Image14UrlImage":
            var fi = document.getElementById('Image14Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image14UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo14Field").value = null;
                var Image14UrlVideoDiv = document.getElementById("Image14UrlVideoDiv");
                Image14UrlVideoDiv.style.display = 'none';
                var Image14UrlImageDiv = document.getElementById("Image14UrlImageDiv");
                Image14UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo14Validation").style.display = 'none';
            }
            break;
        case "Image15UrlImage":
            var fi = document.getElementById('Image15Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image15UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo15Field").value = null;
                var Image15UrlVideoDiv = document.getElementById("Image15UrlVideoDiv");
                Image15UrlVideoDiv.style.display = 'none';
                var Image15UrlImageDiv = document.getElementById("Image15UrlImageDiv");
                Image15UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo15Validation").style.display = 'none';
            }
            break;
        case "Image16UrlImage":
            var fi = document.getElementById('Image16Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image16UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo16Field").value = null;
                var Image16UrlVideoDiv = document.getElementById("Image16UrlVideoDiv");
                Image16UrlVideoDiv.style.display = 'none';
                var Image16UrlImageDiv = document.getElementById("Image16UrlImageDiv");
                Image16UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo16Validation").style.display = 'none';
            }
            break;
        case "Image17UrlImage":
            var fi = document.getElementById('Image17Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image17UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo17Field").value = null;
                var Image17UrlVideoDiv = document.getElementById("Image17UrlVideoDiv");
                Image17UrlVideoDiv.style.display = 'none';
                var Image17UrlImageDiv = document.getElementById("Image17UrlImageDiv");
                Image17UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo17Validation").style.display = 'none';
            }
            break;
        case "Image18UrlImage":
            var fi = document.getElementById('Image18Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image18UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo18Field").value = null;
                var Image18UrlVideoDiv = document.getElementById("Image18UrlVideoDiv");
                Image18UrlVideoDiv.style.display = 'none';
                var Image18UrlImageDiv = document.getElementById("Image18UrlImageDiv");
                Image18UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo18Validation").style.display = 'none';
            }
            break;
        case "Image19UrlImage":
            var fi = document.getElementById('Image19Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image19UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo19Field").value = null;
                var Image19UrlVideoDiv = document.getElementById("Image19UrlVideoDiv");
                Image19UrlVideoDiv.style.display = 'none';
                var Image19UrlImageDiv = document.getElementById("Image19UrlImageDiv");
                Image19UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo19Validation").style.display = 'none';
            }
            break;
        case "Image20UrlImage":
            var fi = document.getElementById('Image20Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image20UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo20Field").value = null;
                var Image20UrlVideoDiv = document.getElementById("Image20UrlVideoDiv");
                Image20UrlVideoDiv.style.display = 'none';
                var Image20UrlImageDiv = document.getElementById("Image20UrlImageDiv");
                Image20UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo20Validation").style.display = 'none';
            }
            break;
        case "Image21UrlImage":
            var fi = document.getElementById('Image21Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image21UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo21Field").value = null;
                var Image21UrlVideoDiv = document.getElementById("Image21UrlVideoDiv");
                Image21UrlVideoDiv.style.display = 'none';
                var Image21UrlImageDiv = document.getElementById("Image21UrlImageDiv");
                Image21UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo21Validation").style.display = 'none';
            }
            break;
        case "Image22UrlImage":
            var fi = document.getElementById('Image22Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image22UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo22Field").value = null;
                var Image22UrlVideoDiv = document.getElementById("Image22UrlVideoDiv");
                Image22UrlVideoDiv.style.display = 'none';
                var Image22UrlImageDiv = document.getElementById("Image22UrlImageDiv");
                Image22UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo22Validation").style.display = 'none';
            }
            break;
        case "Image23UrlImage":
            var fi = document.getElementById('Image23Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image23UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo23Field").value = null;
                var Image23UrlVideoDiv = document.getElementById("Image23UrlVideoDiv");
                Image23UrlVideoDiv.style.display = 'none';
                var Image23UrlImageDiv = document.getElementById("Image23UrlImageDiv");
                Image23UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo23Validation").style.display = 'none';
            }
            break;
        case "Image24UrlImage":
            var fi = document.getElementById('Image24Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image24UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo24Field").value = null;
                var Image24UrlVideoDiv = document.getElementById("Image24UrlVideoDiv");
                Image24UrlVideoDiv.style.display = 'none';
                var Image24UrlImageDiv = document.getElementById("Image24UrlImageDiv");
                Image24UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo24Validation").style.display = 'none';
            }
            break;
        case "Image25UrlImage":
            var fi = document.getElementById('Image25Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image25UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo25Field").value = null;
                var Image25UrlVideoDiv = document.getElementById("Image25UrlVideoDiv");
                Image25UrlVideoDiv.style.display = 'none';
                var Image25UrlImageDiv = document.getElementById("Image25UrlImageDiv");
                Image25UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo25Validation").style.display = 'none';
            }
            break;
        case "Image26UrlImage":
            var fi = document.getElementById('Image26Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image26UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo26Field").value = null;
                var Image26UrlVideoDiv = document.getElementById("Image26UrlVideoDiv");
                Image26UrlVideoDiv.style.display = 'none';
                var Image26UrlImageDiv = document.getElementById("Image26UrlImageDiv");
                Image26UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo26Validation").style.display = 'none';
            }
            break;
        case "Image27UrlImage":
            var fi = document.getElementById('Image27Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image27UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo27Field").value = null;
                var Image27UrlVideoDiv = document.getElementById("Image27UrlVideoDiv");
                Image27UrlVideoDiv.style.display = 'none';
                var Image27UrlImageDiv = document.getElementById("Image27UrlImageDiv");
                Image27UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo27Validation").style.display = 'none';
            }
            break;
        case "Image28UrlImage":
            var fi = document.getElementById('Image28Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image28UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo28Field").value = null;
                var Image28UrlVideoDiv = document.getElementById("Image28UrlVideoDiv");
                Image28UrlVideoDiv.style.display = 'none';
                var Image28UrlImageDiv = document.getElementById("Image28UrlImageDiv");
                Image28UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo28Validation").style.display = 'none';
            }
            break;
        case "Image29UrlImage":
            var fi = document.getElementById('Image29Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image29UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo29Field").value = null;
                var Image29UrlVideoDiv = document.getElementById("Image29UrlVideoDiv");
                Image29UrlVideoDiv.style.display = 'none';
                var Image29UrlImageDiv = document.getElementById("Image29UrlImageDiv");
                Image29UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo29Validation").style.display = 'none';
            }
            break;
        case "Image30UrlImage":
            var fi = document.getElementById('Image30Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image30UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo30Field").value = null;
                var Image30UrlVideoDiv = document.getElementById("Image30UrlVideoDiv");
                Image30UrlVideoDiv.style.display = 'none';
                var Image30UrlImageDiv = document.getElementById("Image30UrlImageDiv");
                Image30UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo30Validation").style.display = 'none';
            }
            break;
        case "Image31UrlImage":
            var fi = document.getElementById('Image31Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image31UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo31Field").value = null;
                var Image31UrlVideoDiv = document.getElementById("Image31UrlVideoDiv");
                Image31UrlVideoDiv.style.display = 'none';
                var Image31UrlImageDiv = document.getElementById("Image31UrlImageDiv");
                Image31UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo31Validation").style.display = 'none';
            }
            break;
        case "Image32UrlImage":
            var fi = document.getElementById('Image32Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image32UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo32Field").value = null;
                var Image32UrlVideoDiv = document.getElementById("Image32UrlVideoDiv");
                Image32UrlVideoDiv.style.display = 'none';
                var Image32UrlImageDiv = document.getElementById("Image32UrlImageDiv");
                Image32UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo32Validation").style.display = 'none';
            }
            break;
        case "Image33UrlImage":
            var fi = document.getElementById('Image33Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image33UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo33Field").value = null;
                var Image33UrlVideoDiv = document.getElementById("Image33UrlVideoDiv");
                Image33UrlVideoDiv.style.display = 'none';
                var Image33UrlImageDiv = document.getElementById("Image33UrlImageDiv");
                Image33UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo33Validation").style.display = 'none';
            }
            break;
        case "Image34UrlImage":
            var fi = document.getElementById('Image34Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image34UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo34Field").value = null;
                var Image34UrlVideoDiv = document.getElementById("Image34UrlVideoDiv");
                Image34UrlVideoDiv.style.display = 'none';
                var Image34UrlImageDiv = document.getElementById("Image34UrlImageDiv");
                Image34UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo34Validation").style.display = 'none';
            }
            break;
        case "Image35UrlImage":
            var fi = document.getElementById('Image35Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image35UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo35Field").value = null;
                var Image35UrlVideoDiv = document.getElementById("Image35UrlVideoDiv");
                Image35UrlVideoDiv.style.display = 'none';
                var Image35UrlImageDiv = document.getElementById("Image35UrlImageDiv");
                Image35UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo35Validation").style.display = 'none';
            }
            break;
        case "Image36UrlImage":
            var fi = document.getElementById('Image36Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image36UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo36Field").value = null;
                var Image36UrlVideoDiv = document.getElementById("Image36UrlVideoDiv");
                Image36UrlVideoDiv.style.display = 'none';
                var Image36UrlImageDiv = document.getElementById("Image36UrlImageDiv");
                Image36UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo36Validation").style.display = 'none';
            }
            break;
        case "Image37UrlImage":
            var fi = document.getElementById('Image37Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image37UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo37Field").value = null;
                var Image37UrlVideoDiv = document.getElementById("Image37UrlVideoDiv");
                Image37UrlVideoDiv.style.display = 'none';
                var Image37UrlImageDiv = document.getElementById("Image37UrlImageDiv");
                Image37UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo37Validation").style.display = 'none';
            }
            break;
        case "Image38UrlImage":
            var fi = document.getElementById('Image38Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image38UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo38Field").value = null;
                var Image38UrlVideoDiv = document.getElementById("Image38UrlVideoDiv");
                Image38UrlVideoDiv.style.display = 'none';
                var Image38UrlImageDiv = document.getElementById("Image38UrlImageDiv");
                Image38UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo38Validation").style.display = 'none';
            }
            break;
        case "Image39UrlImage":
            var fi = document.getElementById('Image39Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image39UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo39Field").value = null;
                var Image39UrlVideoDiv = document.getElementById("Image39UrlVideoDiv");
                Image39UrlVideoDiv.style.display = 'none';
                var Image39UrlImageDiv = document.getElementById("Image39UrlImageDiv");
                Image39UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo39Validation").style.display = 'none';
            }
            break;
        case "Image40UrlImage":
            var fi = document.getElementById('Image40Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image40UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo40Field").value = null;
                var Image40UrlVideoDiv = document.getElementById("Image40UrlVideoDiv");
                Image40UrlVideoDiv.style.display = 'none';
                var Image40UrlImageDiv = document.getElementById("Image40UrlImageDiv");
                Image40UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo40Validation").style.display = 'none';
            }
            break;
        case "Image41UrlImage":
            var fi = document.getElementById('Image41Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image41UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo41Field").value = null;
                var Image41UrlVideoDiv = document.getElementById("Image41UrlVideoDiv");
                Image41UrlVideoDiv.style.display = 'none';
                var Image41UrlImageDiv = document.getElementById("Image41UrlImageDiv");
                Image41UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo41Validation").style.display = 'none';
            }
            break;
        case "Image42UrlImage":
            var fi = document.getElementById('Image42Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image42UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo42Field").value = null;
                var Image42UrlVideoDiv = document.getElementById("Image42UrlVideoDiv");
                Image42UrlVideoDiv.style.display = 'none';
                var Image42UrlImageDiv = document.getElementById("Image42UrlImageDiv");
                Image42UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo42Validation").style.display = 'none';
            }
            break;
        case "Image43UrlImage":
            var fi = document.getElementById('Image43Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image43UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo43Field").value = null;
                var Image43UrlVideoDiv = document.getElementById("Image43UrlVideoDiv");
                Image43UrlVideoDiv.style.display = 'none';
                var Image43UrlImageDiv = document.getElementById("Image43UrlImageDiv");
                Image43UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo43Validation").style.display = 'none';
            }
            break;
        case "Image44UrlImage":
            var fi = document.getElementById('Image44Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image44UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo44Field").value = null;
                var Image44UrlVideoDiv = document.getElementById("Image44UrlVideoDiv");
                Image44UrlVideoDiv.style.display = 'none';
                var Image44UrlImageDiv = document.getElementById("Image44UrlImageDiv");
                Image44UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo44Validation").style.display = 'none';
            }
            break;
        case "Image45UrlImage":
            var fi = document.getElementById('Image45Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image45UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo45Field").value = null;
                var Image45UrlVideoDiv = document.getElementById("Image45UrlVideoDiv");
                Image45UrlVideoDiv.style.display = 'none';
                var Image45UrlImageDiv = document.getElementById("Image45UrlImageDiv");
                Image45UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo45Validation").style.display = 'none';
            }
            break;
        case "Image46UrlImage":
            var fi = document.getElementById('Image46Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image46UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo46Field").value = null;
                var Image46UrlVideoDiv = document.getElementById("Image46UrlVideoDiv");
                Image46UrlVideoDiv.style.display = 'none';
                var Image46UrlImageDiv = document.getElementById("Image46UrlImageDiv");
                Image46UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo46Validation").style.display = 'none';
            }
            break;
        case "Image47UrlImage":
            var fi = document.getElementById('Image47Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image47UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo47Field").value = null;
                var Image47UrlVideoDiv = document.getElementById("Image47UrlVideoDiv");
                Image47UrlVideoDiv.style.display = 'none';
                var Image47UrlImageDiv = document.getElementById("Image47UrlImageDiv");
                Image47UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo47Validation").style.display = 'none';
            }
            break;
        case "Image48UrlImage":
            var fi = document.getElementById('Image48Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image48UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo48Field").value = null;
                var Image48UrlVideoDiv = document.getElementById("Image48UrlVideoDiv");
                Image48UrlVideoDiv.style.display = 'none';
                var Image48UrlImageDiv = document.getElementById("Image48UrlImageDiv");
                Image48UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo48Validation").style.display = 'none';
            }
            break;
        case "Image49UrlImage":
            var fi = document.getElementById('Image49Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image49UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo49Field").value = null;
                var Image49UrlVideoDiv = document.getElementById("Image49UrlVideoDiv");
                Image49UrlVideoDiv.style.display = 'none';
                var Image49UrlImageDiv = document.getElementById("Image49UrlImageDiv");
                Image49UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo49Validation").style.display = 'none';
            }
            break;
        case "Image50UrlImage":
            var fi = document.getElementById('Image50Url');
            if (fi.files.length > 0) {
                var src = URL.createObjectURL(event.target.files[0]);
                var preview = document.getElementById("Image50UrlImage");
                preview.src = src;
                preview.onload = function () {
                    URL.revokeObjectURL(preview.src)
                }
                document.getElementById("ArticleVideo50Field").value = null;
                var Image50UrlVideoDiv = document.getElementById("Image50UrlVideoDiv");
                Image50UrlVideoDiv.style.display = 'none';
                var Image50UrlImageDiv = document.getElementById("Image50UrlImageDiv");
                Image50UrlImageDiv.style.display = 'block';
                document.getElementById("ArticleVideo50Validation").style.display = 'none';
            }
            break;
    }

}