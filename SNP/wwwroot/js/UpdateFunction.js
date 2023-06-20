function update() {
    var dateToShow = document.getElementById("DateToShow").value;
    var wczytajLink = document.getElementById("load");
    wczytajLink.href = '/Installment/GetInstallmentForToday/' + dateToShow;
}

function loadPartialView() {
    var dateToShow = document.getElementById("DateToShow").value;

    var originalDate = new Date(dateToShow); // Utworzenie obiektu Date na podstawie pobranej daty

    var day = originalDate.getDate(); // Pobranie dnia miesi�ca
    var month = originalDate.getMonth() + 1; // Pobranie numeru miesi�ca (0-11) i zwi�kszenie o 1, aby odpowiada� rzeczywistemu numerowi miesi�ca
    var year = originalDate.getFullYear(); // Pobranie roku

    if (day < 10) {
        day = "0" + day;
    }
    if (month < 10) {
        month = "0" + month;
    }

    var formattedDate = day + "." + month + "." + year; // Sk�adanie sformatowanej daty w formacie "DD-MM-RRRR"

    // Wywo�anie ��dania AJAX
    $.ajax({
        url: '/Installment/GetInstallmentForToday/' + dateToShow,
        type: 'GET',
        success: function (result) {
            // Wczytanie cz�ciowego widoku do elementu <div>
            $('#partialViewContainer').html(result);
            $('#titleH2').text(formattedDate);
        },
        error: function (xhr, status, error) {
            // Obs�uga b��du
            console.log(error);
        }
    });
}
