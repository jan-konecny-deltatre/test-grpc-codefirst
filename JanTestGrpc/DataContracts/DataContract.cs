extern alias protobuf;


namespace DataContracts
{
    [protobuf::ProtoBuf.ProtoContract]
    public class Request
    {
        [protobuf::ProtoBuf.ProtoMember(1)]
        public string Name { get; set; } = string.Empty;
    }

    [protobuf::ProtoBuf.ProtoContract]
    public class Response
    {
        [protobuf::ProtoBuf.ProtoMember(1)]
        public string Greeting { get; set; } = string.Empty;
    }
}
