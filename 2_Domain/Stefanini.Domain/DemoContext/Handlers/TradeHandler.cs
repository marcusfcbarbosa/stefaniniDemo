using FluentValidator;
using Stefanini.Domain.DemoContext.Commands.Inputs;
using Stefanini.Domain.DemoContext.Commands.Outputs;
using Stefanini.Shared.Commands;

namespace Stefanini.Domain.DemoContext.Handlers
{
    public class TradeHandler : Notifiable,
                                ICommandHandler<InputCommand>
                                
    {
        public ICommandResult Handle(InputCommand command)
        {
            var inputs = command.Input;
            foreach(var input in inputs){
                input.Validate();
                if(!input.Valid){
                    return new CommandResult(false, "Errors", input.Notifications);
                }
            }


            throw new System.NotImplementedException();
        }
    }
}