# test-grpc-codefirst
Simple project to try GRPC with code first and contract file extensions

Projects:

DataContracts
  Basic Request, Response types,
  Generic service using those

JanTestConsoleServer 
  Server using generic service with Request and Response
  
CustomServerImplementation
  Server using JanTestConsoleServer with extended service CustomExtendedService and extended request/response being CustomExtendedRequest and CustomExtendedResponse

--------------------
There are 2 simple clients that are able to call those

TODO: Enable reflection (not sure how to do it here yet)
  
