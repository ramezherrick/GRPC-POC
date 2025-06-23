using Grpc.Net.Client;
using Server;

var channel = GrpcChannel.ForAddress("http://localhost:5184");
var client = new Logger.LoggerClient(channel);

var log = new LogRequest
{
    DeviceId = "Kiosk 1",
    Message = "online",
    Timestamp = DateTime.UtcNow.ToString("s")
};

var response = await client.SendLogAsync(log);
Console.WriteLine("Server response: " + response.Status);