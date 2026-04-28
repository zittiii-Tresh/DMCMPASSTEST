namespace MealPass.Core.Entity
{
    public enum LoginOutcome
    {
        InvalidUsername,    // username not found
        AccountLocked,      // account already locked before this attempt
        Success,            // password verified
        InvalidPassword,    // wrong password, attempts < 5
        SecondToLastAttempt,// wrong password, now at 4/5 attempts
        NowLocked           // wrong password, hit 5 and just got locked
    }

    public class LoginResult
    {
        public LoginOutcome Outcome { get; set; }
        public int RoleID { get; set; }
        public int FailedAttempts { get; set; }
        public string? Username { get; set; }
    }
}
