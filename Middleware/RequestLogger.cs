using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.Logging;

namespace DIShowcase.Middleware
{
    public class ResponseMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public ResponseMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<ResponseMiddleware>();
        }

        public async Task Invoke(HttpContext context)
        {
            _logger.LogInformation("Adding QNH to: " + context.Request.Path);

            context.Response.Headers.Add("X-QNH", "AD-Midden");
            await _next.Invoke(context);
        }
        

    }
    public static class ResponseMiddlewareExtensions
    {
        public static IApplicationBuilder UseResponseMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ResponseMiddleware>();
        }
    }
}
