using Puncher.Server;
using System.Net;

PuncherServer server = new PuncherServer();
server.Start(new IPEndPoint(IPAddress.Any, 6776));
