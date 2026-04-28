using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MealPassCapstone.Desktop.Helpers
{
    public class FormHelper
    {
        public static async Task LoadUserControlAsync(SidePanel targetPanel, Func<UserControl> controlFactory)
        {

            var controlToLoad = await Task.Run(controlFactory);

            targetPanel.Controls.Clear();
            controlToLoad.Dock = DockStyle.Fill;
            targetPanel.Controls.Add(controlToLoad);
        }

        public static void DisplayForm(Form targetForm)
        {
            targetForm.Show();
        }

        public static async Task LoadUserControl(SidePanel targetPanel, Func<UserControl> controlFactory)
        {
            // Run heavy work in the background if needed (not the control creation itself!)
            await Task.Yield(); // ensures async without blocking

            var controlToLoad = controlFactory(); // construct control on UI thread

            targetPanel.Controls.Clear();
            controlToLoad.Dock = DockStyle.Fill;
            targetPanel.Controls.Add(controlToLoad);
        }
    }
}
