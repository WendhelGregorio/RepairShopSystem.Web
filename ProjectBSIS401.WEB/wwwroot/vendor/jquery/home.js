
"use strict";


var connection = new signalR.HubConnectionBuilder().withUrl("/signalHub").build();


connection.on("ReceiveNotification", function (userid, message) {
    if (currentUser == userid) {
        new Noty({ theme: 'metroui', type: 'Notification', layout: 'bottomRight', text: message }).show();

    }
});

connection.on("ReceiveMessage", function (userId, shopId, message) {
    if (currentShop == shopId) {
        new Noty({ theme: 'metroui', type: 'Notification', layout: 'bottomRight', text: message }).show();
    }

    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = userId + " says " + msg;
    var li = document.createElement("li");
    li.textContent = encodedMsg;
    document.getElementById("messagesList").appendChild(li);
});


connection.start().then(function () {
    console.log("connection started");
    console.log("Ayos na");
    messageTextBox.disabled = false;
    sendButton.disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

var sendForm = document.getElementById("send-form");
var sendButton = document.getElementById("send-button");
var messagesList = document.getElementById("messages-list");
var messageTextBox = document.getElementById("message-textbox");
var newUserId = document.getElementById("userId");
var newChatId = document.getElementById("chatId");
var newUserName = document.getElementById("userName");

function appendMessage(content, time, date, userid) {
    if (newCurrentUser == userid) {

        var outgoing_msg = document.createElement("div");
        outgoing_msg.classList.add("outgoing_msg");

        var sendmsg = document.createElement("div");
        sendmsg.classList.add("sent_msg");

        var p = document.createElement("p");
        p.appendChild(document.createTextNode(content));

        var span = document.createElement("span");
        span.classList.add("time_date");
        span.appendChild(document.createTextNode(time + "|" + date));

        outgoing_msg.appendChild(sendmsg);
        sendmsg.appendChild(p);
        sendmsg.appendChild(span);

        messagesList.append(outgoing_msg);

    }
    else {
        var incoming_msg = document.createElement("div");
        incoming_msg.classList.add("incoming_msg");

        var incoming_msg_img = document.createElement("div");
        incoming_msg_img.classList.add("incoming_msg_img");

        var image = document.createElement("img");
        image.classList.add("image");
        image.setAttribute("src", "~/userprofile/users/" + userid + "/thumbnail.png");
        image.setAttribute("alt", "user-image");

        var received_msg = document.createElement("div");
        received_msg.classList.add(" received_msg");

        var received_withd_msg = document.createElement("div");
        received_withd_msg.classList.add("received_withd_msg");

        var p = document.createElement("p");
        p.appendChild(document.createTextNode(content));

        var span = document.createElement("span");
        span.classList.add("time_date");
        span.appendChild(document.createTextNode(time + "|" + date));


        incoming_msg.appendChild(incoming_msg_img);
        incoming_msg_img.appendChild(image);
        incoming_msg.appendChild.appendChild(received_msg);
        received_msg.appendChild(received_withd_msg);
        received_withd_msg.appendChild(p);
        received_withd_msg.appendChild(span);

        messagesList.appendChild(incoming_msg);
    }


}

sendForm.addEventListener("submit", function (evt) {
    var message = messageTextBox.value;
    messageTextBox.value = "";
    var newuser = newUserId.value;
    var newchat = newChatId.value;
    var newusername = newUserName.value;

    connection.invoke("Send", message, newuser, newchat, newusername).catch(function (err) {
        return console.error(err.toString());
    });
    evt.preventDefault();
});


connection.on("SendMessage", function (sender, message, time, date, userid, otherusers) {
    appendMessage(sender + ': ' + message, time, date, userid);
    if (currentShopOwner == otherusers) {
        new Noty({ theme: 'metroui', type: 'Notification', layout: 'bottomRight', text: sender + ': ' + message + ' ' + time + ' ' + date }).show();

    }
});

connection.on("SendAction", function (sender, action) {
    console.log(sender + ' ' + action);
    new Noty({ theme: 'metroui', type: 'Notification', layout: 'bottomRight', text: sender + ' ' + action }).show();
    appendMessage(sender + ' ' + action);
});




document.getElementById("sendButton").addEventListener("click", function (event) {
    var userName = document.getElementById("userName").value;
    var userID = document.getElementById("userId").value;
    var shopID = document.getElementById("shopId").value;
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", userId, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
    var obj = {
        UserName: userName,
        UserId: userID,
        ShopId: shopID,
        Message: message
    }
    Send(obj);
});

function Send(obj) {
    var route = "/chat/messages";
    $.ajax({
        url: route,
        method: "POST",
        data: obj,
        success: function (redirectToIndex) {
            alert(redirectToIndex);
        },
        error: function (err) {
            $("#ErrorList").html(err);
        }
    });
}






function getCategories(type) {
    $.get("api/categories-per-type/" + type, function (data, status) {
        var template = `
                         <div class='post col-md-4'>
                            <div class='post-thumbnail'>
                            <img src="image/shops/banner/#ID#/banner.png" class="img-fluid" style="width:336px;height:252px;border:2px solid gray;" alt="banner">
                            <a href='shop/shop-items/#SHOPID#'>#SHOPNAME#</a>
                            </div>
                            <div class='post-details'>
                                <div class='post-meta d-flex justify-content-between'>  
                                    <div class='location'>#SHOPLOCATION#</div>
                                </div>
                                <div class="col">
                                <label>Open: #OPENAT#</label>
                                <label>Close: #CLOSEAT#</label>
                                </div>
                                <p class='text-muted'>#DESCRIPTION#</p>
                            </div>
                        </div>
                        `;
        var markup = "";

        $.each(data, function (index, categories) {
            markup = markup + template.replace("#ID#", categories.id).replace("#SHOPID#", categories.id).replace("#SHOPNAME#", categories.businessName).replace("#SHOPLOCATION#", categories.businessLocation).replace("#BUSINESSTYPE#", categories.businessType).replace("#OPENAT#", categories.openAt).replace("#CLOSEAT#", categories.closeAt).replace("#DESCRIPTION#", categories.businessDescription);
        });

        $("#categories-list").html(markup);
        //$(".col-icon").addClass("fa-10x");
    });
}


