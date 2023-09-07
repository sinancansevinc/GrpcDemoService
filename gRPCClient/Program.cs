using Grpc.Net.Client;
using GrpcDemoService;

var channel = GrpcChannel.ForAddress("https://localhost:7255");
var client = new Greeter.GreeterClient(channel);

var reply = await client.SayHelloAsync(new HelloRequest { Name = "Sino" });

Console.WriteLine($"From server: {reply}");