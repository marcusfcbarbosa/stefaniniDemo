using Microsoft.AspNetCore.Mvc;
using Stefanini.Domain.DemoContext.Commands.Inputs;
using Stefanini.Domain.DemoContext.Handlers;
using Stefanini.Shared.Commands;

namespace Stefanini.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComercialController : ControllerBase
    {
        private readonly TradeHandler _tradeHandler;
        public ComercialController(TradeHandler tradeHandler)
        {
            _tradeHandler = tradeHandler;
        }

        [HttpPost]
        [Route("Trade")]
        public ICommandResult Trade([FromBody] InputCommand command)
        {
            return _tradeHandler.Handle(command);
        }
    }
}