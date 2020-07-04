
namespace Nothing.Nauta.Helpers.Interfaces
{
    using System.Threading.Tasks;

    public interface IProcessor
    {
        bool Execute(string content);
    }
}