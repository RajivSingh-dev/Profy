// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring element project to bundle and minify static web assets.

// Write your JavaScript code.


$(".signup").click(function () {
    window.location.href = "/LinkHub/Register"
});


$("#signin").click(function () {

    var isValid = true;

    $("#invalidLogin").attr("hidden", "true");
    $(".empty-field").attr("hidden", "true");

    var email = $("#email").val();
    var password = $("#password").val();

    var inputCtrlId = $("#email");

    if (email.length == 0)
    {

        inputCtrlId.next().children().removeAttr("hidden");
        isValid = false;
    }
    if (password.length == 0)
    {
        inputCtrlId.closest(".row").next().find(".empty-field").removeAttr("hidden");
        isValid = false;
    }

    
    if (isValid) {
        $.ajax({
            url: "/api/LinkHubApi/Login",
            type: "POST",
            data: JSON.stringify({ Email: email, Password: password }),
            contentType: "application/json",
            success: function (data) {
                window.location.href = '/LinkHub/Home'
            },
            error: function (error) {
                if (error.status == 400) {
                    $("#invalidLogin").text(error.responseText);
                    $("#invalidLogin").removeAttr("hidden");
                }
            }
        }
        )
    }


})

function tooglePassword(element) {

    var type = $(element).prev().attr("type");

    if (type == "password") {
        $(element).prev().attr("type", "text");
    }
    else {
        $(element).prev().attr("type", "password");
    }
    $(element).prev().toggleClass("fa-eye-slash fa-eye");

}