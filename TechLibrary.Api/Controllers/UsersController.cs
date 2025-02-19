using Microsoft.AspNetCore.Mvc;
using TechLibrary.Api.UseCases.Users.Register;
using TechLibrary.Communication.Requests;
using TechLibrary.Communication.Responses;

namespace TechLibrary.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        //Documentação das respostas devolvidas pela API.
        [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorMessagesJson), StatusCodes.Status400BadRequest)]
        public IActionResult Register(RequestUserJson request)
        {
            var useCase = new RegisterUserUseCase();

            var response = useCase.Execute(request);

            //É possível passar a string de criação da rota get para obter o recurso criado, ao invéz de string.Empty;
            return Created(string.Empty, response);

        }

    }
}
