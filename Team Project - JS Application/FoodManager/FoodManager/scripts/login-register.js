/// <reference path="user-helper.js" />
/// <reference path="kendo/jquery.min.js" />
/// <reference path="classes/User.js" />
(function () {
    $("#reg_btn").on("click", OnRegClick);
    $("#login_btn").on("click", OnLoginClick);

    function createUser() {
        var email = $("#reg_email").val();
        var pass = $("#pass").val();
        var fname = $("#fname").val();
        var lname = $("#lname").val();
        var gender = $("#gender input[name='sex']:radio:checked").val();
        var age = $("#age").val();
        var weight = $("#weight").val();
        var height = $("#height").val();
        var trainings = $("#activity option:selected").val();

        return new users.createUser(email, pass, fname, lname, gender, age, weight, height, trainings);
    }

    function OnRegClick() {
        var isValid = userHelper.validateRegistration();
        if (isValid) {
            var user = createUser();
            if (users.saveUser(user)) {
                $("#valid").css("display", "block");
                $("#invalid").css("display", "none");
            }
            else {
                $("#invalid").css("display", "block");
                $("#valid").css("display", "none");
            }
        }
        else {
            $("#valid").css("display", "none");
            $("#invalid").css("display", "none");
        }
    }

    function OnLoginClick() {
        var isValid = userHelper.validateLogin();
        if (isValid) {
            var login_email = $("#login_email").val();
            var login_pass = $("#login_pass").val();
            var user = users.getUser(login_email, login_pass);
            if (!user) {
                $("#invalid_login").css("display", "block");
            }
            else {
                $("#invalid_login").css("display", "none");
                $("#login_btn").attr('href', 'user_page.html');
                sessionStorage.setObject(login_email, user);
            }
        }
        else {
            $("#invalid_login").css("display", "none");
        }
    }
})();