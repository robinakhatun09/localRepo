// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function MyFun() {
    var num = document.myform.Email.value;
    if (a.indexOf('@') <= 0) {
        document.getElementById("message").innerHTML = "**invalid@position";
        return false;
    }
    if (a.charAt(a.length - 4)) {
        document.getElementById("message").innerHTML = "**invalid@position";
        return false;
    }
    if (a.charAt(a.length - 3)) {
        document.getElementById("message").innerHTML = "**invalid@position";
        return false;
    }

    else {
        return true;
    }
}