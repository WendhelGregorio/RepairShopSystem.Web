
function GetServices() {
    $("#tableService").html("<div class='d-flex justify-content-center'>" +
        "<div class='spinner-border' role='status'>" +
        "<span class='visually-hidden'>Loading...</span>" +
        "</div>" +
        "</div>")

    $.get("/shop-services/get-services", function (data, status) {

        var TableContent = "<table class='table'>" +
            "<thead>" +
                "<tr>" +
                    "<th scope='col'>Name</th>" +
                    "<th scope='col'>Type</th>" +
                    "<th scope='col'>Status</th>" +
                    "<th scope='col'>Icon</th>" +
              
                "</tr>" +
            "</thead>";

        for (var i = 0; i < data.length; i++) {
            TableContent += "<tbody>" +
                                 "<tr>" +
                                    "<td>" + data[i].name + "</td>" +
                                    "<td>" + data[i].serviceType + "</td>" +
                                    "<td>"+ "Available" +"</td>" +
                                    "<td scope='row'>" + 
                                            
                                            "<a href='/shop-services/add/" + data[i].id  +"' title='Add'><i class='fas fa-plus'></i></a>" + 
                                            "&nbsp;"+
                                           
                                 "</tr>" +
                            "</tbody>";

        }

        TableContent += "</table>";

        $("#tableService").html(TableContent);

    });
}



function PostBookings() {
    $("#UpdatePanel").html("<div class='text-center'>Please Wait....</div>");
    route = "/shop/get-bookings";
    $.ajax({
        method: "POST",
        url: route,
        data: "{}",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: OnSuccess,
        error: OnError,
    });

}

function OnSuccess(data) {
    var TableContent = "<table class='table'>" +
                            "<tr>" +
                                "<td>Username</td>" +
                                "<td>Date</td>" +
                                "<td>Address</td>" +
                                "<td>Service Name</td>" +
                                "<td>Status</td>" +
                            "</tr>";

    for (var i = 0; i < data.length; i++) {
        TableContent += "<tr>" +
                            "<td>" + data[i].UserName + "</td>" +
                            "<td>" + data[i].UpdateAt + "</td>" +
                            "<td>" + data[i].Address + "</td>" +
                            "<td>" + data[i].ShopServiceName + "</td>" +
                            "<td>" + data[i].ReserveStatus + "</td>" +
                         "</tr>";

    }

    TableContent += "</table>";

    $("#UpdatePanel").html(TableContent);
}

function OnError(data) {
    $("#ErrorText").html(data);
}