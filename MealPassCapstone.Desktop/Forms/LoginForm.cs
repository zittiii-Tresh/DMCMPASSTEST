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
using DevExpress.XtraEditors;
using DevExpress.XtraWaitForm;

namespace MealPassCapstone.Desktop.Forms
{
    public partial class LoginForm : DevExpress.XtraEditors.DirectXForm
    {
        public LoginForm()
        {
            InitializeComponent();
            ApplyTextEditBehaviors();
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            string username = usernameTE.Text.Trim();
            string password = passwordTE.Text;

            using (SqlConnection connection = new SqlConnection(GlobalSQL.SQLQuery.connectionString))
            {
                connection.Open();

                string query = @"
                                SELECT Password, RoleID, FailedAttempts, IsLocked
                                FROM dbo.Employees
                                WHERE Username = @username";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string hashedPassword = reader["Password"].ToString();
                        int roleID = Convert.ToInt32(reader["RoleID"]);
                        int failedAttempts = reader.IsDBNull(reader.GetOrdinal("FailedAttempts")) ? 0 : Convert.ToInt32(reader["FailedAttempts"]);
                        bool isLocked = reader.IsDBNull(reader.GetOrdinal("IsLocked")) ? false : Convert.ToBoolean(reader["IsLocked"]);
                        reader.Close();

                        if (isLocked)
                        {
                            MessageBox.Show("Your account is locked. Please contact the administrator.");
                            //GlobalLogger.employeeLoginLog(username, false);
                            return;
                        }

                        if (BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                        {
                            Helpers.UserSession.Username = username;

                            string resetQuery = @"UPDATE dbo.Employees 
                                                  SET FailedAttempts = 0 
                                                  WHERE Username = @username";

                            using (SqlCommand resetCmd = new SqlCommand(resetQuery, connection))
                            {
                                resetCmd.Parameters.AddWithValue("@username", username);
                                resetCmd.ExecuteNonQuery();
                            }

                            //GlobalLogger.employeeLoginLog(username, true);

                            this.Hide();

                            Form nextForm;

                            if (roleID == 1)
                            {
                                nextForm = new Forms.Admin.MainForm();
                            }
                            else
                            {
                                nextForm = new Staff.StaffMainForm();
                            }

                            nextForm.FormClosed += (s, args) => Application.Exit();

                            nextForm.Show();

                        }
                        else
                        {
                            failedAttempts++;
                            bool shouldLock = failedAttempts >= 5;

                            string updateQuery = @" UPDATE dbo.Employees 
                                                    SET FailedAttempts = @failed, IsLocked = @locked 
                                                    WHERE Username = @username";

                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
                            {
                                updateCmd.Parameters.AddWithValue("@failed", failedAttempts);
                                updateCmd.Parameters.AddWithValue("@locked", shouldLock);
                                updateCmd.Parameters.AddWithValue("@username", username);
                                updateCmd.ExecuteNonQuery();
                            }

                            //GlobalLogger.employeeLoginLog(username, false);

                            if (shouldLock)
                            {
                                MessageBox.Show("Account locked after 5 failed login attempts.");
                            }
                            else if (failedAttempts == 4)
                            {
                                MessageBox.Show("Invalid password. You have 1 attempt left before your account will be locked.");
                            }
                            else
                            {
                                MessageBox.Show($"Invalid password. Attempt {failedAttempts} of 5.");
                            }
                        }
                    }
                    else
                    {
                        reader.Close();
                        //GlobalLogger.employeeLoginLog(username, false);
                        MessageBox.Show("Invalid username or password.");
                    }
                }
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
