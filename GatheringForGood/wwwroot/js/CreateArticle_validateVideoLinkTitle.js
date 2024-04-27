function validateVideoLinkTitle() {

    document.getElementById('TitleImageUrl').value = null;
    document.getElementById('TitleImageValidationField').value = null;
    document.getElementById('CardDynamicImage').src = '/images/cardimage.png';

    var ArticleTitleVideoField = document.getElementById("ArticleTitleVideoField");
    var VideoLinkText = ArticleTitleVideoField.value;
    var ArticleTitleVideoValidation = document.getElementById("ArticleTitleVideoValidation");
    var ArticleTitleImageSizeValidation = document.getElementById("ArticleTitleImageSizeValidation");
    ArticleTitleImageSizeValidation.style.display = 'none';
    var ArticleTitleImageTypeValidation = document.getElementById("ArticleTitleImageTypeValidation");
    ArticleTitleImageTypeValidation.style.display = 'none';
    var CardDynamicImageDiv = document.getElementById("CardDynamicImageDiv");
    CardDynamicImageDiv.style.display = 'none';
    var CardDynamicVideoDiv = document.getElementById("CardDynamicVideoDiv");
    CardDynamicVideoDiv.style.display = 'block';

    var urlType = 0;

    if ((VideoLinkText.includes("watch?v=") || VideoLinkText.includes("https://m.youtube") || VideoLinkText.includes("watch?app=desktop&v=")) && !VideoLinkText == "") {
        urlType = 1;
    } else if ((VideoLinkText.includes("embed") && !VideoLinkText == "")) {
        urlType = 2;
    } else if ((VideoLinkText.includes("tu.be") && !VideoLinkText == "")) {
        urlType = 3;
    }
    console.log('title urlType:' + urlType);

    switch (urlType) {
        case 1:
            var endOfString = VideoLinkText.split(/=(.*)/)[1];
            var p = /^(?:https?:\/\/)?(?:m\.|www\.)?(?:youtu\.be\/|youtube\.com\/(?:embed\/|v\/|watch\?v=|watch\?.+&v=))((\w|-){11})(?:\S+)?$/;

            if (VideoLinkText.includes("https://www.") && VideoLinkText.match(p)) {
                stringLength = endOfString.length;
                console.log('title stringLength 2: ' + stringLength);
            } else {
                VideoLinkText = titleProcessVideoUrl(VideoLinkText, true);
                if (VideoLinkText.match(p)) {
                    var endOfString = VideoLinkText.split('/')[4];
                    stringLength = endOfString.length;
                    console.log("new VideoLinkText: " + VideoLinkText)
                }
            }
            console.log('title stringLength 1: ' + stringLength);

            if (!VideoLinkText.match(p)) {
                ArticleTitleVideoValidation.style.display = 'block';
                $("#TitleImageValidationField").val("");
                document.getElementById('CardDynamicVideo').src = '';
                CardDynamicImageDiv.style.display = 'block';
                CardDynamicVideoDiv.style.display = 'none';
            } else {
                ArticleTitleVideoValidation.style.display = 'none';
                $("#TitleImageValidationField").val("Ok");
                console.log("title VideoLinkText 1: " + VideoLinkText)
                var processedUrl = titleProcessVideoUrl(VideoLinkText, true);
                document.getElementById('CardDynamicVideo').src = processedUrl;
                $("#ArticleTitleVideoField").val(processedUrl);
            }

            if (stringLength > 11) {
                ArticleTitleVideoValidation.style.display = 'block';
                $("#TitleImageValidationField").val("");
                document.getElementById('CardDynamicVideo').src = '';
                CardDynamicImageDiv.style.display = 'block';
                CardDynamicVideoDiv.style.display = 'none';
            }
            break;
        case 2:
            var endOfString = VideoLinkText.split('/')[4];
            var p = /^(?:https?:\/\/)?(?:m\.|www\.)?(?:youtu\.be\/|youtube\.com\/(?:embed\/|v\/|watch\?v=|watch\?.+&v=))((\w|-){11})(?:\S+)?$/;

            if (VideoLinkText.includes("https://www.") && VideoLinkText.match(p)) {
                stringLength = endOfString.length;
                console.log('title stringLength 2: ' + stringLength);
            } else {
                VideoLinkText = titleProcessVideoUrl(VideoLinkText, true);
                if (VideoLinkText.match(p)) {
                    var endOfString = VideoLinkText.split('/')[4];
                    stringLength = endOfString.length;
                    console.log("new VideoLinkText: " + VideoLinkText)
                }
            }
            console.log('title stringLength 3: ' + stringLength);

            if (!VideoLinkText.match(p)) {
                console.log('VideoLinkText !match(p): ' + VideoLinkText);
                ArticleTitleVideoValidation.style.display = 'block';
                $("#TitleImageValidationField").val("");
                document.getElementById('CardDynamicVideo').src = '';
                CardDynamicImageDiv.style.display = 'block';
                CardDynamicVideoDiv.style.display = 'none';
            } else {
                ArticleTitleVideoValidation.style.display = 'none';
                $("#TitleImageValidationField").val("Ok");
                console.log("title VideoLinkText 2: " + VideoLinkText)
                var processedUrl = titleProcessVideoUrl(VideoLinkText, true);
                document.getElementById('CardDynamicVideo').src = processedUrl;
                $("#ArticleTitleVideoField").val(processedUrl);
            }

            if (stringLength > 11) {
                console.log('stringLength > 11 if block');
                ArticleTitleVideoValidation.style.display = 'block';
                $("#TitleImageValidationField").val("");
                document.getElementById('CardDynamicVideo').src = '';
                CardDynamicImageDiv.style.display = 'block';
                CardDynamicVideoDiv.style.display = 'none';
            }
            break;
        case 3:
            var endOfString = VideoLinkText.split('/')[3];
            var p = /^(?:https?:\/\/)?(?:m\.|www\.)?(?:youtu\.be\/|youtube\.com\/(?:embed\/|v\/|watch\?v=|watch\?.+&v=))((\w|-){11})(?:\S+)?$/;

            if (VideoLinkText.includes("https://youtu.be/") && VideoLinkText.match(p)) {
                stringLength = endOfString.length;
                console.log('title stringLength 4: ' + stringLength);
            } else {
                VideoLinkText = titleProcessVideoUrl(VideoLinkText, true);
                if (VideoLinkText.match(p)) {
                    var endOfString = VideoLinkText.split('/')[3];
                    stringLength = endOfString.length;
                    console.log("new VideoLinkText: " + VideoLinkText)
                }
            }
            console.log('title stringLength 5: ' + stringLength);
            if (!VideoLinkText.match(p)) {
                console.log('VideoLinkText !match(p) 1: ' + VideoLinkText);
                ArticleTitleVideoValidation.style.display = 'block';
                $("#TitleImageValidationField").val("");
                document.getElementById('CardDynamicVideo').src = '';
                CardDynamicImageDiv.style.display = 'block';
                CardDynamicVideoDiv.style.display = 'none';
            } else {
                ArticleTitleVideoValidation.style.display = 'none';
                $("#TitleImageValidationField").val("Ok");
                document.getElementById('CardDynamicVideo').src = VideoLinkText;
                console.log("title VideoLinkText 3: " + VideoLinkText)
                var processedUrl = titleProcessVideoUrl(VideoLinkText, false);
                document.getElementById('CardDynamicVideo').src = processedUrl;
                $("#ArticleTitleVideoField").val(processedUrl);
            }

            if (stringLength > 11) {
                console.log('stringLength > 11 if block 1');
                ArticleTitleVideoValidation.style.display = 'block';
                $("#TitleImageValidationField").val("");
                document.getElementById('CardDynamicVideo').src = '';
                CardDynamicImageDiv.style.display = 'block';
                CardDynamicVideoDiv.style.display = 'none';
            }
            break;
        default:
            console.log('title default');
            var p = /^(?:https?:\/\/)?(?:m\.|www\.)?(?:youtu\.be\/|youtube\.com\/(?:embed\/|v\/|watch\?v=|watch\?.+&v=))((\w|-){11})(?:\S+)?$/;
            if (!VideoLinkText.match(p) && !VideoLinkText == "") {
                console.log('VideoLinkText !match(p) 2: ' + VideoLinkText);
                ArticleTitleVideoValidation.style.display = 'block';
                $("#TitleImageValidationField").val("");
                document.getElementById('CardDynamicVideo').src = '';
                CardDynamicImageDiv.style.display = 'block';
                CardDynamicVideoDiv.style.display = 'none';
            } else {
                ArticleTitleVideoValidation.style.display = 'none';
                $("#TitleImageValidationField").val("");
                var CardDynamicImageDiv = document.getElementById("CardDynamicImageDiv");
                CardDynamicImageDiv.style.display = 'block';
                var CardDynamicVideoDiv = document.getElementById("CardDynamicVideoDiv");
                CardDynamicVideoDiv.style.display = 'none';
            }
    }
}

function titleProcessVideoUrl(rawUrl, notShortSharingUrl) {

    if (notShortSharingUrl) {

        console.log('rawUrl 1: ' + rawUrl)

        if (!rawUrl.includes("https://") && rawUrl.includes("http://")) {
            rawUrl = rawUrl.replace('http://', 'https://')
            console.log('rawUrl 2: ' + rawUrl)
        } else if (!rawUrl.includes("https://") && rawUrl.includes("www.") && !rawUrl.includes("youtu.be")) {
            rawUrl = rawUrl.replace('www.', 'https://www.')
            console.log('rawUrl 3: ' + rawUrl)
        } else if (rawUrl.includes("https://") && !rawUrl.includes("www.") && !rawUrl.includes("youtu.be") && !rawUrl.includes("m.youtube")) {
            rawUrl = rawUrl.replace('https://', 'https://www.')
            console.log('rawUrl 4: ' + rawUrl)
        } else if (rawUrl.includes("youtube.com/") && !rawUrl.includes("https://") && !rawUrl.includes("http://") && !rawUrl.includes("m.youtube")) {
            rawUrl = rawUrl.replace('youtube.com/', 'https://www.youtube.com/')
            console.log('rawUrl 5: ' + rawUrl)
        } else if (rawUrl.includes("youtu.be/") && !rawUrl.includes("https://") && !rawUrl.includes("http://") && !rawUrl.includes("www.")) {
            rawUrl = rawUrl.replace('youtu.be/', 'https://youtu.be/')
            console.log('rawUrl 6: ' + rawUrl)
        } else if (rawUrl.includes("youtu.be/") && !rawUrl.includes("https://") && rawUrl.includes("http://")) {
            rawUrl = rawUrl.replace('http://', 'https://')
            console.log('rawUrl 7: ' + rawUrl)
        } else if (rawUrl.includes("https://") && rawUrl.includes("www.youtu.be/")) {
            rawUrl = rawUrl.replace('www.youtu.be/', 'youtu.be/')
            console.log('rawUrl 8: ' + rawUrl)
        } else if (!rawUrl.includes("https://") && rawUrl.includes("www.youtu.be/")) {
            rawUrl = rawUrl.replace('www.youtu.be/', 'https://youtu.be/')
            console.log('rawUrl 9: ' + rawUrl)
        }

        console.log('rawUrl 10: ' + rawUrl)

        var processed = rawUrl.replace('watch?v=', 'embed/')
        console.log('test1: ' + processed);

        if (processed.includes("watch?app=desktop&v=")) {
            processed = rawUrl.replace('watch?app=desktop&v=', 'embed/');
            if (processed.includes("&list=")) {
                processed = processed.split('&list=')[0];
                return processed;
                console.log('title Processed 1a: ' + processed);
            }
        } else if (processed.includes("&list=")) {
            processed = processed.split('&list=')[0];
            return processed;
            console.log('title Processed 1b: ' + processed);
        }
        console.log('title Processed 2: ' + processed);
        return processed;

    } else {
        console.log('rawUrl 1:' + rawUrl)
        if (!rawUrl.includes("https://") && rawUrl.includes("http://")) {
            rawUrl = rawUrl.replace('http://', 'https://')
            console.log('rawUrl 2:' + rawUrl)
        } else if (!rawUrl.includes("https://") && rawUrl.includes("www.")) {
            rawUrl = rawUrl.replace('www.', 'https://www.')
            console.log('rawUrl 3:' + rawUrl)
        }
        console.log('rawUrl 4:' + rawUrl)
        var processed = rawUrl.replace('https://youtu.be/', 'https://www.youtube.com/embed/')
        if (processed.includes("?t=")) {
            processed = processed.split('?t=')[0];
            return processed;
        }

        console.log('title Processed 3: ' + processed);
        return processed;
    }
}