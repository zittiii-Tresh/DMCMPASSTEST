namespace MealPassCapstone.Desktop.Forms.Staff
{
    partial class ScanRFIDForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScanRFIDForm));
            studentidTE = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            confirmBTN = new DevExpress.XtraEditors.SimpleButton();
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            totalamountLBL = new DevExpress.XtraEditors.LabelControl();
            accountbalanceLBL = new DevExpress.XtraEditors.LabelControl();
            remainingLBL = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)studentidTE.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // studentidTE
            // 
            studentidTE.Location = new System.Drawing.Point(34, 29);
            studentidTE.Name = "studentidTE";
            studentidTE.Properties.AutoHeight = false;
            studentidTE.Size = new System.Drawing.Size(289, 28);
            studentidTE.TabIndex = 0;
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
            labelControl2.Size = new System.Drawing.Size(116, 16);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "Account Balance:";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl3.Appearance.ForeColor = System.Drawing.Color.Green;
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.Location = new System.Drawing.Point(35, 163);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(149, 18);
            labelControl3.TabIndex = 3;
            labelControl3.Text = "Remaining Balance:";
            // 
            // confirmBTN
            // 
            confirmBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(56, 107, 60);
            confirmBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            confirmBTN.Appearance.Options.UseBackColor = true;
            confirmBTN.Appearance.Options.UseFont = true;
            confirmBTN.Location = new System.Drawing.Point(34, 206);
            confirmBTN.Name = "confirmBTN";
            confirmBTN.Size = new System.Drawing.Size(204, 31);
            confirmBTN.TabIndex = 7;
            confirmBTN.Text = "Confirm Purchase";
            // 
            // pictureEdit1
            // 
            pictureEdit1.EditValue = resources.GetObject("pictureEdit1.EditValue");
            pictureEdit1.Location = new System.Drawing.Point(346, 44);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            pictureEdit1.Size = new System.Drawing.Size(197, 201);
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
            // remainingLBL
            // 
            remainingLBL.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            remainingLBL.Appearance.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            remainingLBL.Appearance.Options.UseFont = true;
            remainingLBL.Appearance.Options.UseForeColor = true;
            remainingLBL.Location = new System.Drawing.Point(286, 163);
            remainingLBL.Name = "remainingLBL";
            remainingLBL.Size = new System.Drawing.Size(32, 16);
            remainingLBL.TabIndex = 11;
            remainingLBL.Text = "00.00";
            // 
            // ScanRFIDForm
            // 
            Appearance.BackColor = System.Drawing.Color.White;
            Appearance.ForeColor = System.Drawing.Color.White;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseForeColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(557, 264);
            Controls.Add(remainingLBL);
            Controls.Add(accountbalanceLBL);
            Controls.Add(totalamountLBL);
            Controls.Add(pictureEdit1);
            Controls.Add(confirmBTN);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Controls.Add(studentidTE);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ScanRFIDForm.IconOptions.SvgImage");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ScanRFIDForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Scan RFID";
            ((System.ComponentModel.ISupportInitialize)studentidTE.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit studentidTE;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton confirmBTN;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl totalamountLBL;
        private DevExpress.XtraEditors.LabelControl accountbalanceLBL;
        private DevExpress.XtraEditors.LabelControl remainingLBL;
    }
}