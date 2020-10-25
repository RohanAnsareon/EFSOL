using efsol_api.Enums;

namespace efsol_api.DTOs.Exception
{
    public class HttpExceptionResponse
    {
        public HttpExceptionResponse() { }

        public HttpExceptionResponse(string message, ExceptionType type)
        {
            Message = message;
            Type = type;
        }

        public string Message { get; set; }
        public ExceptionType Type { get; set; }
    }
}
