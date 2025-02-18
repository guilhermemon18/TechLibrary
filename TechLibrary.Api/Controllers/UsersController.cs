using Microsoft.AspNetCore.Mvc;
using TechLibrary.Api.UseCases.Users.Register;
using TechLibrary.Communication.Requests;
using TechLibrary.Communication.Responses;
using TechLibrary.Exception;

namespace TechLibrary.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        //Documentação das respostas devolvidas pela API.
        [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorMessagesJson), StatusCodes.Status400BadRequest)]
        public IActionResult Create(RequestUserJson request)
        {
            try
            {
                var useCase = new RegisterUserUseCase();
                var response = useCase.Execute(request);
                //aqui dá para passar a string de criação da rota get para obter o recurso criado, ao invéz de string.Empty;
                return Created(string.Empty, response);
            }
            catch(TechLibraryException ex)
            {
                return BadRequest(new ResponseErrorMessagesJson
                {
                    Errors = ex.GetErrorMessages()
                });
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ResponseErrorMessagesJson
                {
                    Errors = ["Erro Desconhecido"]
                });
            }
        }

    }
}
