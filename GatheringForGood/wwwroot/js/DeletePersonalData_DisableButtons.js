$("#delete-account-button").on("click", function () {
    var DeleteDataPasswordFieldValue = $("#DeleteDataPasswordField").val();

    if (DeleteDataPasswordFieldValue != "") {
        document.getElementById("delete-account-button").style.pointerEvents = "none";
    }

});
