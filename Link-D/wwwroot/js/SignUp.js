

function validateForm() {
    // Get the form inputs
    var name = $("#name").val();
    var email = $("#email").val();
    var password = $("#password").val();
    var confirmPassword = $("#confirm-password").val();
    var gender = $("#gender").val();
    var termsAndConditions = $("#terms-and-conditions").prop("checked");

    // Initialize the error variables
    var nameError = "";
    var emailError = "";
    var passwordError = "";
    var confirmPasswordError = "";
    var genderError = "";
    var termsAndConditionsError = "";

    // Initialize the regex patterns
    var namePattern = /^[a-zA-Z ]+$/;
    var emailPattern = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;

    // Validate the name input
    if (name == "") {
        nameError = "Name is required";
    } else if (!namePattern.test(name)) {
        nameError = "Name must contain only letters and spaces";
    }

    // Validate the email input
    if (email == "") {
        emailError = "Email is required";
    }

}


        $(document).ready(function () {
                var forms = $('.needs-validation');
        // Loop over them and prevent submission
        forms.each(function () {
            $(this).on('submit', function (event) {
                if ($(this).get(0).checkValidity() === false) {
                    event.preventDefault();
                }
                $(this).addClass('was-validated');
            });
                });
            });