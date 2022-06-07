$(document).ready(function () {

    $("#btnSave").click(function () {

        var id = $("#txtPlayerId").val();
        var name = $("#txtName").val();
        var surname = $("#txtSurname").val();
        var nationality = $("#txtNationality").val();
        var height = $("#txtHeight").val();
        var weight = $("#txtWeight").val();
        var birth = $("#txtBirthDate").val();

        $.ajax({
            method: "POST",
            url: "../API/PlayerEdit.aspx",
            data: { id: id, name: name, surname: surname, nationality: nationality, height: height, weight: weight, birth: birth }
        })
            .done(function (msg) {
                Refresh();
                $("#playerDetails").html("");
            });

    });


    $("#btnDelete").click(function () {

        var id = $("#txtPlayerId").val();
        var name = $("#txtName").val();
        var surname = $("#txtsurname").val();
        $.ajax({
            method: "POST",
            url: "../API/PlayerDelete.aspx",
            data: { id: id }
        })
            .done(function (msg) {

                Refresh();
                $("#playerDetails").html("");
            });


    });




});