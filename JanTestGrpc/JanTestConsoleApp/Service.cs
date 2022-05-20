using DataContracts;
using Grpc.Core;
using ProtoBuf.Grpc.Server;

namespace JanTestConsoleApp
{
    public class ServiceGeneric : IGenericService<Request,Response>
    {
        public virtual ValueTask<Response> Get(Request request)
        {
            return new ValueTask<Response>(new Response { Greeting = "Hello " + request.Name });
        }
    }
}
