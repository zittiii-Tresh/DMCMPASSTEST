using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MealPass.Business.Services;
using MealPass.Core.Entity;
using MealPass.Core.Interface;

namespace MealPassCapstone.Desktop.Forms
{
    public partial class LoginForm : DevExpress.XtraEditors.DirectXForm
    {
        private readonly IAuthService _authService = new AuthService();

        public LoginForm()
        {
            InitializeComponent();
            ApplyTextEditBehaviors();
        }

        private async void loginBTN_Click(object sender, EventArgs e)
        {
            string username = usernameTE.Text.Trim();
            string password = passwordTE.Text;

            LoginResult result = await _authService.LoginAsync(username, password);

            switch (result.Outcome)
            {
                case LoginOutcome.InvalidUsername:
                    MessageBox.Show("Invalid username or password.");
                    return;

                case LoginOutcome.AccountLocked:
                    MessageBox.Show("Your account is locked. Please contact the administrator.");
                    return;

                case LoginOutcome.NowLocked:
                    MessageBox.Show("Account locked after 5 failed login attempts.");
                    return;

                case LoginOutcome.SecondToLastAttempt:
                    MessageBox.Show("Invalid password. You have 1 attempt left before your account will be locked.");
                    return;

                case LoginOutcome.InvalidPassword:
                    MessageBox.Show($"Invalid password. Attempt {result.FailedAttempts} of 5.");
                    return;

                case LoginOutcome.Success:
                    Helpers.UserSession.Username = result.Username;

                    this.Hide();

                    Form nextForm;
                    if (result.RoleID == 1)
                    {
                        nextForm = new Forms.Admin.MainForm();
                    }
                    else
                    {
                        nextForm = new Staff.StaffMainForm();
                    }

                    nextForm.FormClosed += (s, args) => Application.Exit();
                    nextForm.Show();
                    return;
            }
        }

        private void ApplyTextEditBehaviors()
        {
            Helpers.TextHelper.AttachBehavior(usernameTE, "Username");
            Helpers.TextHelper.AttachBehavior(passwordTE, "Password", true);
        }

        private void showCE_CheckedChanged(object sender, EventArgs e)
        {
            passwordTE.Properties.UseSystemPasswordChar = !showCE.Checked;
        }
    }
}
