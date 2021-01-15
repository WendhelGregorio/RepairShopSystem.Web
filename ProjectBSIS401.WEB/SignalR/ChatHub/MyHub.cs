using Microsoft.AspNetCore.SignalR;
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.SignalR.ChatHub
{
    public class MyHub : Hub
    {
        public static List<User> connectedUsers = new List<User>();
       

        //Client calls Connect method when he wants to join Chat room
        public void Connect(string userName)
        {
            var id = Context.ConnectionId;

        }


        //For sending message in chat room to all connected clients, it calls SendMessageToAll
        public void SendMessageToAll(string userName, string message)
        {

        }

        //for private chat with single user client calls SendPrivateMessage method
        public void SendPrivateMessage(Guid? toUserId, string message)
        {

        }
    }
}

