using System.Net;
using Microsoft.AspNetCore.Diagnostics;

namespace OpenScienceProjects.API.Extensions;

public static class GlobalExceptionHandler
{
    public static async Task Handle(HttpContext httpContext)
    {
        var contextFeature = httpContext.Features.Get<IExceptionHandlerFeature>();
        if (contextFeature == null)
            return;

        httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        httpContext.Response.ContentType = "application/json";

        await httpContext.Response.WriteAsJsonAsync(new
        {
            StatusCode = httpContext.Response.StatusCode,
            Message = contextFeature.Error.Message,
        });
    }
}