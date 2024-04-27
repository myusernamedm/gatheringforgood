function validateVideoLinkParas(url, sizeError, typeError, urlImage, videoField, videoValidation, urlImageDiv, urlVideoDiv, urlVideo, videoValidationField) {
    console.log("videoValidationField: " + videoValidationField);
    document.getElementById(url).value = null;
    document.getElementById(sizeError).value = null;
    document.getElementById(typeError).value = null;
    document.getElementById(urlImage).src = '/images/cardimage.png';
    var ArticleVideoField = document.getElementById(videoField);
    var VideoLinkText = ArticleVideoField.value;
    var ArticleVideoValidation = document.getElementById(videoValidation);
    var VideoValidationField = document.getElementById(videoValidationField);
    var CreateArticleImageSizeError = document.getElementById(sizeError);
    CreateArticleImageSizeError.style.display = 'none';
    var CreateArticleImageTypeError = document.getElementById(typeError);
    CreateArticleImageTypeError.style.display = 'none';
    var ImageUrlImageDiv = document.getElementById(urlImageDiv);
    ImageUrlImageDiv.style.display = 'none';
    var ImageUrlVideoDiv = document.getElementById(urlVideoDiv);
    ImageUrlVideoDiv.style.display = 'block';

    var urlType = 0;

    if ((VideoLinkText.includes("watch?v=") || VideoLinkText.includes("https://m.youtube") || VideoLinkText.includes("watch?app=desktop&v=")) && !VideoLinkText == "") {
        urlType = 1;
    } else if ((VideoLinkText.includes("embed") && !VideoLinkText == "")) {
        urlType = 2;
    } else if ((VideoLinkText.includes("tu.be") && !VideoLinkText == "")) {
        urlType = 3;
    }
    console.log('para urlType:' + urlType);

    switch (urlType) {
        case 1:
            var endOfString = VideoLinkText.split(/=(.*)/)[1];
            var p = /^(?:https?:\/\/)?(?:m\.|www\.)?(?:youtu\.be\/|youtube\.com\/(?:embed\/|v\/|watch\?v=|watch\?.+&v=))((\w|-){11})(?:\S+)?$/;

            if (VideoLinkText.includes("https://www.") && VideoLinkText.match(p)) {
                stringLength = endOfString.length;
                console.log('title stringLength 2: ' + stringLength);
            } else {
                VideoLinkText = paraProcessVideoUrl(VideoLinkText, true);
                if (VideoLinkText.match(p)) {
                    var endOfString = VideoLinkText.split('/')[4];
                    stringLength = endOfString.length;
                    console.log("new VideoLinkText: " + VideoLinkText)
                }
            }
            console.log("stringLength 1: " + stringLength);

            if (!VideoLinkText.match(p)) {
                ArticleVideoValidation.style.display = 'block';
                $(VideoValidationField).val("");
                document.getElementById(urlVideo).src = '';
                ImageUrlImageDiv.style.display = 'block';
                ImageUrlVideoDiv.style.display = 'none';
            } else {
                ArticleVideoValidation.style.display = 'none';
                $(VideoValidationField).val("Ok");
                console.log("VideoLinkText 1: " + VideoLinkText)
                var processedUrl = paraProcessVideoUrl(VideoLinkText, true);
                document.getElementById(urlVideo).src = processedUrl;
                $("#" + videoField).val(processedUrl);
            }

            if (stringLength > 11) {
                ArticleVideoValidation.style.display = 'block';
                $(VideoValidationField).val("");
                document.getElementById(urlVideo).src = '';
                ImageUrlImageDiv.style.display = 'block';
                ImageUrlVideoDiv.style.display = 'none';
            }
            break;
        case 2:
            var endOfString = VideoLinkText.split('/')[4];
            var p = /^(?:https?:\/\/)?(?:m\.|www\.)?(?:youtu\.be\/|youtube\.com\/(?:embed\/|v\/|watch\?v=|watch\?.+&v=))((\w|-){11})(?:\S+)?$/;

            if (VideoLinkText.includes("https://www.") && VideoLinkText.match(p)) {
                stringLength = endOfString.length;
                console.log('title stringLength 2: ' + stringLength);
            } else {
                VideoLinkText = paraProcessVideoUrl(VideoLinkText, true);
                if (VideoLinkText.match(p)) {
                    var endOfString = VideoLinkText.split('/')[4];
                    stringLength = endOfString.length;
                    console.log("new VideoLinkText: " + VideoLinkText)
                }
            }
            console.log('para stringLength 3: ' + stringLength);

            if (!VideoLinkText.match(p)) {
                console.log('VideoLinkText !match(p): ' + VideoLinkText);
                ArticleVideoValidation.style.display = 'block';
                $(VideoValidationField).val("");
                document.getElementById(urlVideo).src = '';
                ImageUrlImageDiv.style.display = 'block';
                ImageUrlVideoDiv.style.display = 'none';
            } else {
                ArticleVideoValidation.style.display = 'none';
                $(VideoValidationField).val("Ok");
                console.log("VideoLinkText 2: " + VideoLinkText)
                var processedUrl = paraProcessVideoUrl(VideoLinkText, true);
                document.getElementById(urlVideo).src = processedUrl;
                $("#" + videoField).val(processedUrl);
            }

            if (stringLength > 11) {
                ArticleVideoValidation.style.display = 'block';
                $(VideoValidationField).val("");
                document.getElementById(urlVideo).src = '';
                ImageUrlImageDiv.style.display = 'block';
                ImageUrlVideoDiv.style.display = 'none';
            }
            break;
        case 3:
            var endOfString = VideoLinkText.split('/')[3];
            var p = /^(?:https?:\/\/)?(?:m\.|www\.)?(?:youtu\.be\/|youtube\.com\/(?:embed\/|v\/|watch\?v=|watch\?.+&v=))((\w|-){11})(?:\S+)?$/;

            if (VideoLinkText.includes("https://www.") && VideoLinkText.match(p)) {
                stringLength = endOfString.length;
                console.log('para stringLength 4: ' + stringLength);
            } else {
                VideoLinkText = paraProcessVideoUrl(VideoLinkText, true);
                if (VideoLinkText.match(p)) {
                    var endOfString = VideoLinkText.split('/')[3];
                    stringLength = endOfString.length;
                    console.log("new VideoLinkText: " + VideoLinkText)
                }
            }
            console.log('para stringLength 5: ' + stringLength);
            if (!VideoLinkText.match(p)) {
                ArticleVideoValidation.style.display = 'block';
                $(VideoValidationField).val("");
                document.getElementById(urlVideo).src = '';
                ImageUrlImageDiv.style.display = 'block';
                ImageUrlVideoDiv.style.display = 'none';
            } else {
                ArticleVideoValidation.style.display = 'none';
                $(VideoValidationField).val("Ok");
                document.getElementById(urlVideo).src = VideoLinkText;
                var processedUrl = paraProcessVideoUrl(VideoLinkText, false);
                document.getElementById(urlVideo).src = processedUrl;
                $("#" + videoField).val(processedUrl);
                document.getElementById(urlImage).src = '/images/cardimage.png';
            }

            if (stringLength > 11) {
                console.log('stringLength > 11 if block 1');
                ArticleVideoValidation.style.display = 'block';
                $(VideoValidationField).val("");
                document.getElementById(urlVideo).src = '';
                ImageUrlImageDiv.style.display = 'block';
                ImageUrlVideoDiv.style.display = 'none';
            }
            break;
        default:
            console.log('default');
            var p = /^(?:https?:\/\/)?(?:m\.|www\.)?(?:youtu\.be\/|youtube\.com\/(?:embed\/|v\/|watch\?v=|watch\?.+&v=))((\w|-){11})(?:\S+)?$/;
            if (!VideoLinkText.match(p) && !VideoLinkText == "") {
                console.log('VideoLinkText !match(p) 2: ' + VideoLinkText);
                ArticleVideoValidation.style.display = 'block';
                $(VideoValidationField).val("");
                document.getElementById(urlVideo).src = '';
                ImageUrlImageDiv.style.display = 'block';
                ImageUrlVideoDiv.style.display = 'none';
            } else {
                ArticleVideoValidation.style.display = 'none';
                $(VideoValidationField).val("Ok");
                var ImageUrlImageDiv = document.getElementById(urlImageDiv);
                ImageUrlImageDiv.style.display = 'block';
                var ImageUrlVideoDiv = document.getElementById(urlVideoDiv);
                ImageUrlVideoDiv.style.display = 'none';
            }
    }
}

function paraProcessVideoUrl(rawUrl, notShortSharingUrl) {

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
        console.log('test1p: ' + processed);

        if (processed.includes("watch?app=desktop&v=")) {
            processed = rawUrl.replace('watch?app=desktop&v=', 'embed/');
            if (processed.includes("&list=")) {
                processed = processed.split('&list=')[0];
                return processed;
                console.log('para Processed 1a: ' + processed);
            }
        } else if (processed.includes("&list=")) {
            processed = processed.split('&list=')[0];
            return processed;
            console.log('para Processed 1b: ' + processed);
        }
        console.log('para Processed 2: ' + processed);
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

        console.log('para Processed 3: ' + processed);
        return processed;
    }
}