/// <reference path="../typings/jquery/jquery.d.ts" />

class SaunaModel {
    public Koodi: string;
    public Tyyppi: string;   
}

function initCreateASauna() {
    $("#CreateASaunaButton").click(function () {

        var koodi: string = $("#Koodi").val();
        var tyyppi: string = $("#Tyyppi").val();


        alert("koodi: " + koodi + ", tyyppi: " + tyyppi);

        var data: SaunaModel = new SaunaModel();
        data.Koodi = koodi;
        data.Tyyppi = tyyppi;
      
        //lähetetään json-muotoista dataa palvelimelle
        $.ajax({
            type: "POST",
            url: "/Luonti/CreateSauna",
            data: JSON.stringify(data),
            contentType: "application/json",
            success: function (data) {
                if (data.success == true) {
                    alert("Sauna Lisätty Tietokantaan.");
                }
                else {
                    alert("There was an error: " + data.error);
                }
            },
            dataType: "json"
        });
    });
}