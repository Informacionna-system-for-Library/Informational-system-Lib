// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$ = jQuery.noConflict();


$(document).ready(function () {

    $('#submit').on('click', function (e) {
        e.preventDefault();
        let name = $("#name").val();
        let password = $("#password").val();

        if (name === "lib-project" && password === "pgs030304") {
            window.location.href = "/Home/HomePage2";
        } else {
            $("#message").text('Невалидни данни за вход!');
        }
    });
    
});