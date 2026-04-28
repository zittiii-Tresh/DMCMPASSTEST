using System.Data;
using System.Threading.Tasks;
using MealPass.Core.Entity;

namespace MealPass.Core.Interface
{
    public interface IEmployeeService
    {
        Task<bool> UsernameExistsAsync(string username);
        Task RegisterAsync(Employee employee, string plainPassword);
        Task<DataTable> FilterAllAsync();
        Task<dynamic?> GetByUsernameAsync(string username);
        Task<int> UpdateAsync(Employee employee, string originalUsername);
        Task<int> DeleteByUsernameAsync(string username);
        Task<int> UpdatePasswordAsync(string username, string plainPassword);
    }
}
