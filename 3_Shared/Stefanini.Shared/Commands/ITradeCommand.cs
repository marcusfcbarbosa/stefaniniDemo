namespace Stefanini.Shared.Commands
{
    public interface ITradeCommand
    {
         double Value { get; } 
         string ClientSector { get; }
    }
}