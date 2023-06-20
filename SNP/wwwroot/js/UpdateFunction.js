function update() {
    var dateToShow = document.getElementById("DateToShow").value;
    var wczytajLink = document.getElementById("load");
    wczytajLink.href = '/Installment/GetInstallmentForToday/' + dateToShow;
}

function loadPartialView() {
    var dateToShow = document.getElementById("DateToShow").value;

    var originalDate = new Date(dateToShow); // Utworzenie obiektu Date na podstawie pobranej daty

    var day = originalDate.getDate(); // Pobranie dnia miesi¹ca
    var month = originalDate.getMonth() + 1; // Pobranie numeru miesi¹ca (0-11) i zwiêkszenie o 1, aby odpowiada³ rzeczywistemu numerowi miesi¹ca
    var year = originalDate.getFullYear(); // Pobranie roku

    if (day < 10) {
        day = "0" + day;
    }
    if (month < 10) {
        month = "0" + month;
    }

    var formattedDate = day + "." + month + "." + year; // Sk³adanie sformatowanej daty w formacie "DD-MM-RRRR"

    // Wywo³anie ¿¹dania AJAX
    $.ajax({
        url: '/Installment/GetInstallmentForToday/' + dateToShow,
        type: 'GET',
        success: function (result) {
            // Wczytanie czêœciowego widoku do elementu <div>
            $('#partialViewContainer').html(result);
            $('#titleH2').text(formattedDate);
        },
        error: function (xhr, status, error) {
            // Obs³uga b³êdu
            console.log(error);
        }
    });
}
