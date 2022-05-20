using System.ServiceModel;

namespace DataContracts
{
    [ServiceContract]
    public interface IService
    {
        ValueTask<Response> Get(Request request);
    }


    public interface IGenericService { }

    [ServiceContract]
    public interface IGenericService<TRequest,TResponse> : IGenericService
        where TRequest : Request, new()
        where TResponse : Response, new()
    {
        ValueTask<TResponse> Get(TRequest request);
    }
}
