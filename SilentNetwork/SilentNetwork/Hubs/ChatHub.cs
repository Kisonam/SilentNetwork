using System;
using Microsoft.AspNetCore.SignalR;

namespace SilentNetwork.Hubs
{
	public class ChatHub : Hub
	{
		public async Task SendMassege(string user, string massege)
		{
			await Clients.All.SendAsync("ReciveMasssege", user, massege);
		}

   //     public override Task OnDisconnectedAsync(string user,Exception? exception)
   //     {
			//Clients.All.SendAsync("ReciveMasssege", user, $"{user} has been disconected!");

   //         return base.OnDisconnectedAsync(exception);
   //     }
    }
}

