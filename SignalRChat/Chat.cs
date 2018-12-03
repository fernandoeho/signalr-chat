using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRChat
{
    public class Chat : Hub
    {
        public async Task Send(string nick, string message)
        {
            await Clients.All.SendAsync("Send", nick, message);
        }
    }
}