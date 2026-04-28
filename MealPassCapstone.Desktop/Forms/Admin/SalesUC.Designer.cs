namespace MealPassCapstone.Desktop.Forms.Admin
{
    partial class SalesUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesUC));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            repositoryItemButtonDelete2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ItemsSold = new DevExpress.XtraGrid.Columns.GridColumn();
            Price = new DevExpress.XtraGrid.Columns.GridColumn();
            CategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            SaleID = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            gvSales = new DevExpress.XtraGrid.Views.Grid.GridView();
            gcSales = new DevExpress.XtraGrid.GridControl();
            sidePanel8 = new DevExpress.XtraEditors.SidePanel();
            sidePanel7 = new DevExpress.XtraEditors.SidePanel();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            addemployeeBTN = new DevExpress.XtraEditors.SimpleButton();
            findTE = new DevExpress.XtraEditors.TextEdit();
            sidePanel9 = new DevExpress.XtraEditors.SidePanel();
            sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            sidePanel5 = new DevExpress.XtraEditors.SidePanel();
            sidePanel10 = new DevExpress.XtraEditors.SidePanel();
            dateDE = new DevExpress.XtraEditors.DateEdit();
            sidePanel6 = new DevExpress.XtraEditors.SidePanel();
            sidePanel4 = new DevExpress.XtraEditors.SidePanel();
            sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            TotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonDelete2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemPictureEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)findTE.Properties).BeginInit();
            sidePanel9.SuspendLayout();
            sidePanel5.SuspendLayout();
            sidePanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dateDE.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateDE.Properties.CalendarTimeProperties).BeginInit();
            SuspendLayout();
            // 
            // repositoryItemButtonDelete2
            // 
            repositoryItemButtonDelete2.Appearance.Options.UseTextOptions = true;
            repositoryItemButtonDelete2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            repositoryItemButtonDelete2.AutoHeight = false;
            repositoryItemButtonDelete2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph) });
            repositoryItemButtonDelete2.ContextImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("repositoryItemButtonDelete2.ContextImageOptions.SvgImage");
            repositoryItemButtonDelete2.Name = "repositoryItemButtonDelete2";
            // 
            // repositoryItemButtonEdit1
            // 
            repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions2.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("editorButtonImageOptions2.SvgImage");
            repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            repositoryItemButtonEdit1.ContextImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("repositoryItemButtonEdit1.ContextImageOptions.SvgImage");
            repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // ItemsSold
            // 
            ItemsSold.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke;
            ItemsSold.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            ItemsSold.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            ItemsSold.AppearanceCell.Options.UseBackColor = true;
            ItemsSold.AppearanceCell.Options.UseFont = true;
            ItemsSold.AppearanceCell.Options.UseForeColor = true;
            ItemsSold.AppearanceCell.Options.UseTextOptions = true;
            ItemsSold.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            ItemsSold.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(26, 42, 21);
            ItemsSold.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            ItemsSold.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            ItemsSold.AppearanceHeader.Options.UseBackColor = true;
            ItemsSold.AppearanceHeader.Options.UseFont = true;
            ItemsSold.AppearanceHeader.Options.UseForeColor = true;
            ItemsSold.AppearanceHeader.Options.UseTextOptions = true;
            ItemsSold.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            ItemsSold.Caption = "Items Sold";
            ItemsSold.FieldName = "ItemsSold";
            ItemsSold.MinWidth = 21;
            ItemsSold.Name = "ItemsSold";
            ItemsSold.OptionsColumn.AllowEdit = false;
            ItemsSold.OptionsColumn.AllowFocus = false;
            ItemsSold.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            ItemsSold.Visible = true;
            ItemsSold.VisibleIndex = 4;
            ItemsSold.Width = 314;
            // 
            // Price
            // 
            Price.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke;
            Price.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            Price.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            Price.AppearanceCell.Options.UseBackColor = true;
            Price.AppearanceCell.Options.UseFont = true;
            Price.AppearanceCell.Options.UseForeColor = true;
            Price.AppearanceCell.Options.UseTextOptions = true;
            Price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Price.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(26, 42, 21);
            Price.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            Price.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            Price.AppearanceHeader.Options.UseBackColor = true;
            Price.AppearanceHeader.Options.UseFont = true;
            Price.AppearanceHeader.Options.UseForeColor = true;
            Price.AppearanceHeader.Options.UseTextOptions = true;
            Price.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Price.Caption = "Price";
            Price.FieldName = "Price";
            Price.MinWidth = 21;
            Price.Name = "Price";
            Price.OptionsColumn.AllowEdit = false;
            Price.OptionsColumn.AllowFocus = false;
            Price.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            Price.Visible = true;
            Price.VisibleIndex = 3;
            Price.Width = 199;
            // 
            // CategoryName
            // 
            CategoryName.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke;
            CategoryName.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            CategoryName.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            CategoryName.AppearanceCell.Options.UseBackColor = true;
            CategoryName.AppearanceCell.Options.UseFont = true;
            CategoryName.AppearanceCell.Options.UseForeColor = true;
            CategoryName.AppearanceCell.Options.UseTextOptions = true;
            CategoryName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            CategoryName.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(26, 42, 21);
            CategoryName.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            CategoryName.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            CategoryName.AppearanceHeader.Options.UseBackColor = true;
            CategoryName.AppearanceHeader.Options.UseFont = true;
            CategoryName.AppearanceHeader.Options.UseForeColor = true;
            CategoryName.AppearanceHeader.Options.UseTextOptions = true;
            CategoryName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            CategoryName.Caption = "Category";
            CategoryName.FieldName = "CategoryName";
            CategoryName.MinWidth = 21;
            CategoryName.Name = "CategoryName";
            CategoryName.OptionsColumn.AllowEdit = false;
            CategoryName.OptionsColumn.AllowFocus = false;
            CategoryName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            CategoryName.Visible = true;
            CategoryName.VisibleIndex = 2;
            CategoryName.Width = 215;
            // 
            // ProductName
            // 
            ProductName.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke;
            ProductName.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            ProductName.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            ProductName.AppearanceCell.Options.UseBackColor = true;
            ProductName.AppearanceCell.Options.UseFont = true;
            ProductName.AppearanceCell.Options.UseForeColor = true;
            ProductName.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(26, 42, 21);
            ProductName.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            ProductName.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            ProductName.AppearanceHeader.Options.UseBackColor = true;
            ProductName.AppearanceHeader.Options.UseFont = true;
            ProductName.AppearanceHeader.Options.UseForeColor = true;
            ProductName.AppearanceHeader.Options.UseTextOptions = true;
            ProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            ProductName.Caption = "ProductName";
            ProductName.FieldName = "ProductName";
            ProductName.MinWidth = 21;
            ProductName.Name = "ProductName";
            ProductName.OptionsColumn.AllowEdit = false;
            ProductName.OptionsColumn.AllowFocus = false;
            ProductName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            ProductName.Visible = true;
            ProductName.VisibleIndex = 1;
            ProductName.Width = 475;
            // 
            // SaleID
            // 
            SaleID.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke;
            SaleID.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            SaleID.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            SaleID.AppearanceCell.Options.UseBackColor = true;
            SaleID.AppearanceCell.Options.UseFont = true;
            SaleID.AppearanceCell.Options.UseForeColor = true;
            SaleID.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(26, 42, 21);
            SaleID.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            SaleID.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            SaleID.AppearanceHeader.Options.UseBackColor = true;
            SaleID.AppearanceHeader.Options.UseFont = true;
            SaleID.AppearanceHeader.Options.UseForeColor = true;
            SaleID.AppearanceHeader.Options.UseTextOptions = true;
            SaleID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            SaleID.Caption = "#";
            SaleID.FieldName = "SaleID";
            SaleID.MinWidth = 21;
            SaleID.Name = "SaleID";
            SaleID.OptionsColumn.AllowEdit = false;
            SaleID.OptionsColumn.AllowFocus = false;
            SaleID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            SaleID.Visible = true;
            SaleID.VisibleIndex = 0;
            SaleID.Width = 66;
            // 
            // repositoryItemPictureEdit1
            // 
            repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // gvSales
            // 
            gvSales.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { SaleID, ProductName, CategoryName, Price, ItemsSold, TotalAmount });
            gvSales.DetailHeight = 284;
            gvSales.GridControl = gcSales;
            gvSales.Name = "gvSales";
            gvSales.OptionsBehavior.AutoExpandAllGroups = true;
            gvSales.OptionsEditForm.PopupEditFormWidth = 686;
            gvSales.OptionsView.RowAutoHeight = true;
            gvSales.OptionsView.ShowGroupPanel = false;
            // 
            // gcSales
            // 
            gcSales.Dock = System.Windows.Forms.DockStyle.Fill;
            gcSales.EmbeddedNavigator.Buttons.Append.Visible = false;
            gcSales.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            gcSales.EmbeddedNavigator.Buttons.Edit.Visible = false;
            gcSales.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            gcSales.EmbeddedNavigator.Buttons.Remove.Visible = false;
            gcSales.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gcSales.Location = new System.Drawing.Point(25, 85);
            gcSales.MainView = gvSales;
            gcSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gcSales.Name = "gcSales";
            gcSales.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemPictureEdit1, repositoryItemButtonEdit1, repositoryItemButtonDelete2 });
            gcSales.Size = new System.Drawing.Size(1027, 472);
            gcSales.TabIndex = 38;
            gcSales.UseEmbeddedNavigator = true;
            gcSales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvSales });
            // 
            // sidePanel8
            // 
            sidePanel8.AllowResize = false;
            sidePanel8.Appearance.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            sidePanel8.Appearance.Options.UseBackColor = true;
            sidePanel8.BorderThickness = 0;
            sidePanel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            sidePanel8.Location = new System.Drawing.Point(0, 67);
            sidePanel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            sidePanel8.Name = "sidePanel8";
            sidePanel8.Size = new System.Drawing.Size(1018, 6);
            sidePanel8.TabIndex = 27;
            sidePanel8.Text = "sidePanel8";
            // 
            // sidePanel7
            // 
            sidePanel7.AllowResize = false;
            sidePanel7.Appearance.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            sidePanel7.Appearance.Options.UseBackColor = true;
            sidePanel7.BorderThickness = 0;
            sidePanel7.Dock = System.Windows.Forms.DockStyle.Right;
            sidePanel7.Location = new System.Drawing.Point(1018, 12);
            sidePanel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            sidePanel7.Name = "sidePanel7";
            sidePanel7.Size = new System.Drawing.Size(9, 61);
            sidePanel7.TabIndex = 26;
            sidePanel7.Text = "sidePanel7";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(27, 125, 79);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new System.Drawing.Point(9, 17);
            labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(75, 37);
            labelControl2.TabIndex = 9;
            labelControl2.Text = "Sales";
            // 
            // addemployeeBTN
            // 
            addemployeeBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(89, 141, 57);
            addemployeeBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            addemployeeBTN.Appearance.Options.UseBackColor = true;
            addemployeeBTN.Appearance.Options.UseFont = true;
            addemployeeBTN.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("addemployeeBTN.ImageOptions.Image");
            addemployeeBTN.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            addemployeeBTN.Location = new System.Drawing.Point(8, 11);
            addemployeeBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            addemployeeBTN.Name = "addemployeeBTN";
            addemployeeBTN.Padding = new System.Windows.Forms.Padding(2);
            addemployeeBTN.Size = new System.Drawing.Size(93, 35);
            addemployeeBTN.TabIndex = 24;
            addemployeeBTN.Text = "Print";
            // 
            // findTE
            // 
            findTE.Location = new System.Drawing.Point(104, 29);
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
            findTE.TabIndex = 29;
            // 
            // sidePanel9
            // 
            sidePanel9.AllowResize = false;
            sidePanel9.Appearance.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            sidePanel9.Appearance.Options.UseBackColor = true;
            sidePanel9.BorderThickness = 0;
            sidePanel9.Controls.Add(addemployeeBTN);
            sidePanel9.Dock = System.Windows.Forms.DockStyle.Right;
            sidePanel9.Location = new System.Drawing.Point(910, 12);
            sidePanel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            sidePanel9.Name = "sidePanel9";
            sidePanel9.Size = new System.Drawing.Size(108, 55);
            sidePanel9.TabIndex = 28;
            sidePanel9.Text = "sidePanel9";
            // 
            // sidePanel1
            // 
            sidePanel1.AllowResize = false;
            sidePanel1.Appearance.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            sidePanel1.Appearance.Options.UseBackColor = true;
            sidePanel1.BorderThickness = 0;
            sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            sidePanel1.Location = new System.Drawing.Point(0, 0);
            sidePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            sidePanel1.Name = "sidePanel1";
            sidePanel1.Size = new System.Drawing.Size(1027, 12);
            sidePanel1.TabIndex = 25;
            sidePanel1.Text = "sidePanel1";
            // 
            // sidePanel5
            // 
            sidePanel5.AllowResize = false;
            sidePanel5.Appearance.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            sidePanel5.Appearance.Options.UseBackColor = true;
            sidePanel5.BorderThickness = 0;
            sidePanel5.Controls.Add(sidePanel10);
            sidePanel5.Controls.Add(findTE);
            sidePanel5.Controls.Add(sidePanel9);
            sidePanel5.Controls.Add(sidePanel8);
            sidePanel5.Controls.Add(sidePanel7);
            sidePanel5.Controls.Add(sidePanel1);
            sidePanel5.Controls.Add(labelControl2);
            sidePanel5.Dock = System.Windows.Forms.DockStyle.Top;
            sidePanel5.Location = new System.Drawing.Point(25, 12);
            sidePanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            sidePanel5.Name = "sidePanel5";
            sidePanel5.Size = new System.Drawing.Size(1027, 73);
            sidePanel5.TabIndex = 37;
            sidePanel5.Text = "sidePanel5";
            // 
            // sidePanel10
            // 
            sidePanel10.AllowResize = false;
            sidePanel10.BorderThickness = 0;
            sidePanel10.Controls.Add(dateDE);
            sidePanel10.Dock = System.Windows.Forms.DockStyle.Right;
            sidePanel10.Location = new System.Drawing.Point(616, 12);
            sidePanel10.Name = "sidePanel10";
            sidePanel10.Size = new System.Drawing.Size(294, 55);
            sidePanel10.TabIndex = 31;
            sidePanel10.Text = "sidePanel10";
            // 
            // dateDE
            // 
            dateDE.EditValue = null;
            dateDE.Location = new System.Drawing.Point(82, 17);
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
            dateDE.TabIndex = 30;
            // 
            // sidePanel6
            // 
            sidePanel6.AllowResize = false;
            sidePanel6.Appearance.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            sidePanel6.Appearance.Options.UseBackColor = true;
            sidePanel6.BorderThickness = 0;
            sidePanel6.Dock = System.Windows.Forms.DockStyle.Top;
            sidePanel6.Location = new System.Drawing.Point(25, 0);
            sidePanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            sidePanel6.Name = "sidePanel6";
            sidePanel6.Size = new System.Drawing.Size(1027, 12);
            sidePanel6.TabIndex = 36;
            sidePanel6.Text = "sidePanel6";
            // 
            // sidePanel4
            // 
            sidePanel4.AllowResize = false;
            sidePanel4.Appearance.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            sidePanel4.Appearance.Options.UseBackColor = true;
            sidePanel4.BorderThickness = 0;
            sidePanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            sidePanel4.Location = new System.Drawing.Point(25, 557);
            sidePanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            sidePanel4.Name = "sidePanel4";
            sidePanel4.Size = new System.Drawing.Size(1027, 33);
            sidePanel4.TabIndex = 35;
            sidePanel4.Text = "sidePanel4";
            // 
            // sidePanel3
            // 
            sidePanel3.AllowResize = false;
            sidePanel3.Appearance.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            sidePanel3.Appearance.Options.UseBackColor = true;
            sidePanel3.BorderThickness = 0;
            sidePanel3.Dock = System.Windows.Forms.DockStyle.Right;
            sidePanel3.Location = new System.Drawing.Point(1052, 0);
            sidePanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            sidePanel3.Name = "sidePanel3";
            sidePanel3.Size = new System.Drawing.Size(24, 590);
            sidePanel3.TabIndex = 34;
            sidePanel3.Text = "sidePanel3";
            // 
            // sidePanel2
            // 
            sidePanel2.AllowResize = false;
            sidePanel2.Appearance.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            sidePanel2.Appearance.Options.UseBackColor = true;
            sidePanel2.BorderThickness = 0;
            sidePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            sidePanel2.Location = new System.Drawing.Point(0, 0);
            sidePanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            sidePanel2.Name = "sidePanel2";
            sidePanel2.Size = new System.Drawing.Size(25, 590);
            sidePanel2.TabIndex = 33;
            sidePanel2.Text = "sidePanel2";
            // 
            // TotalAmount
            // 
            TotalAmount.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            TotalAmount.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            TotalAmount.AppearanceCell.Options.UseFont = true;
            TotalAmount.AppearanceCell.Options.UseForeColor = true;
            TotalAmount.AppearanceCell.Options.UseTextOptions = true;
            TotalAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            TotalAmount.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(26, 42, 21);
            TotalAmount.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            TotalAmount.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            TotalAmount.AppearanceHeader.Options.UseBackColor = true;
            TotalAmount.AppearanceHeader.Options.UseFont = true;
            TotalAmount.AppearanceHeader.Options.UseForeColor = true;
            TotalAmount.AppearanceHeader.Options.UseTextOptions = true;
            TotalAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            TotalAmount.Caption = "Total Amount";
            TotalAmount.FieldName = "TotalAmount";
            TotalAmount.Name = "TotalAmount";
            TotalAmount.Visible = true;
            TotalAmount.VisibleIndex = 5;
            TotalAmount.Width = 290;
            // 
            // SalesUC
            // 
            Appearance.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gcSales);
            Controls.Add(sidePanel5);
            Controls.Add(sidePanel6);
            Controls.Add(sidePanel4);
            Controls.Add(sidePanel3);
            Controls.Add(sidePanel2);
            Name = "SalesUC";
            Size = new System.Drawing.Size(1076, 590);
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonDelete2).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemPictureEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)findTE.Properties).EndInit();
            sidePanel9.ResumeLayout(false);
            sidePanel5.ResumeLayout(false);
            sidePanel5.PerformLayout();
            sidePanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dateDE.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateDE.Properties).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonDelete2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn ItemsSold;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn CategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn SaleID;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSales;
        private DevExpress.XtraGrid.GridControl gcSales;
        private DevExpress.XtraEditors.SidePanel sidePanel8;
        private DevExpress.XtraEditors.SidePanel sidePanel7;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton addemployeeBTN;
        private DevExpress.XtraEditors.TextEdit findTE;
        private DevExpress.XtraEditors.SidePanel sidePanel9;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SidePanel sidePanel5;
        private DevExpress.XtraEditors.SidePanel sidePanel6;
        private DevExpress.XtraEditors.SidePanel sidePanel4;
        private DevExpress.XtraEditors.SidePanel sidePanel3;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.DateEdit dateDE;
        private DevExpress.XtraEditors.SidePanel sidePanel10;
        private DevExpress.XtraGrid.Columns.GridColumn TotalAmount;
    }
}
