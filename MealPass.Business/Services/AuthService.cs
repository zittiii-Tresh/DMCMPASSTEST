using System.Threading.Tasks;
using MealPass.Core.Entity;
using MealPass.Core.Interface;
using MealPass.Data.Repositories;

namespace MealPass.Business.Services
{
    public class AuthService : IAuthService
    {
        private const int MaxFailedAttempts = 5;

        private readonly IEmployeeRepository _employeeRepository;
        private readonly IPasswordService _passwordService;

        public AuthService()
            : this(new EmployeeRepository(), new PasswordService()) { }

        public AuthService(IEmployeeRepository employeeRepository, IPasswordService passwordService)
        {
            _employeeRepository = employeeRepository;
            _passwordService = passwordService;
        }

        public async Task<LoginResult> LoginAsync(string username, string password)
        {
            var employee = await _employeeRepository.GetLoginInfoAsync(username);

            if (employee == null)
            {
                return new LoginResult { Outcome = LoginOutcome.InvalidUsername };
            }

            if (employee.IsLocked == 1)
            {
                return new LoginResult { Outcome = LoginOutcome.AccountLocked };
            }

            if (_passwordService.Verify(password, employee.Password ?? string.Empty))
            {
                await _employeeRepository.ResetFailedAttemptsAsync(username);

                return new LoginResult
                {
                    Outcome = LoginOutcome.Success,
                    RoleID = employee.RoleID,
                    Username = username
                };
            }

            int failedAttempts = employee.FailedAttempts + 1;
            bool shouldLock = failedAttempts >= MaxFailedAttempts;

            await _employeeRepository.SetFailedAttemptsAsync(username, failedAttempts, shouldLock);

            LoginOutcome outcome;
            if (shouldLock)
                outcome = LoginOutcome.NowLocked;
            else if (failedAttempts == MaxFailedAttempts - 1)
                outcome = LoginOutcome.SecondToLastAttempt;
            else
                outcome = LoginOutcome.InvalidPassword;

            return new LoginResult
            {
                Outcome = outcome,
                FailedAttempts = failedAttempts
            };
        }
    }
}
