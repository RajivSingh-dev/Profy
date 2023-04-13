
function signUp() {
    $(".error-container").attr("hidden", "true");

    var fname = $("#firstName").val();
    var lname = $("#lastName").val();
    var email = $("#email").val();
    var password = $("#password").val();
    var confirmPassword = $("#confirmpassword").val();


    var namePattern = /^[a-zA-Z]+$/;
    var emailPattern = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;
    var passwordPattern = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$/;

    var isValid = true;

    if (fname.length == 0) {
        showError("#firstName", "Please enter a valid first name.");
        isValid = false;
    }
    else if (!namePattern.test(fname)) {
        showError("#firstName", "Name must contain only letters.");
        isValid = false;
    }

    if (lname.length == 0) {
        showError("#lastName", "Please enter a valid last name.");
        isValid = false;
    }
    else if (!namePattern.test(lname)) {
        showError("#lastName", "Name must contain only letters.");
        isValid = false;
    }

    if (!emailPattern.test(email)) {
        showError("#email", "Email must contain @");
        isValid = false;
    }

    if (password.length < 8 && !passwordPattern.test(password)) {
        $("#pwderror").removeAttr("hidden");
        isValid = false;
    }

    if (password != confirmPassword) {
        $("#confirmpass").removeAttr("hidden");
        isValid = false;

    }

    var formData = {
        FName: fname,
        LName: lname,
        Email: email,
        Password: password
    };
    if (isValid) {
        $.ajax({
            url: "/api/LinkHub/Register",
            type: "Post",
            data: JSON.stringify(formData),
            contentType: "application/json",
            success: function (data) {
                alert("submitted");
            },
            error: function (xhr, status, error) {
                alert("An error occurred: " + status + " " + error);
            }
        }
        )
    }
}

function showError(inputCtrlId, msg) {
    $(inputCtrlId).closest("div").find(".error-container").removeAttr("hidden").find(".error-txt").text(msg);
}
