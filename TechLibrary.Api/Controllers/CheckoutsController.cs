using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TechLibrary.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CheckoutsController : ControllerBase
    {
        [HttpPost]
        //Define que o bookId virá pela rota, como boa prática IDS SEMPRE devem vir pela rota, não como query params.
        [Route("{bookId}")]
        public IActionResult BookCheckout(Guid bookId)
        {


            return NoContent();
        }
    }
}
