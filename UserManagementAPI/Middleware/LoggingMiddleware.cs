// Middleware/LoggingMiddleware.cs
using System.Diagnostics;

namespace UserManagementAPI.Middleware
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
            Debug.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");
            await _next(context);
        }
    }
}
