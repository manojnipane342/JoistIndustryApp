$(document).ready(function () {
    $("#lblError").removeClass("success").removeClass("error").text('');
    $('form').each(function () {
        $(this).find('input').keypress(function (e) {
            // Enter pressed?
            if (e.which == 10 || e.which == 13) {
                $("#btn-submit").click();
            }
        });
    });     
    $("#saveClient").on("click", function () {
        $("#lblError").removeClass("success").removeClass("error").text('');
        var retval = true;
        $("#myTable .required").each(function () {
            if (!$(this).val()) {
                $(this).addClass("error");
                retval = false;
            }
            else {
                $(this).removeClass("error");
            }
        });
        var email = $("#email").val().trim();
        var password = $("#password").val().trim();
        if (email && !isEmail(email)) {
            $("#email").addClass("error");
            retval = false;
        }
        if (retval) {
            var data = {
                email: email,
                password: password,
                RememberMe: $('#RememberMe').is(":checked")
            }
            StartProcess();
            $.ajax({
                type: "POST",
                url: "/Account/Login",
                data: { loginVM: data },
                success: function (data) {
                    StopProcess();
                    if (data.status == "Fail") {
                        $("#lblError").addClass("error").text(data.error).show();
                    }
                    else {
                        if (returnUrl != null && returnUrl != "")
                            window.location.href = $('#myForm').data("url");
                        else
                            window.location.href = '/Home/Index';
                    }
                }
            });
        }
    })
});