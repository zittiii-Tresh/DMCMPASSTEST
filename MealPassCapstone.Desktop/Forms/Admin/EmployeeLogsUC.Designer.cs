namespace MealPassCapstone.Desktop.Forms.Admin
{
    partial class EmployeeLogsUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeLogsUC));
            sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            printBTN = new DevExpress.XtraEditors.SimpleButton();
            sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            sidePanel7 = new DevExpress.XtraEditors.SidePanel();
            sidePanel4 = new DevExpress.XtraEditors.SidePanel();
            sidePanel5 = new DevExpress.XtraEditors.SidePanel();
            gcEmployeeLogs = new DevExpress.XtraGrid.GridControl();
            gvEmployeeLogs = new DevExpress.XtraGrid.Views.Grid.GridView();
            EmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            LogID = new DevExpress.XtraGrid.Columns.GridColumn();
            Username = new DevExpress.XtraGrid.Columns.GridColumn();
            DateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            Activity = new DevExpress.XtraGrid.Columns.GridColumn();
            Authentication = new DevExpress.XtraGrid.Columns.GridColumn();
            sidePanel1.SuspendLayout();
            sidePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gcEmployeeLogs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvEmployeeLogs).BeginInit();
            SuspendLayout();
            // 
            // sidePanel1
            // 
            sidePanel1.AllowResize = false;
            sidePanel1.Appearance.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            sidePanel1.Appearance.Options.UseBackColor = true;
            sidePanel1.BorderThickness = 0;
            sidePanel1.Controls.Add(sidePanel3);
            sidePanel1.Controls.Add(sidePanel2);
            sidePanel1.Controls.Add(labelControl1);
            sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            sidePanel1.Location = new System.Drawing.Point(0, 0);
            sidePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            sidePanel1.Name = "sidePanel1";
            sidePanel1.Size = new System.Drawing.Size(1236, 78);
            sidePanel1.TabIndex = 1;
            sidePanel1.Text = "sidePanel1";
            // 
            // sidePanel3
            // 
            sidePanel3.AllowResize = false;
            sidePanel3.Appearance.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            sidePanel3.Appearance.Options.UseBackColor = true;
            sidePanel3.BorderThickness = 0;
            sidePanel3.Controls.Add(printBTN);
            sidePanel3.Dock = System.Windows.Forms.DockStyle.Right;
            sidePanel3.Location = new System.Drawing.Point(1046, 24);
            sidePanel3.Name = "sidePanel3";
            sidePanel3.Size = new System.Drawing.Size(190, 54);
            sidePanel3.TabIndex = 3;
            sidePanel3.Text = "sidePanel3";
            // 
            // printBTN
            // 
            printBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(89, 141, 57);
            printBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            printBTN.Appearance.Options.UseBackColor = true;
            printBTN.Appearance.Options.UseFont = true;
            printBTN.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("printBTN.ImageOptions.SvgImage");
            printBTN.Location = new System.Drawing.Point(42, 5);
            printBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            printBTN.Name = "printBTN";
            printBTN.Padding = new System.Windows.Forms.Padding(2);
            printBTN.Size = new System.Drawing.Size(103, 40);
            printBTN.TabIndex = 25;
            printBTN.Text = "PRINT";
            // 
            // sidePanel2
            // 
            sidePanel2.AllowResize = false;
            sidePanel2.Appearance.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            sidePanel2.Appearance.Options.UseBackColor = true;
            sidePanel2.BorderThickness = 0;
            sidePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            sidePanel2.Location = new System.Drawing.Point(0, 0);
            sidePanel2.Name = "sidePanel2";
            sidePanel2.Size = new System.Drawing.Size(1236, 24);
            sidePanel2.TabIndex = 2;
            sidePanel2.Text = "sidePanel2";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(27, 125, 79);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new System.Drawing.Point(50, 27);
            labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(214, 36);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "Employee Logs";
            // 
            // sidePanel7
            // 
            sidePanel7.AllowResize = false;
            sidePanel7.Appearance.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            sidePanel7.Appearance.Options.UseBackColor = true;
            sidePanel7.BorderThickness = 0;
            sidePanel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            sidePanel7.Location = new System.Drawing.Point(50, 558);
            sidePanel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            sidePanel7.Name = "sidePanel7";
            sidePanel7.Size = new System.Drawing.Size(1141, 45);
            sidePanel7.TabIndex = 3;
            sidePanel7.Text = "sidePanel7";
            // 
            // sidePanel4
            // 
            sidePanel4.AllowResize = false;
            sidePanel4.Appearance.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            sidePanel4.Appearance.Options.UseBackColor = true;
            sidePanel4.BorderThickness = 0;
            sidePanel4.Dock = System.Windows.Forms.DockStyle.Left;
            sidePanel4.Location = new System.Drawing.Point(0, 78);
            sidePanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            sidePanel4.Name = "sidePanel4";
            sidePanel4.Size = new System.Drawing.Size(50, 525);
            sidePanel4.TabIndex = 5;
            sidePanel4.Text = "sidePanel4";
            // 
            // sidePanel5
            // 
            sidePanel5.AllowResize = false;
            sidePanel5.Appearance.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            sidePanel5.Appearance.Options.UseBackColor = true;
            sidePanel5.BorderThickness = 0;
            sidePanel5.Dock = System.Windows.Forms.DockStyle.Right;
            sidePanel5.Location = new System.Drawing.Point(1191, 78);
            sidePanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            sidePanel5.Name = "sidePanel5";
            sidePanel5.Size = new System.Drawing.Size(45, 525);
            sidePanel5.TabIndex = 4;
            sidePanel5.Text = "sidePanel5";
            // 
            // gcEmployeeLogs
            // 
            gcEmployeeLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            gcEmployeeLogs.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gcEmployeeLogs.Location = new System.Drawing.Point(50, 78);
            gcEmployeeLogs.MainView = gvEmployeeLogs;
            gcEmployeeLogs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gcEmployeeLogs.Name = "gcEmployeeLogs";
            gcEmployeeLogs.Size = new System.Drawing.Size(1141, 480);
            gcEmployeeLogs.TabIndex = 6;
            gcEmployeeLogs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvEmployeeLogs });
            // 
            // gvEmployeeLogs
            // 
            gvEmployeeLogs.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { EmployeeName, LogID, Username, DateTime, Activity, Authentication });
            gvEmployeeLogs.DetailHeight = 284;
            gvEmployeeLogs.GridControl = gcEmployeeLogs;
            gvEmployeeLogs.Name = "gvEmployeeLogs";
            gvEmployeeLogs.OptionsEditForm.PopupEditFormWidth = 686;
            // 
            // EmployeeName
            // 
            EmployeeName.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            EmployeeName.AppearanceCell.Options.UseFont = true;
            EmployeeName.AppearanceCell.Options.UseTextOptions = true;
            EmployeeName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            EmployeeName.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(26, 42, 21);
            EmployeeName.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            EmployeeName.AppearanceHeader.Options.UseBackColor = true;
            EmployeeName.AppearanceHeader.Options.UseFont = true;
            EmployeeName.AppearanceHeader.Options.UseTextOptions = true;
            EmployeeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            EmployeeName.Caption = "Employee Name";
            EmployeeName.FieldName = "EmployeeName";
            EmployeeName.Name = "EmployeeName";
            EmployeeName.Visible = true;
            EmployeeName.VisibleIndex = 1;
            EmployeeName.Width = 358;
            // 
            // LogID
            // 
            LogID.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            LogID.AppearanceCell.Options.UseFont = true;
            LogID.AppearanceCell.Options.UseTextOptions = true;
            LogID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            LogID.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(26, 42, 21);
            LogID.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            LogID.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            LogID.AppearanceHeader.Options.UseBackColor = true;
            LogID.AppearanceHeader.Options.UseFont = true;
            LogID.AppearanceHeader.Options.UseForeColor = true;
            LogID.AppearanceHeader.Options.UseTextOptions = true;
            LogID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            LogID.Caption = "#";
            LogID.FieldName = "LogID";
            LogID.MinWidth = 21;
            LogID.Name = "LogID";
            LogID.OptionsColumn.AllowEdit = false;
            LogID.OptionsColumn.AllowFocus = false;
            LogID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            LogID.Visible = true;
            LogID.VisibleIndex = 0;
            LogID.Width = 95;
            // 
            // Username
            // 
            Username.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            Username.AppearanceCell.Options.UseFont = true;
            Username.AppearanceCell.Options.UseTextOptions = true;
            Username.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            Username.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(26, 42, 21);
            Username.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            Username.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            Username.AppearanceHeader.Options.UseBackColor = true;
            Username.AppearanceHeader.Options.UseFont = true;
            Username.AppearanceHeader.Options.UseForeColor = true;
            Username.AppearanceHeader.Options.UseTextOptions = true;
            Username.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Username.Caption = "Username";
            Username.FieldName = "Username";
            Username.MinWidth = 21;
            Username.Name = "Username";
            Username.OptionsColumn.AllowEdit = false;
            Username.OptionsColumn.AllowFocus = false;
            Username.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            Username.Visible = true;
            Username.VisibleIndex = 2;
            Username.Width = 237;
            // 
            // DateTime
            // 
            DateTime.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            DateTime.AppearanceCell.Options.UseFont = true;
            DateTime.AppearanceCell.Options.UseTextOptions = true;
            DateTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            DateTime.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(26, 42, 21);
            DateTime.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            DateTime.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            DateTime.AppearanceHeader.Options.UseBackColor = true;
            DateTime.AppearanceHeader.Options.UseFont = true;
            DateTime.AppearanceHeader.Options.UseForeColor = true;
            DateTime.AppearanceHeader.Options.UseTextOptions = true;
            DateTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            DateTime.Caption = "Date/Time";
            DateTime.FieldName = "DateTime";
            DateTime.MinWidth = 21;
            DateTime.Name = "DateTime";
            DateTime.OptionsColumn.AllowEdit = false;
            DateTime.OptionsColumn.AllowFocus = false;
            DateTime.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            DateTime.Visible = true;
            DateTime.VisibleIndex = 3;
            DateTime.Width = 176;
            // 
            // Activity
            // 
            Activity.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic);
            Activity.AppearanceCell.ForeColor = System.Drawing.Color.Gray;
            Activity.AppearanceCell.Options.UseFont = true;
            Activity.AppearanceCell.Options.UseForeColor = true;
            Activity.AppearanceCell.Options.UseTextOptions = true;
            Activity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Activity.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(26, 42, 21);
            Activity.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            Activity.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            Activity.AppearanceHeader.Options.UseBackColor = true;
            Activity.AppearanceHeader.Options.UseFont = true;
            Activity.AppearanceHeader.Options.UseForeColor = true;
            Activity.AppearanceHeader.Options.UseTextOptions = true;
            Activity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Activity.Caption = "Activity";
            Activity.FieldName = "Activity";
            Activity.MinWidth = 21;
            Activity.Name = "Activity";
            Activity.OptionsColumn.AllowEdit = false;
            Activity.OptionsColumn.AllowFocus = false;
            Activity.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            Activity.Visible = true;
            Activity.VisibleIndex = 5;
            Activity.Width = 329;
            // 
            // Authentication
            // 
            Authentication.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            Authentication.AppearanceCell.Options.UseFont = true;
            Authentication.AppearanceCell.Options.UseTextOptions = true;
            Authentication.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Authentication.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(26, 42, 21);
            Authentication.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            Authentication.AppearanceHeader.Options.UseBackColor = true;
            Authentication.AppearanceHeader.Options.UseFont = true;
            Authentication.AppearanceHeader.Options.UseTextOptions = true;
            Authentication.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Authentication.Caption = "Authentication";
            Authentication.FieldName = "Authentication";
            Authentication.MinWidth = 21;
            Authentication.Name = "Authentication";
            Authentication.OptionsColumn.AllowEdit = false;
            Authentication.OptionsColumn.AllowFocus = false;
            Authentication.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            Authentication.Visible = true;
            Authentication.VisibleIndex = 4;
            Authentication.Width = 155;
            // 
            // EmployeeLogsUC
            // 
            Appearance.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gcEmployeeLogs);
            Controls.Add(sidePanel7);
            Controls.Add(sidePanel4);
            Controls.Add(sidePanel5);
            Controls.Add(sidePanel1);
            Name = "EmployeeLogsUC";
            Size = new System.Drawing.Size(1236, 603);
            sidePanel1.ResumeLayout(false);
            sidePanel1.PerformLayout();
            sidePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gcEmployeeLogs).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvEmployeeLogs).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.SidePanel sidePanel3;
        private DevExpress.XtraEditors.SidePanel sidePanel7;
        private DevExpress.XtraEditors.SidePanel sidePanel4;
        private DevExpress.XtraEditors.SidePanel sidePanel5;
        private DevExpress.XtraEditors.SimpleButton printBTN;
        private DevExpress.XtraGrid.GridControl gcEmployeeLogs;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmployeeLogs;
        private DevExpress.XtraGrid.Columns.GridColumn LogID;
        private DevExpress.XtraGrid.Columns.GridColumn Username;
        private DevExpress.XtraGrid.Columns.GridColumn DateTime;
        private DevExpress.XtraGrid.Columns.GridColumn Activity;
        private DevExpress.XtraGrid.Columns.GridColumn Authentication;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeName;
    }
}
