using DataContracts;
using ProtoBuf;

namespace CustomServerImplementation
{
    [ProtoContract]
    public class CustomExtendedRequest : Request
    {
        [ProtoMember(2)]
        public string Surname { get; set; } = string.Empty;
    }

    [ProtoContract]
    public class CustomExtendedResponse : Response
    {
        [ProtoMember(2)]
        public string Surname { get; set; } = string.Empty;
    }
}
