using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using MealPass.Core.Entity;
using MealPass.Core.Interface;
using MealPass.Data.Queries;
using MealPass.Shared;

namespace MealPass.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly string _connectionString;

        public EmployeeRepository()
        {
            _connectionString = AppConfig.ConnectionString;
        }

        public async Task<Employee?> GetLoginInfoAsync(string username)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.QueryFirstOrDefaultAsync<Employee>(
                    EmployeeQuery.GetLoginInfo, new { Username = username });
            }
        }

        public async Task ResetFailedAttemptsAsync(string username)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync(EmployeeQuery.ResetFailedAttempts, new { Username = username });
            }
        }

        public async Task SetFailedAttemptsAsync(string username, int failedAttempts, bool isLocked)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync(EmployeeQuery.SetFailedAttempts,
                    new { Username = username, FailedAttempts = failedAttempts, IsLocked = isLocked });
            }
        }

        public async Task<bool> UsernameExistsAsync(string username)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                int count = await connection.ExecuteScalarAsync<int>(
                    EmployeeQuery.UsernameExists, new { Username = username });
                return count > 0;
            }
        }

        public async Task InsertAsync(Employee employee)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync(EmployeeQuery.Insert, employee);
            }
        }

        public async Task<DataTable> FilterAllAsync()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                using (var command = new SqlCommand(EmployeeQuery.FilterAllEmployees, connection))
                using (var adapter = new SqlDataAdapter(command))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        public async Task<dynamic?> GetByUsernameAsync(string username)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.QueryFirstOrDefaultAsync<dynamic>(
                    EmployeeQuery.FilterEmployeeData, new { Username = username });
            }
        }

        public async Task<int> UpdateAsync(Employee employee, string originalUsername)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new
                {
                    employee.RoleID,
                    employee.FirstName,
                    employee.MiddleName,
                    employee.LastName,
                    employee.NameExtension,
                    employee.Gender,
                    employee.Birthdate,
                    employee.ContactNo,
                    employee.CivilStatusID,
                    employee.Username,
                    employee.EmploymentStatus,
                    employee.IsLocked,
                    OriginalUsername = originalUsername
                };
                return await connection.ExecuteAsync(EmployeeQuery.Update, parameters);
            }
        }

        public async Task<int> DeleteByUsernameAsync(string username)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.ExecuteAsync(EmployeeQuery.DeleteByUsername, new { Username = username });
            }
        }

        public async Task<int> UpdatePasswordAsync(string username, string hashedPassword)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.ExecuteAsync(EmployeeQuery.UpdatePassword,
                    new { Username = username, Password = hashedPassword });
            }
        }
    }
}
