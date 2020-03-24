

$(document).ready(function () {
    $("form").submit(function (e) {
        e.preventDefault();
        $.ajax({
            url: "api/reservation",
            contentType: "application/json",
            method: "POST",
            data: JSON.stringify({
                guestName: this.elements["GuestName"].value,
                email: this.elements["Email"].value,
                numberOfGuests: this.elements["NumberOfGuests"].value
            }),
            success: function (data) {
                addTableRow(data);
            }
        })
    });
});

var addTableRow = function (reservation) {
    $("table tbody").append(
        "<tr><td>" + reservation.reservationId + "</td><td>" + reservation.guestName + "</td><td>"
        + reservation.email + "</td><td>" + reservation.numberOfGuests + "</td></tr>");
}