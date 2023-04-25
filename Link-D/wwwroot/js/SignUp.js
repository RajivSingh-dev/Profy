
function signUp() {
    $(".empty-field").attr("hidden", "true");
    $(".invalid-text").attr("hidden", "true");

    var fname = $("#firstName").val();
    var lname = $("#lastName").val();
    var email = $("#email").val();
    var password = $("#password").val();
    var confirmPassword = $("#confirmpassword").val();


    var isValid = checkValidity(fname, lname, email, password, confirmPassword);

    var formData = {
        FName: fname,
        LName: lname,
        Email: email,
        Password: password
    };
    if (isValid) {
        $.ajax({
            url: "/api/LinkHubApi/Register",
            type: "Post",
            data: JSON.stringify(formData),
            contentType: "application/json",
            success: function (data) {
                window.location.href = "/LinkHubApi/Home"
            },
            error: function (error) {
                if (error.status == 409)
                {
                    $("#emailExistsError").text(error.responseText);
                    $("#emailExistsError").removeAttr("hidden");
                }   
                    
                    
            }
        }
        )
    }
}

function showError(inputCtrlId,text)
{
    if (text.length == 0)
        $(inputCtrlId).next().find(".empty-field").removeAttr("hidden");
    else
        $(inputCtrlId).next().find(".invalid-text").removeAttr("hidden");;
}

function checkValidity(fname, lname, email, password, confirmPassword)
{

    var isValid = true;
    var namePattern = /^[a-zA-Z]+$/;
    var emailPattern = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;
    var passwordPattern = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$/;


    var isValid = validator("#firstName",fname, namePattern);
    var isValid = validator("#lastName",lname, namePattern);
    var isValid = validator("#email",email, emailPattern);


    
    if (password.length < 8 && !passwordPattern.test(password)) {
        $("#password").next().removeAttr("hidden");
        isValid = false;
        }

    if (password != confirmPassword) {
        $("#confirmpassword").next().removeAttr("hidden");
        isValid = false;

    }

    return isValid;

}

function validator(inputCtrlId,text,pattern)
{
    
    var isValid = true;

    if (text.length == 0) {
        showError(inputCtrlId,text);
        isValid = false;
    }
    else if (!pattern.test(text)) {
        showError(inputCtrlId,text);
        isValid = false;
    }

    return isValid;
}