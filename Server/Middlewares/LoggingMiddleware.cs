using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Server.Middlewares
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var stopwatch = Stopwatch.StartNew();

            // Process the request
            await _next(context);

            stopwatch.Stop();
            Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path} responded with {context.Response.StatusCode} in {stopwatch.ElapsedMilliseconds}ms");
        }
    }
}