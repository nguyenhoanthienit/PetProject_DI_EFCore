using Microsoft.AspNetCore.Http;
using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Features;
using Serilog.Context;

namespace ExerciseProject.Middleware
{
    class SerilogMiddleware
    {
        const string MessageTemplate = "HTTP {RequestMethod} {RequestPath} responded {StatusCode} in {Elapsed:0.0000} ms";
        static readonly ILogger Log = Serilog.Log.ForContext<SerilogMiddleware>();
        readonly RequestDelegate _next;

        public SerilogMiddleware(RequestDelegate next)
        {
            _next = next ?? throw new ArgumentNullException(nameof(next));
        }

        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext == null)
            {
                throw new ArgumentNullException(nameof(httpContext));
            }

            var start = Stopwatch.GetTimestamp();
            httpContext.Response.Headers.Add("correlation-id", Guid.NewGuid().ToString());
            await _next(httpContext);
            var elapsedMs = GetElapsedMilliseconds(start, Stopwatch.GetTimestamp());
            var statusCode = httpContext.Response?.StatusCode;
            var level = statusCode > 499 ? LogEventLevel.Error : LogEventLevel.Information;

            LogContext.PushProperty("CorrelationId", Guid.NewGuid().ToString());
            Log.Write(level, MessageTemplate, httpContext.Request.Method, GetPath(httpContext), statusCode, elapsedMs);
        }

        static double GetElapsedMilliseconds(long start, long stop)
        {
            return (stop - start) * 1000 / (double)Stopwatch.Frequency;
        }

        static string GetPath(HttpContext httpContext)
        {
            return httpContext.Features.Get<IHttpRequestFeature>()?.RawTarget ?? httpContext.Request.Path.ToString();
        }
    }
}
