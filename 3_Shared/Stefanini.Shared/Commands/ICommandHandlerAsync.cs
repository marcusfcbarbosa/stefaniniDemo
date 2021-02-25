using System.Threading.Tasks;
namespace Stefanini.Shared.Commands
{
    public interface ICommandHandlerAsync<T> where T : ICommand
    {
        Task<ICommandResult> Handle(T command);
    }
}