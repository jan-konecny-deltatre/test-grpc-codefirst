// See https://aka.ms/new-console-template for more information
using DataContracts;
using Grpc.Core;
using ProtoBuf.Grpc.Client;

Console.WriteLine("Hello, World!");
var channel = new Channel("localhost:5000", ChannelCredentials.Insecure);
var client = channel.CreateGrpcService<IGenericService<Request,Response>>();


while (true)
{
    var text = Console.ReadLine();
    if (text == "exit") break;

    var response = await client.Get(new Request { Name = text });
    Console.WriteLine(response.Greeting);
}

