using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MealPassCapstone.Desktop.Helpers;

namespace MealPassCapstone.Desktop.Forms.Staff
{
    public partial class PaymentOptionForm : DevExpress.XtraEditors.XtraForm
    {
        public PaymentOptionForm()
        {
            InitializeComponent();
        }

        private void mealpassBTN_Click_1(object sender, EventArgs e)
        {
            FormHelper.DisplayForm(new Staff.ScanRFIDForm());
        }

        private void cashBTN_Click_1(object sender, EventArgs e)
        {
            FormHelper.DisplayForm(new Staff.CashOptionForm());
        }

        private void topupBTN_Click(object sender, EventArgs e)
        {
            FormHelper.DisplayForm(new Staff.TopUpForm());
        }
    }
}