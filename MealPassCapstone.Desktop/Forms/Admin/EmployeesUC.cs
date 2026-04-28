using System;
using System.Data;
using MealPass.Business.Services;
using MealPass.Core.Interface;
using MealPassCapstone.Desktop.Helpers;

namespace MealPassCapstone.Desktop.Forms.Admin
{
    public partial class EmployeesUC : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly IEmployeeService _employeeService = new EmployeeService();

        public EmployeesUC()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void addemployeeBTN_Click(object sender, EventArgs e)
        {
            FormHelper.DisplayForm(new Admin.AddEmployeeRibbon());
        }

        private async void LoadEmployees()
        {
            DataTable dataTable = await _employeeService.FilterAllAsync();
            gcEmployees.DataSource = dataTable;
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

                LoadEmployees();
            }
        }
    }
}
