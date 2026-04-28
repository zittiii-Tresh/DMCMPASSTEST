using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using MealPassCapstone.Desktop.Helpers;

namespace MealPassCapstone.Desktop.Forms.Admin
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            datetimeLBL.Text = DateTime.Now.ToString("F");
        }

        private async void employeelistACE_Click(object sender, EventArgs e)
        {
            await FormHelper.LoadUserControlAsync(mainSPanel, () => new Admin.EmployeesUC());
        }

        private async void productsACE_Click(object sender, EventArgs e)
        {
            await FormHelper.LoadUserControlAsync(mainSPanel, () => new Admin.ProductsUC());
        }

        private async void salesreportACE_Click(object sender, EventArgs e)
        {
            await FormHelper.LoadUserControlAsync(mainSPanel, () => new Admin.SalesUC());
        }

        private async void employeelogsACE_Click(object sender, EventArgs e)
        {
            await FormHelper.LoadUserControlAsync(mainSPanel, () => new Admin.EmployeeLogsUC());
        }

        private async void topuphistoryACE_Click(object sender, EventArgs e)
        {
            await FormHelper.LoadUserControlAsync(mainSPanel, () => new Admin.TopUpHistoryUC());
        }

        private async void purchasehistoryACE_Click(object sender, EventArgs e)
        {
            await FormHelper.LoadUserControlAsync(mainSPanel, () => new Admin.PurchaseHistoryUC());
        }

        private async void posACE_Click(object sender, EventArgs e)
        {
            await FormHelper.LoadUserControlAsync(mainSPanel, () => new Staff.PosUC());
        }
    }
}