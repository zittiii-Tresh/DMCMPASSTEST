namespace MealPassCapstone.Desktop.Forms.Staff
{
    partial class TopUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopUpForm));
            studentidTE = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            confirmBTN = new DevExpress.XtraEditors.SimpleButton();
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            accountbalanceLBL = new DevExpress.XtraEditors.LabelControl();
            topupamountTE = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)studentidTE.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)topupamountTE.Properties).BeginInit();
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
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(0, 191, 99);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new System.Drawing.Point(35, 78);
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
            labelControl3.Location = new System.Drawing.Point(35, 129);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(135, 18);
            labelControl3.TabIndex = 3;
            labelControl3.Text = "Amount to Top-Up:";
            // 
            // confirmBTN
            // 
            confirmBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(56, 107, 60);
            confirmBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            confirmBTN.Appearance.Options.UseBackColor = true;
            confirmBTN.Appearance.Options.UseFont = true;
            confirmBTN.Location = new System.Drawing.Point(34, 223);
            confirmBTN.Name = "confirmBTN";
            confirmBTN.Size = new System.Drawing.Size(204, 31);
            confirmBTN.TabIndex = 7;
            confirmBTN.Text = "Confirm Purchase";
            // 
            // pictureEdit1
            // 
            pictureEdit1.EditValue = resources.GetObject("pictureEdit1.EditValue");
            pictureEdit1.Location = new System.Drawing.Point(343, 33);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            pictureEdit1.Size = new System.Drawing.Size(225, 236);
            pictureEdit1.TabIndex = 8;
            // 
            // accountbalanceLBL
            // 
            accountbalanceLBL.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            accountbalanceLBL.Appearance.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            accountbalanceLBL.Appearance.Options.UseFont = true;
            accountbalanceLBL.Appearance.Options.UseForeColor = true;
            accountbalanceLBL.Location = new System.Drawing.Point(286, 77);
            accountbalanceLBL.Name = "accountbalanceLBL";
            accountbalanceLBL.Size = new System.Drawing.Size(32, 16);
            accountbalanceLBL.TabIndex = 10;
            accountbalanceLBL.Text = "00.00";
            // 
            // topupamountTE
            // 
            topupamountTE.Location = new System.Drawing.Point(35, 159);
            topupamountTE.Name = "topupamountTE";
            topupamountTE.Properties.AutoHeight = false;
            topupamountTE.Size = new System.Drawing.Size(289, 28);
            topupamountTE.TabIndex = 11;
            // 
            // TopUpForm
            // 
            Appearance.BackColor = System.Drawing.Color.White;
            Appearance.ForeColor = System.Drawing.Color.White;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseForeColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(557, 281);
            Controls.Add(topupamountTE);
            Controls.Add(accountbalanceLBL);
            Controls.Add(pictureEdit1);
            Controls.Add(confirmBTN);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            Controls.Add(studentidTE);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("TopUpForm.IconOptions.SvgImage");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TopUpForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Top-Up";
            ((System.ComponentModel.ISupportInitialize)studentidTE.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)topupamountTE.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit studentidTE;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton confirmBTN;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl accountbalanceLBL;
        private DevExpress.XtraEditors.TextEdit topupamountTE;
    }
}