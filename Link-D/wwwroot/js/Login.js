

$("#signin").click(function () {

    var email = $("#email").val();
    var password = $("#pwd").val();

    var emailPattern = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;

    var isValid = true;

    
    if (!emailPattern.test(email)) {
        emailError = "Enter valid Emaail Id";
        $(".email p").text(emailError);
        $(".email").removeAttr("hidden");
        isValid = false;
    }

    if (isValid) {
        $.ajax({
            url: "/api/LinkHub/Login?email=" + email + "&password=" + password,
            type: "POST",
            contentType: "application/json",
            success: function (data) {
                alert("verified");
            },
            error: function (error) {
                alert("error");
            }
        }
        )
    }

})

$("#togglePassword").click(function () {

    var type = $("#pwd").attr("type");

    if (type == "password")
    {
        $("#pwd").attr("type", "text");
    }
    else {
        $("#pwd").attr("type", "password");
    }
    $("#togglePassword").toggleClass("fa-eye-slash fa-eye");

})