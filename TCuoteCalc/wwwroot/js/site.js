// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$('#chooser').on('change', function () {
    if ($(this).val() === "auto") {
        $("#percentxt").val("12%")
        $('#cal').prop('disabled', false);
    }
    else if ($(this).val() === "hip") {
        $("#percentxt").val("8%")
        $('#cal').prop('disabled', false);
    }
    else if ($(this).val() === "person") {
        $("#percentxt").val("22%")
        $('#cal').prop('disabled', false);
    }
    else if ($(this).val() === "no") {
        $("#percentxt").val("")
        $('#cal').prop('disabled', true);
    }
});
