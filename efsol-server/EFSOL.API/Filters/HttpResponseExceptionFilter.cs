using EFSOL.API.DTOs;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EFSOL.API.Filters
{
    public class HttpResponseExceptionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context) { }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception is ValidationException exception)
            {
                //var responseContent = new HttpValidationErrorResponse
                //{
                //    FieldName = exception.
                //};

                //context.Result = new ObjectResult(responseContent)
                //{
                //    StatusCode = 403,
                //};
                //context.ExceptionHandled = true;
            }
            else
            {
                var responseContent = new HttpErrorResponse
                {
                    Message = context.Exception.Message
                };

                context.Result = new ObjectResult(responseContent)
                {
                    StatusCode = 400,
                };
                context.ExceptionHandled = true;
            }
        }
    }
}
