
function inputFunction(element) {

    var text = $(element).val();

    if (text === "")
        $(element).closest('.modal-body').next().children().attr("disabled", true);
    else
        $(element).closest('.modal-body').next().children().removeAttr("disabled");



}

function submitPostData(element) {
    var text = $(element).parent().prev().find("textarea").val();

    $.ajax({    
        url: "/api/PostApi/Save",
        type: "Post",
        data: JSON.stringify(text),
        contentType: "application/json",
        success: function (data) {
            window.location.href = "/LinkHub/Home"
        },
        error: function (error) {
            if (error.status == 409) {
                $("#emailExistsError").text(error.responseText);
                $("#emailExistsError").removeAttr("hidden");
            }


        }
    }
    )

}