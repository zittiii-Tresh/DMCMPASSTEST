using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MealPass.Business.Services;
using MealPass.Core.Entity;
using MealPass.Core.Interface;
using MealPassCapstone.Desktop.Helpers;

namespace MealPassCapstone.Desktop.Forms.Admin
{
    public partial class EditEmployeeForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly IEmployeeService _employeeService = new EmployeeService();
        private string username;

        public EditEmployeeForm(string selectedUsername)
        {
            InitializeComponent();
            username = selectedUsername;
            LoadEmployeeData();
            SetupToggleSwitch();
            UpdateAvailabilityLabel();
        }

        private void changepasswordHLBL_Click(object sender, EventArgs e)
        {
            FormHelper.DisplayForm(new Admin.EditPasswordForm(username));
        }

        private void SetupToggleSwitch()
        {
            accountTS.Properties.ValueOff = "Unlocked";
            accountTS.Properties.ValueOn = "Locked";
            var a = accountTS.Properties.GetValueByState(false);
            var b = accountTS.Properties.GetStateByValue("Locked");
            var c = accountTS.Properties.GetStateByValue("Unlocked");
        }

        private void UpdateAvailabilityLabel()
        {
            if (accountTS.IsOn)
            {
                availabilityLC.Text = "Locked";
                availabilityLC.ForeColor = Color.Green;
            }
            else
            {
                availabilityLC.Text = "Unlocked";
                availabilityLC.ForeColor = Color.Red;
            }
        }

        private void accountTS_Toggled(object sender, EventArgs e)
        {
            UpdateAvailabilityLabel();
        }

        private async void LoadEmployeeData()
        {
            var employee = await _employeeService.GetByUsernameAsync(username);

            if (employee == null)
            {
                XtraMessageBox.Show("Employee not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            firstnameTE.Text = employee.FirstName;
            middlenameTE.Text = employee.MiddleName;
            lastnameTE.Text = employee.LastName;
            extensionTE.Text = employee.NameExtension;
            contactTE.Text = employee.ContactNo;

            if (employee.Birthdate == null || string.IsNullOrEmpty(employee.Birthdate.ToString()))
            {
                birthdateDE.EditValue = null;
            }
            else
            {
                birthdateDE.DateTime = (DateTime)employee.Birthdate;
            }

            civilstatusCBE.SelectedIndex = Convert.ToInt32(employee.CivilStatusID) - 1;
            usernameTE.Text = employee.Username;
            positionRG.SelectedIndex = Convert.ToInt32(employee.RoleID) - 1;

            if (employee.Gender == "Male")
                genderRG.SelectedIndex = 0;
            else if (employee.Gender == "Female")
                genderRG.SelectedIndex = 1;
            else
                genderRG.SelectedIndex = -1;

            employeeRG.SelectedIndex = Convert.ToInt32(employee.EmploymentStatus) - 1;

            if (employee.IsLocked == null)
            {
                accountTS.IsOn = false;
            }
            else if (employee.IsLocked is bool boolVal)
            {
                accountTS.IsOn = boolVal;
            }
            else
            {
                string val = employee.IsLocked.ToString();
                accountTS.IsOn = val == "Locked" || val == "1" || val.Equals("true", StringComparison.OrdinalIgnoreCase);
            }
        }

        private async void saveBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstnameTE.Text) ||
                string.IsNullOrWhiteSpace(lastnameTE.Text) ||
                string.IsNullOrWhiteSpace(usernameTE.Text))
            {
                XtraMessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (birthdateDE.EditValue == null)
            {
                XtraMessageBox.Show("Please select a birthdate.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var employee = new Employee
            {
                RoleID = positionRG.SelectedIndex + 1,
                FirstName = firstnameTE.Text.Trim(),
                MiddleName = middlenameTE.Text.Trim(),
                LastName = lastnameTE.Text.Trim(),
                NameExtension = extensionTE.Text.Trim(),
                ContactNo = contactTE.Text.Trim(),
                Username = usernameTE.Text.Trim(),
                Gender = genderRG.Text.Trim(),
                Birthdate = birthdateDE.DateTime.Date,
                CivilStatusID = civilstatusCBE.SelectedIndex + 1,
                EmploymentStatus = employeeRG.SelectedIndex + 1,
                IsLocked = accountTS.IsOn ? 1 : 0
            };

            int rowsAffected = await _employeeService.UpdateAsync(employee, username);

            if (rowsAffected > 0)
            {
                XtraMessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployeeData();
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("No record updated. Employee may not exist.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void deleteBTN_Click(object sender, EventArgs e)
        {
            DialogResult confirm = XtraMessageBox.Show(
                "Are you sure you want to delete this employee?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            int rowsAffected = await _employeeService.DeleteByUsernameAsync(username);

            if (rowsAffected > 0)
            {
                XtraMessageBox.Show("Employee deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Failed to delete. Employee may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
