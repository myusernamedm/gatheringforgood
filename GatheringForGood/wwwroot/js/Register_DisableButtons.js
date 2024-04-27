$("#RegisterForm").submit(function () {

    var RegistrationEmailInputField = document.getElementById("RegistrationEmailInputField");
    var RegistrationPasswordInputField = document.getElementById("RegistrationPasswordInputField");
    var RegistrationConfirmPasswordInputField = document.getElementById("RegistrationConfirmPasswordInputField");
    var Input_TOSAgree = document.getElementById("Input_TOSAgree");
    var button = document.getElementById("RegisterButton");

    if (RegistrationEmailInputField.value == "" || RegistrationPasswordInputField.value == "" || RegistrationConfirmPasswordInputField.value == "") {
        button.disabled = false;
        return false;
    } else if (!RegistrationEmailInputField.value == "" && !RegistrationPasswordInputField.value == "" && !RegistrationConfirmPasswordInputField.value == "" && !Input_TOSAgree.checked) {
        button.disabled = false;
        return true;
    }
    else
    {
        button.disabled = true;
        return true;
    }
});