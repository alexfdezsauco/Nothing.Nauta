
namespace Nothing.Nauta.Helpers.Interfaces
{
    using System.Threading.Tasks;

    public interface IProcessor
    {
        Task Execute(string content);
    }
}