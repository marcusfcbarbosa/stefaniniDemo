
using FluentValidator;
using FluentValidator.Validation;
using Stefanini.Shared.Commands;

namespace Stefanini.Domain.DemoContext.Commands.Inputs
{
    public class TradeCommand : Notifiable, ICommand, ITradeCommand
    {
        public double Value { get;  set; }
        public string ClientSector { get;   set; }
        public TradeCommand(double value, string clientSector)
        {
            Value = value;
            ClientSector = clientSector;
        }
        public void Validate()
        {
            AddNotifications(new ValidationContract()
                 .Requires()
                 .IsGreaterThan(Value,0, "Value", "Value must be greater than Zero")
                 .IsNotNullOrEmpty(ClientSector, "ClientSector", "ClientSector cannot be null")
             );
        }
    }
}