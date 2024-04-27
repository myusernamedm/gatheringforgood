function updateLikes(num, uniqueRef) {

    $.ajax({
        type: "POST",
        url: "UserReaction?actionNumber=" + num +"&uniqueRefNumber=" + uniqueRef,
        dataType: "json",

        success: function (result) {
            var likes = result[0];
            var dislikes = result[1];
            var support = result[2];
            var question = result[3];
            var shocked = result[4];

            document.getElementById("LikeIconCount_" + uniqueRef + " _1").innerHTML = likes;
            document.getElementById("DislikeIconCount_" + uniqueRef + " _2").innerHTML = dislikes;
            document.getElementById("SupportIconCount_" + uniqueRef + " _3").innerHTML = support;
            document.getElementById("QuestionIconCount_" + uniqueRef + " _4").innerHTML = question;
            document.getElementById("ShockedIconCount_" + uniqueRef + " _5").innerHTML = shocked;
        },
        error: function (req, status, error) {

        }
    });
}