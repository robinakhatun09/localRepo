$(document).ready(function () {
    $('#usernames').keyup(function () {
        username_check();
    });

    $('#email').keyup(function () {
        email_check();
    });

    $('#phone').keyup(function () {
        mobile_check();
    });

    $('#password').keyup(function () {
        password_check();
    });

    $('#conpassword').keyup(function () {
        conpassword_check();
    });

    function username_check() {
        var user_val = $('#usernames').val();
        var usercheck = $('#usercheck');

        usercheck.empty();

        if (user_val.length == 0) {
            usercheck.show().html("**Please fill the user name").css("color", "red");
        } else if (user_val.length < 3 || user_val.length > 20) {
            usercheck.show().html("**Length must be 3 to 10").css("color", "red");
        } else {
            usercheck.hide();
        }
    }
    function email_check() {
        var email_val = $('#email').val();
        var emailcheck = $('#emailcheck');

        emailcheck.empty();

        var emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

        if (email_val.length === 0) {
            emailcheck.show().html("**Please fill the email").css("color", "red");
        } else if (!emailRegex.test(email_val)) {
            emailcheck.show().html("**Invalid email format").css("color", "red");
        } else {
            emailcheck.hide();
        }
    }

    function mobile_check() {
        var phone_val = $('#phone').val();
        var phonecheck = $('#phonecheck');

        phonecheck.empty();


        var phoneRegex = /^\d{10}$/;
        if (!phoneRegex.test(phone_val)) {
            phonecheck.show().html("**Invalid mobile number").css("color", "red");
        } else {
            phonecheck.hide();
        }
    }

    function password_check() {
        var pass_val = $('#password').val();
        var passcheck = $('#passcheck');

        passcheck.empty();

        var passRegex = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,}$/;

        if (pass_val.length == 0) {
            passcheck.show().html("**Please fill the password").css("color", "red");
        } else if (!passRegex.test(pass_val)) {
            passcheck.show().html("**Password must be at least 6 characters including at least one uppercase letter, one lowercase letter, and one digit.").css("color", "red");
        } else {
            passcheck.hide();
        }
    }

    function conpassword_check() {
        var pass_val = $('#password').val();
        var conpass_val = $('#conpassword').val();
        var conpasscheck = $('#conpasscheck');

        conpasscheck.empty();

        if (conpass_val.length == 0) {
            conpasscheck.show().html("**Please fill the confirm password").css("color", "red");
        } else if (conpass_val !== pass_val) {
            conpasscheck.show().html("**Passwords do not match").css("color", "red");
        } else {
            conpasscheck.hide();
        }
    }
});


