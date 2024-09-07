using System.Threading.Tasks;
using TaskManager.Data.Entities;

namespace TaskManager.API.Services
{
    public interface IAuthService
    {
        Task<string> LoginAsync(string username, string password);
        Task<User> RegisterAsync(User user, string password);
    }
}