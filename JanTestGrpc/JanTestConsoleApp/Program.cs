// See https://aka.ms/new-console-template for more information
using DataContracts;
using Grpc.Core;
using JanTestConsoleApp;
using ProtoBuf.Grpc.Server;

ServerStartup.RunServer<ServiceGeneric>();

public static class ServerStartup
{
    public static void RunServer<TGenericService>() where TGenericService : IGenericService, new()
    {
        var service = new TGenericService();
        

        var _server = new Server()
        {
            Ports = { new ServerPort("localhost", 5000, ServerCredentials.Insecure) }
        };

        _server.Services.AddCodeFirst(service);
        _server.Start();

        Console.WriteLine($"Server running on localhost:5000");
        Console.ReadLine();
    }
}