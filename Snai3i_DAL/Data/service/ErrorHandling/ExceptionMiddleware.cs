using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Snai3i_DAL.Data.service.ExceptionMiddleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;
        private readonly IHostEnvironment env;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger,
            IHostEnvironment env )
        {
            _logger = logger;
            this.env = env;
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                if (env.IsDevelopment())
                {
                    _logger.LogError($"Something went wrong: {ex}:{ex.Message}");
                }
                await HandleExceptionAsync(httpContext, ex);
            }
        }
        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var exceptionApiResponse = env.IsDevelopment() ?
                new ExceptionApiResponse((int)HttpStatusCode.InternalServerError,
                exception.Message
                , exception.StackTrace) :
                new ExceptionApiResponse((int)HttpStatusCode.InternalServerError
                , null , null);

            var options = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            var response = JsonSerializer.Serialize(exceptionApiResponse , options);

            await context.Response.WriteAsync(response);
        }
    }
}
