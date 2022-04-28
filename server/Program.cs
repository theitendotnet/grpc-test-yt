using models;
using Grpc.Core;
using Server;

const int Port = 8183;

var server = new Grpc.Core.Server
{
    Services = { HelloService.BindService(new HelloServiceImpl()) },
    Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
};
server.Start();

System.Console.WriteLine("server is running (does it do anything yet?)");
System.Console.ReadLine();

await server.ShutdownAsync();
