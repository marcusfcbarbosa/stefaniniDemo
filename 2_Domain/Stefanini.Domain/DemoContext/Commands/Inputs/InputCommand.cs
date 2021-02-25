using System.Collections.Generic;
using FluentValidator;
using Stefanini.Shared.Commands;

namespace Stefanini.Domain.DemoContext.Commands.Inputs
{

    public class InputCommand : Notifiable, ICommand
    {
        public IEnumerable<TradeCommand> Input {get; protected set;}
        public InputCommand(IEnumerable<TradeCommand> input)
        {
            Input = input;
        }

        public void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}