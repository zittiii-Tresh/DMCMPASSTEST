namespace MealPassCapstone.Desktop.Forms.Staff
{
    partial class CashOptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashOptionForm));
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            confirmBTN = new DevExpress.XtraEditors.SimpleButton();
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            totalamountLBL = new DevExpress.XtraEditors.LabelControl();
            accountbalanceLBL = new DevExpress.XtraEditors.LabelControl();
            cashpaymentTE = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cashpaymentTE.Properties).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl1.Appearance.ForeColor = System.Drawing.Color.Green;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new System.Drawing.Point(35, 80);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(89, 16);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "Total Amount:";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl2.Appearance.ForeColor = System.Drawing.Color.Green;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new System.Drawing.Point(35, 121);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(56, 16);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "Change:";
            // 
            // confirmBTN
            // 
            confirmBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(56, 107, 60);
            confirmBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            confirmBTN.Appearance.Options.UseBackColor = true;
            confirmBTN.Appearance.Options.UseFont = true;
            confirmBTN.Location = new System.Drawing.Point(34, 164);
            confirmBTN.Name = "confirmBTN";
            confirmBTN.Size = new System.Drawing.Size(204, 31);
            confirmBTN.TabIndex = 7;
            confirmBTN.Text = "Confirm Purchase";
            // 
            // pictureEdit1
            // 
            pictureEdit1.EditValue = resources.GetObject("pictureEdit1.EditValue");
            pictureEdit1.Location = new System.Drawing.Point(351, 26);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            pictureEdit1.Size = new System.Drawing.Size(186, 181);
            pictureEdit1.TabIndex = 8;
            // 
            // totalamountLBL
            // 
            totalamountLBL.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            totalamountLBL.Appearance.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            totalamountLBL.Appearance.Options.UseFont = true;
            totalamountLBL.Appearance.Options.UseForeColor = true;
            totalamountLBL.Location = new System.Drawing.Point(286, 80);
            totalamountLBL.Name = "totalamountLBL";
            totalamountLBL.Size = new System.Drawing.Size(32, 16);
            totalamountLBL.TabIndex = 9;
            totalamountLBL.Text = "00.00";
            // 
            // accountbalanceLBL
            // 
            accountbalanceLBL.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            accountbalanceLBL.Appearance.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            accountbalanceLBL.Appearance.Options.UseFont = true;
            accountbalanceLBL.Appearance.Options.UseForeColor = true;
            accountbalanceLBL.Location = new System.Drawing.Point(286, 121);
            accountbalanceLBL.Name = "accountbalanceLBL";
            accountbalanceLBL.Size = new System.Drawing.Size(32, 16);
            accountbalanceLBL.TabIndex = 10;
            accountbalanceLBL.Text = "00.00";
            // 
            // cashpaymentTE
            // 
            cashpaymentTE.EditValue = "Input Payment";
            cashpaymentTE.Location = new System.Drawing.Point(34, 29);
            cashpaymentTE.Name = "cashpaymentTE";
            cashpaymentTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cashpaymentTE.Properties.Appearance.Options.UseFont = true;
            cashpaymentTE.Properties.Appearance.Options.UseTextOptions = true;
            cashpaymentTE.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            cashpaymentTE.Properties.AutoHeight = false;
            cashpaymentTE.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            cashpaymentTE.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            cashpaymentTE.Properties.MaskSettings.Set("mask", "c");
            cashpaymentTE.Size = new System.Drawing.Size(289, 28);
            cashpaymentTE.TabIndex = 0;
            // 
            // CashOptionForm
            // 
            Appearance.BackColor = System.Drawing.Color.White;
            Appearance.ForeColor = System.Drawing.Color.White;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseForeColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(557, 229);
            Controls.Add(accountbalanceLBL);
            Controls.Add(totalamountLBL);
            Controls.Add(pictureEdit1);
            Controls.Add(confirmBTN);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Controls.Add(cashpaymentTE);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("CashOptionForm.IconOptions.SvgImage");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CashOptionForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Cash";
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cashpaymentTE.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton confirmBTN;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl totalamountLBL;
        private DevExpress.XtraEditors.LabelControl accountbalanceLBL;
        private DevExpress.XtraEditors.TextEdit cashpaymentTE;
    }
}