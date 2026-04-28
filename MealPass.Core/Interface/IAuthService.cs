using System.Threading.Tasks;
using MealPass.Core.Entity;

namespace MealPass.Core.Interface
{
    public interface IAuthService
    {
        Task<LoginResult> LoginAsync(string username, string password);
    }
}
