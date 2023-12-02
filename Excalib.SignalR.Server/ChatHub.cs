using Microsoft.AspNetCore.SignalR;

namespace Excalib.SignalR.Server;

public class ChatHub : Hub
{
    public async Task SendMessageToAllUsers(string name, string message)
    {
        await Clients.All.SendAsync("sendMessageToAllUsers", name, message);
    }
}