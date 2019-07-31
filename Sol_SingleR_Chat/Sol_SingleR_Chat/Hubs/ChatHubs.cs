using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Sol_SingleR_Chat.Hubs
{
    public class ChatHubs : Hub
    {
        public async Task SendMessageAsync(string userName, string message)
        {
            await Clients.All.SendAsync("ReceiveMessageMethod", userName, message);
        }
        
    }
}
