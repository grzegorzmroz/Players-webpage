$(document).ready(function () {
    ReturnPageCount();
    Refresh(1);

    $(".input-group-append").click(function () {
        var content = $("input.form-control").val();

        Refresh(1, content)

    });
});




function Refresh(t, content) {
    $.ajax({
        method: "POST",
        url: "../API/PlayersServer.aspx",
        data: { page: t, pcount: 5, filter: content }
    })
        .done(function (msg) {

            $("#content").html(msg);

            $("tr.playerLink").click(function () {
                var id = $(this).data("id");


                $.ajax({
                    method: "POST",
                    url: "../API/PlayerDetailsServer.aspx",
                    data: { id: id }
                })
                    .done(function (msg) {

                        $("#playerDetails").html(msg);
                    });


            });

        });
}
function ReturnPageCount() {
    $.ajax({
        method: "POST",
        url: "../API/PageCountServer.aspx",
        data: { pcount: 5 }
    })
        .done(function (msg) {
            var pc = parseInt(msg);
            for (var i = 1; i <= pc; i++) {
                $(".pagination").append('<a id="link' + i + '" href="#">' + i + '</a>');
            }

            $("#link" + 1).addClass("active");

            $(".pagination a").click(function () {
                var t = parseInt($(this).html());
                Refresh(t);
                $(".pagination a").removeClass("active");
                $("#link" + t).addClass("active");
            });



        });
}