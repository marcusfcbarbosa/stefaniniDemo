using FluentValidator;
using Stefanini.Domain.DemoContext.Commands.Inputs;
using Stefanini.Shared.Commands;

namespace Stefanini.Domain.DemoContext.Handlers
{
    public class TradeHandler : Notifiable,
                                ICommandHandler<TradeCommand>
    {
        public ICommandResult Handle(TradeCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}