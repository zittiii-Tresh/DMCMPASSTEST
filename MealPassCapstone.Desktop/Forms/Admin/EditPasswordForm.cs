using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MealPass.Business.Services;
using MealPass.Core.Interface;

namespace MealPassCapstone.Desktop.Forms.Admin
{
    public partial class EditPasswordForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly IEmployeeService _employeeService = new EmployeeService();
        private readonly IPasswordService _passwordService = new PasswordService();

        private readonly string _username;

        public EditPasswordForm(string username)
        {
            InitializeComponent();
            _username = username;
            ApplyTextEditBehaviors();
        }

        private void ApplyTextEditBehaviors()
        {
            Helpers.TextHelper.AttachBehavior(passwordBE, "Password", true);
            Helpers.TextHelper.AttachBehavior(confirmpassBE, "Password", true);
        }

        private void passwordBE_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var tagAction = passwordBE.Tag?.ToString() ?? "eyeopen";

            if (tagAction == "eyeopen")
            {
                passwordBE.Properties.Buttons[0].ImageOptions.Image = imageCollection1.Images[1];
                passwordBE.Tag = "eyeclose";
                passwordBE.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                passwordBE.Properties.Buttons[0].ImageOptions.Image = imageCollection1.Images[0];
                passwordBE.Tag = "eyeopen";
                passwordBE.Properties.UseSystemPasswordChar = true;
            }
        }

        private void passwordBE_EditValueChanged(object sender, EventArgs e)
        {
            string password = passwordBE.Text;

            if (string.IsNullOrWhiteSpace(password))
            {
                resultcaptionLBL.Visible = false;
                resultLBL.Visible = false;
                return;
            }

            resultcaptionLBL.Visible = true;
            resultLBL.Visible = true;

            string message = _passwordService.Validate(password);

            if (string.IsNullOrEmpty(message))
            {
                resultcaptionLBL.Text = "✅ Password is valid!";
                resultLBL.Text = message;
                resultcaptionLBL.ForeColor = Color.PaleGreen;
                resultLBL.ForeColor = Color.PaleGreen;
            }
            else
            {
                resultcaptionLBL.Text = "❌ Password is invalid";
                resultLBL.Text = message;
                resultcaptionLBL.ForeColor = Color.LightCoral;
                resultLBL.ForeColor = Color.LightCoral;
            }
        }

        private void confirmpassBE_EditValueChanged(object sender, EventArgs e)
        {
            string password = passwordBE.Text;
            string confirmPassword = confirmpassBE.Text;

            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                lblConfirmPasswordCaption.Visible = false;
                return;
            }

            lblConfirmPasswordCaption.Visible = true;

            if (password == confirmPassword)
            {
                lblConfirmPasswordCaption.Text = "✅  Password confirmed!";
                lblConfirmPasswordCaption.ForeColor = Color.PaleGreen;
            }
            else
            {
                lblConfirmPasswordCaption.Text = "❌  Password mismatch";
                lblConfirmPasswordCaption.ForeColor = Color.LightCoral;
            }
        }

        private async void saveBTN_Click(object sender, EventArgs e)
        {
            string newPassword = passwordBE.Text;
            string confirmPassword = confirmpassBE.Text;

            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in both fields.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (!string.IsNullOrEmpty(_passwordService.Validate(newPassword)))
            {
                MessageBox.Show("Password does not meet the requirements.");
                return;
            }

            int rowsAffected = await _employeeService.UpdatePasswordAsync(_username, newPassword);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Password updated successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update password.");
            }
        }

        private void confirmpassBE_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var tagAction = confirmpassBE.Tag?.ToString() ?? "eyeopen";

            if (tagAction == "eyeopen")
            {
                confirmpassBE.Properties.Buttons[0].ImageOptions.Image = imageCollection1.Images[1];
                confirmpassBE.Tag = "eyeclose";
                confirmpassBE.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                confirmpassBE.Properties.Buttons[0].ImageOptions.Image = imageCollection1.Images[0];
                confirmpassBE.Tag = "eyeopen";
                confirmpassBE.Properties.UseSystemPasswordChar = true;
            }
        }
    }
}
