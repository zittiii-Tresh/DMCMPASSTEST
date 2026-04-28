using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using System.Drawing;

namespace MealPassCapstone.Desktop.Helpers
{
    public class TextHelper
    {
        public static void AttachBehavior(TextEdit textEdit, string defaultText, bool isPassword = false)
        {
            textEdit.Text = defaultText;
            textEdit.ForeColor = Color.DarkGray;
            textEdit.Properties.UseSystemPasswordChar = false;

            textEdit.Enter += (s, e) =>
            {
                if (textEdit.Text == defaultText)
                {
                    textEdit.Text = "";
                    textEdit.ForeColor = Color.Black;

                    if (isPassword)
                        textEdit.Properties.UseSystemPasswordChar = true;
                }
            };

            textEdit.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textEdit.Text))
                {
                    textEdit.Text = defaultText;
                    textEdit.ForeColor = Color.DarkGray;
                    if (isPassword)
                        textEdit.Properties.UseSystemPasswordChar = false;
                }
            };

            textEdit.EditValueChanged += (s, e) =>
            {
                if (textEdit.Text != defaultText)
                {
                    textEdit.ForeColor = Color.DarkGray;
                    if (isPassword)
                        textEdit.Properties.UseSystemPasswordChar = true;
                }
            };
        }
    }
}
