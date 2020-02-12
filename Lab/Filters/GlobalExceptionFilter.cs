using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using TeacherMemo.Shared.Exceptions;

namespace Lab.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        private readonly IWebHostEnvironment _env;

        public GlobalExceptionFilter(IWebHostEnvironment env)
        {
            _env = env;
        }

        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            var msg = exception.Message;
            var msgObj = new { Message = msg };

            switch (exception)
            {
                case NotFoundException notFoundEx:
                    context.Result = new NotFoundObjectResult(msgObj);
                    context.HttpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;
                    break;

                case ArgumentException argumentEx:
                    context.Result = new BadRequestObjectResult(msgObj);
                    context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                    break;

                default:
                    object obj;

                    if (_env.IsDevelopment())
                    {
                        obj = new
                        {
                            Message = msg,
                            DeveloperMessage = $"{context.Exception.Message}\n{context.Exception.StackTrace}"
                        };
                    }
                    else
                    {
                        obj = msgObj;
                    }

                    context.Result = new ObjectResult(obj);
                    context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    break;
            }

            context.ExceptionHandled = true;
        }
    }
}
