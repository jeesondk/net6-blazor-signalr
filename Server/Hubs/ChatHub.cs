using Microsoft.AspNetCore.SignalR;

namespace net6_blazor_signalr.Server.Hubs;

public class ChatHub: Hub
{
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}