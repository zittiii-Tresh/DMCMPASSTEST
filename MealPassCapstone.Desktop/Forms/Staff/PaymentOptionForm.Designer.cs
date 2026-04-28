namespace MealPassCapstone.Desktop.Forms.Staff
{
    partial class PaymentOptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentOptionForm));
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            mealpassBTN = new DevExpress.XtraEditors.SimpleButton();
            cashBTN = new DevExpress.XtraEditors.SimpleButton();
            topupBTN = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl1.Appearance.ForeColor = System.Drawing.Color.Green;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new System.Drawing.Point(121, 28);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(212, 19);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "How would you like to pay?";
            // 
            // mealpassBTN
            // 
            mealpassBTN.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(84, 84, 84);
            mealpassBTN.AppearanceHovered.Options.UseBackColor = true;
            mealpassBTN.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(84, 84, 84);
            mealpassBTN.AppearancePressed.Options.UseBackColor = true;
            mealpassBTN.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("mealpassBTN.ImageOptions.Image");
            mealpassBTN.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            mealpassBTN.Location = new System.Drawing.Point(17, 69);
            mealpassBTN.Name = "mealpassBTN";
            mealpassBTN.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            mealpassBTN.Size = new System.Drawing.Size(133, 169);
            mealpassBTN.TabIndex = 13;
            mealpassBTN.Text = "simpleButton3";
            mealpassBTN.Click += mealpassBTN_Click_1;
            // 
            // cashBTN
            // 
            cashBTN.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(84, 84, 84);
            cashBTN.AppearanceHovered.Options.UseBackColor = true;
            cashBTN.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(84, 84, 84);
            cashBTN.AppearancePressed.Options.UseBackColor = true;
            cashBTN.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("cashBTN.ImageOptions.Image");
            cashBTN.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            cashBTN.Location = new System.Drawing.Point(162, 69);
            cashBTN.Name = "cashBTN";
            cashBTN.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            cashBTN.Size = new System.Drawing.Size(133, 169);
            cashBTN.TabIndex = 14;
            cashBTN.Text = "simpleButton1";
            cashBTN.Click += cashBTN_Click_1;
            // 
            // topupBTN
            // 
            topupBTN.AppearanceHovered.BackColor = System.Drawing.Color.MediumSeaGreen;
            topupBTN.AppearanceHovered.Options.UseBackColor = true;
            topupBTN.AppearancePressed.BackColor = System.Drawing.Color.SeaGreen;
            topupBTN.AppearancePressed.Options.UseBackColor = true;
            topupBTN.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("topupBTN.ImageOptions.Image");
            topupBTN.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            topupBTN.Location = new System.Drawing.Point(307, 69);
            topupBTN.Name = "topupBTN";
            topupBTN.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            topupBTN.Size = new System.Drawing.Size(133, 169);
            topupBTN.TabIndex = 15;
            topupBTN.Text = "simpleButton2";
            topupBTN.Click += topupBTN_Click;
            // 
            // PaymentOptionForm
            // 
            Appearance.BackColor = System.Drawing.Color.White;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(459, 254);
            Controls.Add(topupBTN);
            Controls.Add(cashBTN);
            Controls.Add(mealpassBTN);
            Controls.Add(labelControl1);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("PaymentOptionForm.IconOptions.SvgImage");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PaymentOptionForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Payment Option";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton mealpassBTN;
        private DevExpress.XtraEditors.SimpleButton cashBTN;
        private DevExpress.XtraEditors.SimpleButton topupBTN;
    }
}