using System.Data;
using System.Threading.Tasks;
using MealPass.Core.Entity;

namespace MealPass.Core.Interface
{
    public interface IEmployeeRepository
    {
        Task<Employee?> GetLoginInfoAsync(string username);
        Task ResetFailedAttemptsAsync(string username);
        Task SetFailedAttemptsAsync(string username, int failedAttempts, bool isLocked);

        Task<bool> UsernameExistsAsync(string username);
        Task InsertAsync(Employee employee);
        Task<DataTable> FilterAllAsync();
        Task<dynamic?> GetByUsernameAsync(string username);
        Task<int> UpdateAsync(Employee employee, string originalUsername);
        Task<int> DeleteByUsernameAsync(string username);
        Task<int> UpdatePasswordAsync(string username, string hashedPassword);
    }
}
