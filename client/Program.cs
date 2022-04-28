using models;
using Grpc.Net.Client;

using var channel = GrpcChannel.ForAddress("http://localhost:8183");
var client = new HelloService.HelloServiceClient(channel);
var reply = client.Greet(new Request { FirstName = "good", LastName = "Remote Procedure Call" });

System.Console.WriteLine(reply.Result);
System.Console.WriteLine("done!");
System.Console.ReadLine();

