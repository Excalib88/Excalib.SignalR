using Microsoft.AspNetCore.SignalR;

namespace Excalib.SignalR.Server;

public class ChatHub : Hub
{
    public List<string> Users { get; set; } = new();
    
    public async Task sendMessageToAllUsers(string name, string message)
    {
        await Clients.Caller.SendAsync("sendMessageToCaller", name, message);
        //await Clients.All.SendAsync("sendMessageToAllUsers", name, message);
        //await Groups.AddToGroupAsync("", "");
    }
    
    public override async Task OnConnectedAsync()
    {
        if(!Users.Contains(Context.ConnectionId))
            Users.Add(Context.ConnectionId);
        
        await base.OnConnectedAsync();
    }

    public override async Task OnDisconnectedAsync(Exception? stopCalled)
    {
        await base.OnDisconnectedAsync(stopCalled);
    }
}