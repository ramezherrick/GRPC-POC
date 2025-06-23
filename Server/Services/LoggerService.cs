using Grpc.Core;

namespace Server.Services
{
    public class LoggerService : Logger.LoggerBase
    {
        public override Task<LogResponse> SendLog(LogRequest request, ServerCallContext context)
        {
            Console.WriteLine($"[{request.Timestamp}] ({request.DeviceId}) {request.Message}");
            return Task.FromResult(new LogResponse { Status = "Received" });
        }
    }
}
