using System.Data;
using System.Threading.Tasks;
using MealPass.Core.Entity;
using MealPass.Core.Interface;
using MealPass.Data.Repositories;

namespace MealPass.Business.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IPasswordService _passwordService;

        public EmployeeService()
            : this(new EmployeeRepository(), new PasswordService()) { }

        public EmployeeService(IEmployeeRepository employeeRepository, IPasswordService passwordService)
        {
            _employeeRepository = employeeRepository;
            _passwordService = passwordService;
        }

        public Task<bool> UsernameExistsAsync(string username) =>
            _employeeRepository.UsernameExistsAsync(username);

        public Task RegisterAsync(Employee employee, string plainPassword)
        {
            employee.Password = _passwordService.Hash(plainPassword);
            return _employeeRepository.InsertAsync(employee);
        }

        public Task<DataTable> FilterAllAsync() => _employeeRepository.FilterAllAsync();

        public Task<dynamic?> GetByUsernameAsync(string username) =>
            _employeeRepository.GetByUsernameAsync(username);

        public Task<int> UpdateAsync(Employee employee, string originalUsername) =>
            _employeeRepository.UpdateAsync(employee, originalUsername);

        public Task<int> DeleteByUsernameAsync(string username) =>
            _employeeRepository.DeleteByUsernameAsync(username);

        public Task<int> UpdatePasswordAsync(string username, string plainPassword)
        {
            string hashed = _passwordService.Hash(plainPassword);
            return _employeeRepository.UpdatePasswordAsync(username, hashed);
        }
    }
}
