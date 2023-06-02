

function getPosts() {
    $.ajax({
        url: "/api/LinkHubApi/Activity",
        type: "GET",
        contentType: "application/json",
        success: function (data) {
            $("#postsDiv").append(data);
        },
        error: function (error) {
            if (error.status == 400) {
                $("#invalidLogin").text(error.responseText);
                $("#invalidLogin").removeAttr("hidden");
            }
        }
    })
}

