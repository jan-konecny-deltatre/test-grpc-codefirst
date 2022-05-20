using DataContracts;

namespace CustomServerImplementation
{
    public class CustomExtendedService : IGenericService<CustomExtendedRequest, CustomExtendedResponse>
    {
        public ValueTask<CustomExtendedResponse> Get(CustomExtendedRequest request)
        {
            return new ValueTask<CustomExtendedResponse>(new CustomExtendedResponse { Greeting = $"Hello {request.Name + request.Surname}!", Surname = request.Surname });
        }
    }
}
