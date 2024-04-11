using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace EmployeeManagmentCore
{
    public class SignalRControl : Hub
    {
        public async Task<string> SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);

            return "Message sent successfully!";
        }
    }
}

