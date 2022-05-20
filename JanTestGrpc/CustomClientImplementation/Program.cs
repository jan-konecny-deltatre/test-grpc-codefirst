// See https://aka.ms/new-console-template for more information


using CustomServerImplementation;
using DataContracts;
using Grpc.Core;
using ProtoBuf.Grpc.Client;

Console.WriteLine("Hello, World!");
var channel = new Channel("localhost:5000", ChannelCredentials.Insecure);
var client = channel.CreateGrpcService<IGenericService<CustomExtendedRequest, CustomExtendedResponse>>();


while (true)
{
    var text = Console.ReadLine();
    if (text == "exit") break;
    var textParts = text.Split(' '); 
    var response = await client.Get(new CustomExtendedRequest { Name = textParts[0], Surname = textParts[1] });
    Console.WriteLine(response.Greeting + ", also surname was: " + response.Surname);
}