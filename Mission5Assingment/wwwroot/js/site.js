// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$("#btn-calculate").click(function () {
    $('#totalCharge').val(''); // Clear the value of totalCharge

    let myRate = 1499.99;
    let numHours = parseFloat($('#hours').val());

    // Validation for number and positive number
    if (!isNaN(numHours) && numHours > 0) {
        let charge = (myRate * numHours).toFixed(2);
        $('#totalCharge').val(charge);
    }
    else {
        alert('Please enter a valid number of hours');
    }
})
