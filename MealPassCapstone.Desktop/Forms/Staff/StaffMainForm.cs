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

namespace MealPassCapstone.Desktop.Forms.Staff
{
    public partial class StaffMainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public StaffMainForm()
        {
            InitializeComponent();
            datetimeLBL.Text = DateTime.Now.ToString("F");
        }

        private async void posACE_Click(object sender, EventArgs e)
        {
            await FormHelper.LoadUserControlAsync(mainSPanel, () => new Staff.PosUC());
        }
    }
}