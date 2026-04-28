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
using MealPassCapstone.Desktop.Forms.Admin;
using Dapper;
using MealPassCapstone.Desktop.Helpers;


namespace MealPassCapstone.Desktop.Forms.Admin
{
    public partial class EmployeesUC : DevExpress.XtraEditors.XtraUserControl
    {
       
        public EmployeesUC()
        {
            InitializeComponent();
            FilterAllEmployees();
        }

        private void addemployeeBTN_Click(object sender, EventArgs e)
        {
           FormHelper.DisplayForm(new Admin.AddEmployeeRibbon());
        }

        private DataTable FilterAllEmployees()
        {
            using (SqlConnection connection = new SqlConnection(GlobalSQL.SQLQuery.connectionString))
            {
                connection.Open();
                string query = GlobalSQL.SQLQuery.FilterAllEmployees;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        gcEmployees.DataSource = dataTable;
                        return dataTable;
                    }
                }
            }
        }

        private void findTE_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            gvEmployees.ApplyFindFilter(e.NewValue as string);
        }

        private void gvEmployees_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string selectedUsername = Convert.ToString(gvEmployees.GetRowCellValue(e.RowHandle, "Username"));

            if (!string.IsNullOrEmpty(selectedUsername))
            {
                using (Forms.Admin.EditEmployeeForm editForm = new Admin.EditEmployeeForm(selectedUsername))
                {
                    editForm.ShowDialog();
                }

                FilterAllEmployees();
            }
        }
    }
}
