using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MealPass.Business.Services;
using MealPass.Core.Entity;
using MealPass.Core.Interface;

namespace MealPassCapstone.Desktop.Forms.Admin
{
    public partial class AddEmployeeRibbon : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly IEmployeeService _employeeService = new EmployeeService();
        private readonly IPasswordService _passwordService = new PasswordService();

        public AddEmployeeRibbon()
        {
            InitializeComponent();
            ApplyTextEditBehaviors();
            passwordBE.Tag = "eyeopen";
            passwordBE.Properties.Buttons[0].ImageOptions.Image = imageCollection1.Images[0];
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

        private void ApplyTextEditBehaviors()
        {
            Helpers.TextHelper.AttachBehavior(passwordBE, "Password", true);
        }

        private void passwordBE_EditValueChanged(object sender, EventArgs e)
        {
            string password = passwordBE.Text;
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

        private async void addemployeeBTN_Click(object sender, EventArgs e)
        {
            var confirmResult = XtraMessageBox.Show("Do you want to save this account?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult != DialogResult.Yes)
                return;

            string username = usernameTE.Text.Trim();

            if (await _employeeService.UsernameExistsAsync(username))
            {
                XtraMessageBox.Show("Username already exists!", "Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int roleID = Convert.ToInt32(positionRG.EditValue);
            string gender = genderRG.EditValue?.ToString();

            int civilStatusID = 0;
            switch (civilstatusCBE.EditValue?.ToString())
            {
                case "Single": civilStatusID = 1; break;
                case "Married": civilStatusID = 2; break;
                case "Widowed": civilStatusID = 3; break;
                case "Separated": civilStatusID = 4; break;
                default: civilStatusID = 0; break;
            }

            var employee = new Employee
            {
                FirstName = firstnameTE.Text,
                MiddleName = middlenameTE.Text,
                LastName = lastnameTE.Text,
                NameExtension = string.IsNullOrWhiteSpace(extensionTE.Text) || extensionTE.Text == "Extension" ? null : extensionTE.Text,
                ContactNo = contactTE.Text,
                CivilStatusID = civilStatusID,
                Birthdate = (DateTime)(birthdateDE.EditValue == null ? (DateTime?)null : (DateTime)birthdateDE.EditValue),
                Username = username,
                EmploymentStatus = 1,
                RoleID = roleID,
                Gender = gender
            };

            await _employeeService.RegisterAsync(employee, passwordBE.Text);

            XtraMessageBox.Show("Account saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
