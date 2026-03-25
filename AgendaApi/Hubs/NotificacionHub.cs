using Microsoft.AspNetCore.SignalR;
namespace AgendaApi.Hubs;
public class NotificacionHub : Hub
{
    public override async Task OnConnectedAsync()
    {
        var userId = Context.UserIdentifier;
        
        
        if (string.IsNullOrEmpty(userId)) {
            Console.WriteLine("UN USUARIO SE CONECTÓ PERO ES ANÓNIMO (SignalR no sabe su ID)");
        } else {
            Console.WriteLine($"USUARIO CONECTADO EN SIGNALR: {userId}");
        }
        
        await base.OnConnectedAsync();
    }
}