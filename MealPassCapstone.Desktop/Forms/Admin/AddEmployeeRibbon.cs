using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using MealPass.Core;
using MealPassCapstone.Desktop.Helpers;


namespace MealPassCapstone.Desktop.Forms.Admin
{
    public partial class AddEmployeeRibbon : DevExpress.XtraBars.Ribbon.RibbonForm
    {
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
            string message = "";

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

        private static void RegisterAccount(Employee employee)
        {
            using (var connection = new SqlConnection(Desktop.GlobalSQL.SQLQuery.connectionString))
            {
                connection.Open();

                var query = Desktop.GlobalSQL.SQLQuery.InsertAccount;
                int rowsAffected = connection.Execute(query, employee);
            }
        }

        private bool UsernameExists(string username)
        {
            using (var connection = new SqlConnection(Desktop.GlobalSQL.SQLQuery.connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM dbo.Employees WHERE Username = @Username";
                int count = connection.ExecuteScalar<int>(query, new { Username = username });
                return count > 0;
            }
        }

        private void addemployeeBTN_Click(object sender, EventArgs e)
        {
            var confirmResult = XtraMessageBox.Show("Do you want to save this account?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult != DialogResult.Yes)
                return;

            string username = usernameTE.Text.Trim();

            if (UsernameExists(username))
            {
                XtraMessageBox.Show("Username already exists!", "Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int roleID = Convert.ToInt32(positionRG.EditValue);
            string gender = genderRG.EditValue?.ToString();

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(passwordBE.Text);

            int civilStatusID = 0;
            switch (civilstatusCBE.EditValue?.ToString())
            {
                case "Single":
                    civilStatusID = 1;
                    break;
                case "Married":
                    civilStatusID = 2;
                    break;
                case "Widowed":
                    civilStatusID = 3;
                    break;
                case "Separated":
                    civilStatusID = 4;
                    break;
                default:
                    civilStatusID = 0; // Or handle invalid case
                    break;
            }

            var employee = new MealPass.Core.Employee
            {
                FirstName = firstnameTE.Text,
                MiddleName = middlenameTE.Text,
                LastName = lastnameTE.Text,
                NameExtension = string.IsNullOrWhiteSpace(extensionTE.Text) || extensionTE.Text == "Extension" ? null : extensionTE.Text,
                ContactNo = contactTE.Text,
                CivilStatusID = civilStatusID,
                Birthdate = (DateTime)(birthdateDE.EditValue == null ? (DateTime?)null : (DateTime)birthdateDE.EditValue),
                Username = username,
                Password = hashedPassword,
                EmploymentStatus = 1,
                RoleID = roleID,
                Gender = gender
            };

            RegisterAccount(employee);

            //GlobalLogger.employeeLog("Added new employee", UserSession.Username);
            XtraMessageBox.Show("Account saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

    }
}
