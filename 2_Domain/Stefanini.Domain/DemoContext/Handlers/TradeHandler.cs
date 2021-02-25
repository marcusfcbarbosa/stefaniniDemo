using System.Collections.Generic;
using FluentValidator;
using Stefanini.Domain.DemoContext.Commands.Inputs;
using Stefanini.Domain.DemoContext.Commands.Outputs;
using Stefanini.Shared.Commands;
using Stefanini.Shared.Utils;

namespace Stefanini.Domain.DemoContext.Handlers
{
    public class TradeHandler : Notifiable,
                                ICommandHandler<InputCommand>

    {
        public ICommandResult Handle(InputCommand command)
        {
            var inputs = command.Input;
            foreach (var input in inputs)
            {
                input.Validate();
                if (!input.Valid)
                {
                    return new CommandResult(false, "Errors", input.Notifications);
                }
            }

            List<string> output = new List<string>();

            foreach (var input in inputs)
            {
                if (input.Value < 1000000 && input.ClientSector == "Public")
                {
                    output.Add(Util.LOWRISK);
                }
                if (input.Value > 1000000 && input.ClientSector == "Public")
                {
                    output.Add(Util.SectorMEDIUMRISK);
                }
                if (input.Value > 1000000 && input.ClientSector == "Private")
                {
                    output.Add(Util.SectorHIGHRISK);
                }
            }
            return new CommandResult(true, "Success", output);
        }
    }
}