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
using DevExpress.XtraRichEdit.Import.Html;
using MealPass.Core;
using MealPassCapstone.Desktop.Helpers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MealPassCapstone.Desktop.Forms.Admin
{
    public partial class EditEmployeeForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
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
            var a = accountTS.Properties.GetValueByState(false); // returns "Disabled"
            var b = accountTS.Properties.GetStateByValue("Locked"); // returns true
            var c = accountTS.Properties.GetStateByValue("Unlocked"); // returns false
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

        private void LoadEmployeeData()
        {
            using (var connection = new SqlConnection(GlobalSQL.SQLQuery.connectionString))
            {
                connection.Open();

                string query = GlobalSQL.SQLQuery.FilterEmployeeData;

                var employee = connection.QueryFirstOrDefault<dynamic>(query, new { Username = username });

                if (employee != null)
                {
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
                        accountTS.IsOn = false; // default when null
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
                else
                {
                    XtraMessageBox.Show("Employee not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        public bool UpdateEmployee(MealPass.Core.Employee employee, string username)
        {
            using (var connection = new SqlConnection(GlobalSQL.SQLQuery.connectionString))
            {
                connection.Open();

                string updateQuery = GlobalSQL.SQLQuery.UpdateAccount;

                var parameters = new
                {
                    employee.RoleID,
                    employee.FirstName,
                    employee.MiddleName,
                    employee.LastName,
                    employee.NameExtension,
                    employee.Gender,
                    employee.Birthdate,
                    employee.ContactNo,
                    employee.CivilStatusID,
                    employee.Username,
                    employee.EmploymentStatus,
                    employee.IsLocked,
                    OriginalUsername = username
                };

                int rowsAffected = connection.Execute(updateQuery, parameters); // ✅ no commandType here

                if (rowsAffected > 0)
                {
                    //GlobalLogger.employeeLog("Edited employee details", UserSession.Username);

                    XtraMessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    XtraMessageBox.Show("No record updated. Employee may not exist.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
        }

        private void saveBTN_Click(object sender, EventArgs e)
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

            var employee = new MealPass.Core.Employee
            {
                RoleID = positionRG.SelectedIndex + 1,
                FirstName = firstnameTE.Text.Trim(),
                MiddleName = middlenameTE.Text.Trim(),
                LastName = lastnameTE.Text.Trim(),
                NameExtension = extensionTE.Text.Trim(),
                ContactNo = contactTE.Text.Trim(),
                Username = usernameTE.Text.Trim(),
                Gender = genderRG.Text.Trim(),

                Birthdate = birthdateDE.DateTime.Date, // ✅ handle null


                CivilStatusID = civilstatusCBE.SelectedIndex + 1,
                //Password = finalPassword,
                EmploymentStatus = employeeRG.SelectedIndex + 1,
                IsLocked = accountTS.IsOn ? 1 : 0

            };

            bool result = UpdateEmployee(employee, username);

            if (result)
            {
                LoadEmployeeData();
                this.Close();
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            DialogResult confirm = XtraMessageBox.Show(
              "Are you sure you want to delete this employee?",
              "Confirm Delete",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning
          );

            if (confirm != DialogResult.Yes)
                return;

            using (var connection = new SqlConnection(GlobalSQL.SQLQuery.connectionString))
            {
                connection.Open();

                string deleteQuery = @"DELETE FROM dbo.Employees WHERE Username = @Username";

                int rowsAffected = connection.Execute(deleteQuery, new { Username = username });

                if (rowsAffected > 0)
                {
                    //GlobalLogger.employeeLog("Deleted employee", UserSession.Username);

                    XtraMessageBox.Show("Employee deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the edit form
                }
                else
                {
                    XtraMessageBox.Show("Failed to delete. Employee may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
