using System;
using System.Security.Claims;
using Microsoft.AspNetCore.SignalR;

namespace SilentNetwork.Hubs
{
	public class ChatHub : Hub
	{
		public async Task SendMassege(string user, string massege)
		{
			await Clients.All.SendAsync("ReciveMasssege", user, massege);
		}

		public override Task OnDisconnectedAsync( Exception? exception)
		{
			var user = Context.User.FindFirst(ClaimTypes.NameIdentifier);

			Clients.All.SendAsync("ReciveMasssege", user, $"{user} has been disconected!");

			return base.OnDisconnectedAsync(exception);
		}
	}
}

