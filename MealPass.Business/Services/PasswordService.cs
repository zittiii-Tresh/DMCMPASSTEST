using System.Linq;
using MealPass.Core.Interface;

namespace MealPass.Business.Services
{
    public class PasswordService : IPasswordService
    {
        public string Hash(string password) => BCrypt.Net.BCrypt.HashPassword(password);

        public bool Verify(string password, string hashedPassword) =>
            BCrypt.Net.BCrypt.Verify(password, hashedPassword);

        public string Validate(string password)
        {
            string message = string.Empty;

            if (password.Length < 8)
                message += " - Must be at least 8 characters long\n";
            if (!password.Any(char.IsUpper))
                message += " - Must contain at least one uppercase letter\n";
            if (!password.Any(char.IsLower))
                message += " - Must contain at least one lowercase letter\n";
            if (!password.Any(char.IsDigit))
                message += " - Must contain at least one number\n";
            if (!password.All(char.IsLetterOrDigit))
                message += " - Must not contain special characters\n";

            return message;
        }
    }
}
