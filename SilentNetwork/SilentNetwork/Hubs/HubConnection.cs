using System;
namespace SilentNetwork.Hubs
{
	public static class HubConnection
	{
		public static Dictionary<string, List<string>> Users = new();
		// <Lobby name, Connections in lobby> 
        public static Dictionary<string, List<string>> Lobbys = new();


		public static List<string> OnlineUsers()
		{
			return Users.Keys.ToList();
		}
    }
}

