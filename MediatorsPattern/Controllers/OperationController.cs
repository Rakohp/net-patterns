using MediatorsPattern.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatorsPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OperationController : ControllerBase
    {
        private readonly IMediator _mediador;

        public OperationController(IMediator mediador)
        {
            this._mediador = mediador;
        }

        [HttpPost]
        public async Task<IActionResult> Operation([FromBody] RequestModel request)
        {
            return Ok(await _mediador.Send(request));
        }
    }
}   
