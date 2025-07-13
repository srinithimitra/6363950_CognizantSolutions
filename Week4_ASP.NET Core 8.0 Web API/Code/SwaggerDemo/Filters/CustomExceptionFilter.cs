using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;

namespace _3_SwaggerDemo.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            File.WriteAllText("logs.txt", $"[{DateTime.Now}] {exception.Message}\n{exception.StackTrace}");

            context.Result = new ObjectResult("Internal server error occurred")
            {
                StatusCode = 500
            };
        }
    }
}
