namespace MealPassCapstone.Desktop.Forms.Admin
{
    partial class PurchaseHistoryUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseHistoryUC));
            sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            findTE = new DevExpress.XtraEditors.TextEdit();
            sidePanel6 = new DevExpress.XtraEditors.SidePanel();
            dateDE = new DevExpress.XtraEditors.DateEdit();
            printBTN = new DevExpress.XtraEditors.SimpleButton();
            sidePanel5 = new DevExpress.XtraEditors.SidePanel();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            sidePanel4 = new DevExpress.XtraEditors.SidePanel();
            sidePanel7 = new DevExpress.XtraEditors.SidePanel();
            productpurchasesGC = new DevExpress.XtraGrid.GridControl();
            productpurchasesGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            Category = new DevExpress.XtraGrid.Columns.GridColumn();
            Price = new DevExpress.XtraGrid.Columns.GridColumn();
            Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            Total = new DevExpress.XtraGrid.Columns.GridColumn();
            sidePanel8 = new DevExpress.XtraEditors.SidePanel();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            sidePanel9 = new DevExpress.XtraEditors.SidePanel();
            sidePanel10 = new DevExpress.XtraEditors.SidePanel();
            purchasehistoryGC = new DevExpress.XtraGrid.GridControl();
            purchasehistoryGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            ReferenceID = new DevExpress.XtraGrid.Columns.GridColumn();
            EmployeeUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            StudentID = new DevExpress.XtraGrid.Columns.GridColumn();
            Date = new DevExpress.XtraGrid.Columns.GridColumn();
            GrandTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)findTE.Properties).BeginInit();
            sidePanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dateDE.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateDE.Properties.CalendarTimeProperties).BeginInit();
            sidePanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productpurchasesGC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productpurchasesGV).BeginInit();
            sidePanel8.SuspendLayout();
            sidePanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)purchasehistoryGC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)purchasehistoryGV).BeginInit();
            SuspendLayout();
            // 
            // sidePanel1
            // 
            sidePanel1.AllowResize = false;
            sidePanel1.BorderThickness = 0;
            sidePanel1.Controls.Add(findTE);
            sidePanel1.Controls.Add(sidePanel6);
            sidePanel1.Controls.Add(sidePanel5);
            sidePanel1.Controls.Add(labelControl1);
            sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            sidePanel1.Location = new System.Drawing.Point(0, 0);
            sidePanel1.Name = "sidePanel1";
            sidePanel1.Size = new System.Drawing.Size(1497, 73);
            sidePanel1.TabIndex = 0;
            sidePanel1.Text = "sidePanel1";
            // 
            // findTE
            // 
            findTE.Location = new System.Drawing.Point(296, 32);
            findTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            findTE.Name = "findTE";
            findTE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            findTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            findTE.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            findTE.Properties.Appearance.Options.UseBackColor = true;
            findTE.Properties.Appearance.Options.UseFont = true;
            findTE.Properties.Appearance.Options.UseForeColor = true;
            findTE.Properties.AutoHeight = false;
            findTE.Size = new System.Drawing.Size(206, 23);
            findTE.TabIndex = 30;
            // 
            // sidePanel6
            // 
            sidePanel6.AllowResize = false;
            sidePanel6.BorderThickness = 0;
            sidePanel6.Controls.Add(dateDE);
            sidePanel6.Controls.Add(printBTN);
            sidePanel6.Dock = System.Windows.Forms.DockStyle.Right;
            sidePanel6.Location = new System.Drawing.Point(1084, 23);
            sidePanel6.Name = "sidePanel6";
            sidePanel6.Size = new System.Drawing.Size(413, 50);
            sidePanel6.TabIndex = 4;
            sidePanel6.Text = "sidePanel6";
            // 
            // dateDE
            // 
            dateDE.EditValue = null;
            dateDE.Location = new System.Drawing.Point(34, 10);
            dateDE.Name = "dateDE";
            dateDE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            dateDE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dateDE.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dateDE.Properties.Appearance.Options.UseBackColor = true;
            dateDE.Properties.Appearance.Options.UseFont = true;
            dateDE.Properties.Appearance.Options.UseForeColor = true;
            dateDE.Properties.AutoHeight = false;
            dateDE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateDE.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateDE.Size = new System.Drawing.Size(206, 23);
            dateDE.TabIndex = 31;
            // 
            // printBTN
            // 
            printBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(89, 141, 57);
            printBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            printBTN.Appearance.Options.UseBackColor = true;
            printBTN.Appearance.Options.UseFont = true;
            printBTN.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("printBTN.ImageOptions.SvgImage");
            printBTN.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            printBTN.Location = new System.Drawing.Point(260, 7);
            printBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            printBTN.Name = "printBTN";
            printBTN.Padding = new System.Windows.Forms.Padding(2);
            printBTN.Size = new System.Drawing.Size(101, 28);
            printBTN.TabIndex = 26;
            printBTN.Text = "PRINT";
            // 
            // sidePanel5
            // 
            sidePanel5.AllowResize = false;
            sidePanel5.BorderThickness = 0;
            sidePanel5.Dock = System.Windows.Forms.DockStyle.Top;
            sidePanel5.Location = new System.Drawing.Point(0, 0);
            sidePanel5.Name = "sidePanel5";
            sidePanel5.Size = new System.Drawing.Size(1497, 23);
            sidePanel5.TabIndex = 3;
            sidePanel5.Text = "sidePanel5";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(27, 125, 79);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new System.Drawing.Point(48, 19);
            labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(231, 36);
            labelControl1.TabIndex = 2;
            labelControl1.Text = "Purchase History";
            // 
            // sidePanel2
            // 
            sidePanel2.AllowResize = false;
            sidePanel2.BorderThickness = 0;
            sidePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            sidePanel2.Location = new System.Drawing.Point(0, 73);
            sidePanel2.Name = "sidePanel2";
            sidePanel2.Size = new System.Drawing.Size(50, 687);
            sidePanel2.TabIndex = 1;
            sidePanel2.Text = "sidePanel2";
            // 
            // sidePanel3
            // 
            sidePanel3.AllowResize = false;
            sidePanel3.BorderThickness = 0;
            sidePanel3.Dock = System.Windows.Forms.DockStyle.Right;
            sidePanel3.Location = new System.Drawing.Point(1448, 73);
            sidePanel3.Name = "sidePanel3";
            sidePanel3.Size = new System.Drawing.Size(49, 687);
            sidePanel3.TabIndex = 2;
            sidePanel3.Text = "sidePanel3";
            // 
            // sidePanel4
            // 
            sidePanel4.AllowResize = false;
            sidePanel4.BorderThickness = 0;
            sidePanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            sidePanel4.Location = new System.Drawing.Point(50, 716);
            sidePanel4.Name = "sidePanel4";
            sidePanel4.Size = new System.Drawing.Size(1398, 44);
            sidePanel4.TabIndex = 3;
            sidePanel4.Text = "sidePanel4";
            // 
            // sidePanel7
            // 
            sidePanel7.AllowResize = false;
            sidePanel7.BorderThickness = 0;
            sidePanel7.Controls.Add(productpurchasesGC);
            sidePanel7.Controls.Add(sidePanel8);
            sidePanel7.Dock = System.Windows.Forms.DockStyle.Right;
            sidePanel7.Location = new System.Drawing.Point(808, 73);
            sidePanel7.Name = "sidePanel7";
            sidePanel7.Size = new System.Drawing.Size(640, 643);
            sidePanel7.TabIndex = 4;
            sidePanel7.Text = "sidePanel7";
            // 
            // productpurchasesGC
            // 
            productpurchasesGC.Dock = System.Windows.Forms.DockStyle.Fill;
            productpurchasesGC.Location = new System.Drawing.Point(0, 0);
            productpurchasesGC.MainView = productpurchasesGV;
            productpurchasesGC.Name = "productpurchasesGC";
            productpurchasesGC.Size = new System.Drawing.Size(640, 597);
            productpurchasesGC.TabIndex = 1;
            productpurchasesGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { productpurchasesGV });
            // 
            // productpurchasesGV
            // 
            productpurchasesGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { ProductName, Category, Price, Quantity, Total });
            productpurchasesGV.GridControl = productpurchasesGC;
            productpurchasesGV.Name = "productpurchasesGV";
            productpurchasesGV.OptionsView.ShowGroupPanel = false;
            // 
            // ProductName
            // 
            ProductName.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ProductName.AppearanceCell.Options.UseFont = true;
            ProductName.AppearanceCell.Options.UseTextOptions = true;
            ProductName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            ProductName.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(26, 42, 21);
            ProductName.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ProductName.AppearanceHeader.Options.UseBackColor = true;
            ProductName.AppearanceHeader.Options.UseFont = true;
            ProductName.AppearanceHeader.Options.UseTextOptions = true;
            ProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            ProductName.Caption = "Product";
            ProductName.FieldName = "ProductName";
            ProductName.Name = "ProductName";
            ProductName.Visible = true;
            ProductName.VisibleIndex = 0;
            // 
            // Category
            // 
            Category.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Category.AppearanceCell.Options.UseFont = true;
            Category.AppearanceCell.Options.UseTextOptions = true;
            Category.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Category.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(26, 42, 21);
            Category.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Category.AppearanceHeader.Options.UseBackColor = true;
            Category.AppearanceHeader.Options.UseFont = true;
            Category.AppearanceHeader.Options.UseTextOptions = true;
            Category.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Category.Caption = "Category";
            Category.FieldName = "CategoryName";
            Category.Name = "Category";
            Category.Visible = true;
            Category.VisibleIndex = 1;
            // 
            // Price
            // 
            Price.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Price.AppearanceCell.Options.UseFont = true;
            Price.AppearanceCell.Options.UseTextOptions = true;
            Price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            Price.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(26, 42, 21);
            Price.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Price.AppearanceHeader.Options.UseBackColor = true;
            Price.AppearanceHeader.Options.UseFont = true;
            Price.AppearanceHeader.Options.UseTextOptions = true;
            Price.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Price.Caption = "Price";
            Price.FieldName = "Price";
            Price.Name = "Price";
            Price.Visible = true;
            Price.VisibleIndex = 2;
            // 
            // Quantity
            // 
            Quantity.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Quantity.AppearanceCell.Options.UseFont = true;
            Quantity.AppearanceCell.Options.UseTextOptions = true;
            Quantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Quantity.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(26, 42, 21);
            Quantity.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Quantity.AppearanceHeader.Options.UseBackColor = true;
            Quantity.AppearanceHeader.Options.UseFont = true;
            Quantity.AppearanceHeader.Options.UseTextOptions = true;
            Quantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Quantity.Caption = "Quantity";
            Quantity.FieldName = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.Visible = true;
            Quantity.VisibleIndex = 3;
            // 
            // Total
            // 
            Total.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Total.AppearanceCell.Options.UseFont = true;
            Total.AppearanceCell.Options.UseTextOptions = true;
            Total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            Total.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(26, 42, 21);
            Total.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Total.AppearanceHeader.Options.UseBackColor = true;
            Total.AppearanceHeader.Options.UseFont = true;
            Total.AppearanceHeader.Options.UseTextOptions = true;
            Total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Total.Caption = "Total";
            Total.FieldName = "Total";
            Total.Name = "Total";
            Total.Visible = true;
            Total.VisibleIndex = 4;
            // 
            // sidePanel8
            // 
            sidePanel8.Appearance.BackColor = System.Drawing.Color.SeaGreen;
            sidePanel8.Appearance.Options.UseBackColor = true;
            sidePanel8.Controls.Add(labelControl3);
            sidePanel8.Controls.Add(labelControl2);
            sidePanel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            sidePanel8.Location = new System.Drawing.Point(0, 597);
            sidePanel8.Name = "sidePanel8";
            sidePanel8.Size = new System.Drawing.Size(640, 46);
            sidePanel8.TabIndex = 0;
            sidePanel8.Text = "sidePanel8";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl3.Appearance.ForeColor = System.Drawing.Color.GreenYellow;
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.Location = new System.Drawing.Point(450, 10);
            labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(54, 25);
            labelControl3.TabIndex = 4;
            labelControl3.Text = "00.00";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl2.Appearance.ForeColor = System.Drawing.Color.Honeydew;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new System.Drawing.Point(291, 9);
            labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(125, 25);
            labelControl2.TabIndex = 3;
            labelControl2.Text = "Grand Total:";
            // 
            // sidePanel9
            // 
            sidePanel9.AllowResize = false;
            sidePanel9.BorderThickness = 0;
            sidePanel9.Dock = System.Windows.Forms.DockStyle.Right;
            sidePanel9.Location = new System.Drawing.Point(764, 73);
            sidePanel9.Name = "sidePanel9";
            sidePanel9.Size = new System.Drawing.Size(44, 643);
            sidePanel9.TabIndex = 5;
            sidePanel9.Text = "sidePanel9";
            // 
            // sidePanel10
            // 
            sidePanel10.BorderThickness = 0;
            sidePanel10.Controls.Add(purchasehistoryGC);
            sidePanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            sidePanel10.Location = new System.Drawing.Point(50, 73);
            sidePanel10.Name = "sidePanel10";
            sidePanel10.Size = new System.Drawing.Size(714, 643);
            sidePanel10.TabIndex = 6;
            sidePanel10.Text = "sidePanel10";
            // 
            // purchasehistoryGC
            // 
            purchasehistoryGC.Dock = System.Windows.Forms.DockStyle.Fill;
            purchasehistoryGC.Location = new System.Drawing.Point(0, 0);
            purchasehistoryGC.MainView = purchasehistoryGV;
            purchasehistoryGC.Name = "purchasehistoryGC";
            purchasehistoryGC.Size = new System.Drawing.Size(714, 643);
            purchasehistoryGC.TabIndex = 0;
            purchasehistoryGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { purchasehistoryGV });
            // 
            // purchasehistoryGV
            // 
            purchasehistoryGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { ReferenceID, EmployeeUsername, StudentID, Date, GrandTotal });
            purchasehistoryGV.GridControl = purchasehistoryGC;
            purchasehistoryGV.Name = "purchasehistoryGV";
            purchasehistoryGV.OptionsView.ShowGroupPanel = false;
            // 
            // ReferenceID
            // 
            ReferenceID.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ReferenceID.AppearanceCell.Options.UseFont = true;
            ReferenceID.AppearanceCell.Options.UseTextOptions = true;
            ReferenceID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            ReferenceID.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(26, 42, 21);
            ReferenceID.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ReferenceID.AppearanceHeader.Options.UseBackColor = true;
            ReferenceID.AppearanceHeader.Options.UseFont = true;
            ReferenceID.AppearanceHeader.Options.UseTextOptions = true;
            ReferenceID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            ReferenceID.Caption = "Reference No.";
            ReferenceID.FieldName = "ReferenceID";
            ReferenceID.Name = "ReferenceID";
            ReferenceID.Visible = true;
            ReferenceID.VisibleIndex = 0;
            // 
            // EmployeeUsername
            // 
            EmployeeUsername.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            EmployeeUsername.AppearanceCell.Options.UseFont = true;
            EmployeeUsername.AppearanceCell.Options.UseTextOptions = true;
            EmployeeUsername.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            EmployeeUsername.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(26, 42, 21);
            EmployeeUsername.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            EmployeeUsername.AppearanceHeader.Options.UseBackColor = true;
            EmployeeUsername.AppearanceHeader.Options.UseFont = true;
            EmployeeUsername.AppearanceHeader.Options.UseTextOptions = true;
            EmployeeUsername.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            EmployeeUsername.Caption = "Employee";
            EmployeeUsername.FieldName = "Username";
            EmployeeUsername.Name = "EmployeeUsername";
            EmployeeUsername.Visible = true;
            EmployeeUsername.VisibleIndex = 1;
            // 
            // StudentID
            // 
            StudentID.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            StudentID.AppearanceCell.Options.UseFont = true;
            StudentID.AppearanceCell.Options.UseTextOptions = true;
            StudentID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            StudentID.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(26, 42, 21);
            StudentID.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            StudentID.AppearanceHeader.Options.UseBackColor = true;
            StudentID.AppearanceHeader.Options.UseFont = true;
            StudentID.AppearanceHeader.Options.UseTextOptions = true;
            StudentID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            StudentID.Caption = "StudentID";
            StudentID.FieldName = "StudentID";
            StudentID.Name = "StudentID";
            StudentID.Visible = true;
            StudentID.VisibleIndex = 2;
            // 
            // Date
            // 
            Date.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Date.AppearanceCell.Options.UseFont = true;
            Date.AppearanceCell.Options.UseTextOptions = true;
            Date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Date.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(26, 42, 21);
            Date.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Date.AppearanceHeader.Options.UseBackColor = true;
            Date.AppearanceHeader.Options.UseFont = true;
            Date.AppearanceHeader.Options.UseTextOptions = true;
            Date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Date.Caption = "Date";
            Date.FieldName = "Date";
            Date.Name = "Date";
            Date.Visible = true;
            Date.VisibleIndex = 3;
            // 
            // GrandTotal
            // 
            GrandTotal.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            GrandTotal.AppearanceCell.Options.UseFont = true;
            GrandTotal.AppearanceCell.Options.UseTextOptions = true;
            GrandTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            GrandTotal.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(26, 42, 21);
            GrandTotal.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            GrandTotal.AppearanceHeader.Options.UseBackColor = true;
            GrandTotal.AppearanceHeader.Options.UseFont = true;
            GrandTotal.AppearanceHeader.Options.UseTextOptions = true;
            GrandTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            GrandTotal.Caption = "Total";
            GrandTotal.FieldName = "GrandTotal";
            GrandTotal.Name = "GrandTotal";
            GrandTotal.Visible = true;
            GrandTotal.VisibleIndex = 4;
            // 
            // PurchaseHistoryUC
            // 
            Appearance.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(sidePanel10);
            Controls.Add(sidePanel9);
            Controls.Add(sidePanel7);
            Controls.Add(sidePanel4);
            Controls.Add(sidePanel3);
            Controls.Add(sidePanel2);
            Controls.Add(sidePanel1);
            Name = "PurchaseHistoryUC";
            Size = new System.Drawing.Size(1497, 760);
            sidePanel1.ResumeLayout(false);
            sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)findTE.Properties).EndInit();
            sidePanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dateDE.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateDE.Properties).EndInit();
            sidePanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productpurchasesGC).EndInit();
            ((System.ComponentModel.ISupportInitialize)productpurchasesGV).EndInit();
            sidePanel8.ResumeLayout(false);
            sidePanel8.PerformLayout();
            sidePanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)purchasehistoryGC).EndInit();
            ((System.ComponentModel.ISupportInitialize)purchasehistoryGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.SidePanel sidePanel3;
        private DevExpress.XtraEditors.SidePanel sidePanel4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SidePanel sidePanel5;
        private DevExpress.XtraEditors.SidePanel sidePanel6;
        private DevExpress.XtraEditors.SimpleButton printBTN;
        private DevExpress.XtraEditors.DateEdit dateDE;
        private DevExpress.XtraEditors.SidePanel sidePanel7;
        private DevExpress.XtraEditors.SidePanel sidePanel8;
        private DevExpress.XtraEditors.SidePanel sidePanel9;
        private DevExpress.XtraEditors.SidePanel sidePanel10;
        private DevExpress.XtraGrid.GridControl purchasehistoryGC;
        private DevExpress.XtraGrid.Views.Grid.GridView purchasehistoryGV;
        private DevExpress.XtraEditors.TextEdit findTE;
        private DevExpress.XtraGrid.GridControl productpurchasesGC;
        private DevExpress.XtraGrid.Views.Grid.GridView productpurchasesGV;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn ReferenceID;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeUsername;
        private DevExpress.XtraGrid.Columns.GridColumn StudentID;
        private DevExpress.XtraGrid.Columns.GridColumn Date;
        private DevExpress.XtraGrid.Columns.GridColumn GrandTotal;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn Category;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
    }
}
