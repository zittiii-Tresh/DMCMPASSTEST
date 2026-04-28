namespace MealPass.Core.Interface
{
    public interface IPasswordService
    {
        string Hash(string password);
        bool Verify(string password, string hashedPassword);

        // Returns empty string when valid, otherwise a multiline message
        // describing each failed rule (matches the existing live-validation format).
        string Validate(string password);
    }
}
