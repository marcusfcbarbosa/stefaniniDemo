
using FluentValidator;
using FluentValidator.Validation;
using Stefanini.Shared.Commands;

namespace Stefanini.Domain.DemoContext.Commands.Inputs
{
    public class TradeCommand : Notifiable, ICommand, ITradeCommand
    {
        public double Value { get; protected set; }
        public string ClientSector { get;  protected set; }
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
                 .IsNullOrEmpty(ClientSector, "ClientSector", "ClientSector cannot be null")
             );
        }
    }
}