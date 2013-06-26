var userHelper = (function () {
    function htmlReplace(value) {
        value = value.replace(/\</g, '&lt;');
        value = value.replace(/\>/g, '&gt;');

        return value;
    }

    var validateRegistration = function () {
        if (validateEmail() &&
            validatePass() &&
            validateFName() &&
            validateLName() &&
            validateGender() &&
            validateAge() &&
            validateWeight() &&
            validateHeight() &&
            validateActivity())
            return true;
        return false;

    };

    var validateLogin = function () {
        if (validateLoginEmail() &&
            validateLoginPass())
            return true;
        return false;

    };

    function validateEmail() {
        var email = $("#reg_email").val();
        email = htmlReplace(email);
        var regex = /^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
        if (!regex.test(email)) {
            $("#valid_email").css("display", "block");
            $("#reg_email").css("border-color", "red");
            return false;
        }
        else {
            $("#valid_email").css("display", "none");
            $("#reg_email").css("border-color", "gray");
            return true;
        }
    }

    function validateLoginEmail() {
        var login_email = $("#login_email").val();
        login_email = htmlReplace(login_email);
        var regex = /^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
        if (!regex.test(login_email)) {
            $("#valid_login_email").css("display", "block");
            $("#login_email").css("border-color", "red");
            return false;
        }
        else {
            $("#valid_login_email").css("display", "none");
            $("#login_email").css("border-color", "gray");
            return true;
        }
    }

    function validatePass() {
        var pass = $("#pass").val();
        pass = htmlReplace(pass);
        if (!pass || pass.length < 6) {
            $("#valid_pass").css("display", "block");
            $("#pass").css("border-color", "red");
            return false;
        }
        else {
            $("#valid_pass").css("display", "none");
            $("#pass").css("border-color", "gray");
            return true;
        }
    }

    function validateLoginPass() {
        var login_pass = $("#login_pass").val();
        login_pass = htmlReplace(login_pass);
        if (!login_pass || login_pass.length < 6) {
            $("#valid_login_pass").css("display", "block");
            $("#login_pass").css("border-color", "red");
            return false;
        }
        else {
            $("#valid_login_pass").css("display", "none");
            $("#login_pass").css("border-color", "gray");
            return true;
        }
    }

    function validateFName() {
        var fname = $("#fname").val();
        fname = htmlReplace(fname);
        if (!fname) {
            $("#valid_fname").css("display", "block");
            $("#fname").css("border-color", "red");
            return false;
        }
        else {
            $("#valid_fname").css("display", "none");
            $("#fname").css("border-color", "gray");
            return true;
        }
    }

    function validateLName() {
        var lname = $("#lname").val();
        lname = htmlReplace(lname);
        if (!lname) {
            $("#valid_lname").css("display", "block");
            $("#lname").css("border-color", "red");
            return false;
        }
        else {
            $("#valid_lname").css("display", "none");
            $("#lname").css("border-color", "gray");
            return true;
        }
    }

    function validateGender() {
        var gender = $("#gender input[name='sex']:radio:checked").val();;
        if (!gender) {
            $("#valid_gender").css("display", "block");
            return false;
        }
        else {
            $("#valid_gender").css("display", "none");
            return true;
        }
    }

    function validateAge() {
        var age = $("#age").val();
        age = htmlReplace(age);
        age = parseInt(age);
        if (!age || age < 10 || age > 65) {
            $("#valid_age").css("display", "block");
            $("#age").css("border-color", "red");
            return false;
        }
        else {
            $("#valid_age").css("display", "none");
            $("#age").css("border-color", "gray");
            return true;
        }
    }

    function validateWeight() {
        var weight = $("#weight").val();
        weight = htmlReplace(weight);
        weight = parseInt(weight);
        if (!weight || weight < 20 || weight > 500) {
            $("#valid_weight").css("display", "block");
            $("#weight").css("border-color", "red");
            return false;
        }
        else {
            $("#valid_weight").css("display", "none");
            $("#weight").css("border-color", "gray");
            return true;
        }
    }

    function validateHeight() {
        var height = $("#height").val();
        height = htmlReplace(height);
        height = parseInt(height);
        if (!height || height < 70 || height > 250) {
            $("#valid_height").css("display", "block");
            $("#height").css("border-color", "red");
            return false;
        }
        else {
            $("#valid_height").css("display", "none");
            $("#height").css("border-color", "gray");
            return true;
        }
    }

    function validateActivity() {
        var activity = $("#activity option:selected").val();
        activity = htmlReplace(activity);
        activity = parseFloat(activity);
        if (!activity) {
            $("#valid_activity").css("display", "block");
            return false;
        }
        else {
            $("#valid_activity").css("display", "none");
            return true;
        }
    }

    return {
        validateRegistration: validateRegistration,
        validateLogin: validateLogin,
    }
})();