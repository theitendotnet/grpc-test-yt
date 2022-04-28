using models;
using Grpc.Core;

namespace Server
{
    public class HelloServiceImpl : HelloService.HelloServiceBase
    {
        public HelloServiceImpl()
        { }

        public override async Task<Response> Greet(Request command, ServerCallContext context)
        {
            await Task.CompletedTask;
            
            return new Response { Result = $"Server says hell to: {command.FirstName} - {command.LastName}" };
        }
    }
}