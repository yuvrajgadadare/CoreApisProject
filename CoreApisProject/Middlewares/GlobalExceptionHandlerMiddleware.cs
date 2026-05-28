
using System.Net;

namespace CoreApisProject.Middlewares
{
    public class GlobalExceptionHandlerMiddleware 
    {
        //private readonly ILogger<GlobalExceptionHandlerMiddleware> _logger;
        //private RequestDelegate _next;
        //public GlobalExceptionHandlerMiddleware(RequestDelegate next, ILogger<GlobalExceptionHandlerMiddleware> logger)
        //{
        //    _next = next;
        //    _logger = logger;

        //}
        //public async Task InvokeAsync(HttpContext context )
        //{
        //    try
        //    {
        //        await _next(context);
        //    }
        //    catch (Exception ex)
        //    {
        //        //handle exception
        //        _logger.LogError(ex, ex.Message);
        //        context.Response.StatusCode=(int)HttpStatusCode.InternalServerError;
        //    }
        //}
    }
}
