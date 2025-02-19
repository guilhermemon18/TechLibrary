using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using TechLibrary.Communication.Responses;
using TechLibrary.Exception;

namespace TechLibrary.Api.Filters
{
    //Filtro de excessão que centraliza o tratamento de excessões da API e devolve as mensagens de erros adequadas ao usuário.
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if(context.Exception is TechLibraryException techLibraryException)
            {
                context.HttpContext.Response.StatusCode = (int) techLibraryException.GetStatusCode();
                context.Result = new ObjectResult( new ResponseErrorMessagesJson
                {
                    Errors = techLibraryException.GetErrorMessages()
                });
            }
            else
            {
                context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
                context.Result = new ObjectResult(new ResponseErrorMessagesJson
                {
                    Errors = ["Erro Desconhecido."]
                });
            }
        }
    }
}
