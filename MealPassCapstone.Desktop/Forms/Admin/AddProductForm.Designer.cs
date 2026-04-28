namespace MealPassCapstone.Desktop.Forms.Admin
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            productnameTE = new DevExpress.XtraEditors.TextEdit();
            categoryCBE = new DevExpress.XtraEditors.ComboBoxEdit();
            priceTE = new DevExpress.XtraEditors.TextEdit();
            addproductBTN = new DevExpress.XtraEditors.SimpleButton();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            quantityTE = new DevExpress.XtraEditors.TextEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            lowstocklevelTE = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productnameTE.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryCBE.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceTE.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantityTE.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lowstocklevelTE.Properties).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem });
            ribbon.Location = new System.Drawing.Point(0, 0);
            ribbon.Margin = new System.Windows.Forms.Padding(4);
            ribbon.MaxItemId = 1;
            ribbon.Name = "ribbon";
            ribbon.OptionsMenuMinWidth = 385;
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.Size = new System.Drawing.Size(516, 49);
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // productnameTE
            // 
            productnameTE.Location = new System.Drawing.Point(75, 80);
            productnameTE.Margin = new System.Windows.Forms.Padding(4);
            productnameTE.MenuManager = ribbon;
            productnameTE.Name = "productnameTE";
            productnameTE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(93, 93, 93);
            productnameTE.Properties.Appearance.BorderColor = System.Drawing.Color.White;
            productnameTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            productnameTE.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            productnameTE.Properties.Appearance.Options.UseBackColor = true;
            productnameTE.Properties.Appearance.Options.UseBorderColor = true;
            productnameTE.Properties.Appearance.Options.UseFont = true;
            productnameTE.Properties.Appearance.Options.UseForeColor = true;
            productnameTE.Properties.AutoHeight = false;
            productnameTE.Size = new System.Drawing.Size(362, 40);
            productnameTE.TabIndex = 2;
            // 
            // categoryCBE
            // 
            categoryCBE.Location = new System.Drawing.Point(75, 158);
            categoryCBE.Margin = new System.Windows.Forms.Padding(4);
            categoryCBE.MenuManager = ribbon;
            categoryCBE.Name = "categoryCBE";
            categoryCBE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(93, 93, 93);
            categoryCBE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            categoryCBE.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            categoryCBE.Properties.Appearance.Options.UseBackColor = true;
            categoryCBE.Properties.Appearance.Options.UseFont = true;
            categoryCBE.Properties.Appearance.Options.UseForeColor = true;
            categoryCBE.Properties.AutoHeight = false;
            categoryCBE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            categoryCBE.Properties.Items.AddRange(new object[] { "Snacks", "Drinks", "Meals" });
            categoryCBE.Size = new System.Drawing.Size(362, 40);
            categoryCBE.TabIndex = 3;
            // 
            // priceTE
            // 
            priceTE.Location = new System.Drawing.Point(75, 237);
            priceTE.Margin = new System.Windows.Forms.Padding(4);
            priceTE.MenuManager = ribbon;
            priceTE.Name = "priceTE";
            priceTE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(93, 93, 93);
            priceTE.Properties.Appearance.BorderColor = System.Drawing.Color.White;
            priceTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            priceTE.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            priceTE.Properties.Appearance.Options.UseBackColor = true;
            priceTE.Properties.Appearance.Options.UseBorderColor = true;
            priceTE.Properties.Appearance.Options.UseFont = true;
            priceTE.Properties.Appearance.Options.UseForeColor = true;
            priceTE.Properties.AutoHeight = false;
            priceTE.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            priceTE.Properties.MaskSettings.Set("mask", "n");
            priceTE.Size = new System.Drawing.Size(362, 40);
            priceTE.TabIndex = 4;
            // 
            // addproductBTN
            // 
            addproductBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(0, 191, 99);
            addproductBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            addproductBTN.Appearance.Options.UseBackColor = true;
            addproductBTN.Appearance.Options.UseFont = true;
            addproductBTN.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("addproductBTN.ImageOptions.Image");
            addproductBTN.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            addproductBTN.Location = new System.Drawing.Point(167, 490);
            addproductBTN.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            addproductBTN.Name = "addproductBTN";
            addproductBTN.Padding = new System.Windows.Forms.Padding(2);
            addproductBTN.Size = new System.Drawing.Size(182, 47);
            addproductBTN.TabIndex = 25;
            addproductBTN.Text = "Add Product";
            addproductBTN.Click += addproductBTN_Click;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl1.Appearance.ForeColor = System.Drawing.Color.LightGray;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new System.Drawing.Point(75, 124);
            labelControl1.Margin = new System.Windows.Forms.Padding(4);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(92, 16);
            labelControl1.TabIndex = 26;
            labelControl1.Text = "Product Name";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl2.Appearance.ForeColor = System.Drawing.Color.LightGray;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new System.Drawing.Point(75, 202);
            labelControl2.Margin = new System.Windows.Forms.Padding(4);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(61, 16);
            labelControl2.TabIndex = 27;
            labelControl2.Text = "Category";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl3.Appearance.ForeColor = System.Drawing.Color.LightGray;
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.Location = new System.Drawing.Point(75, 280);
            labelControl3.Margin = new System.Windows.Forms.Padding(4);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(32, 16);
            labelControl3.TabIndex = 28;
            labelControl3.Text = "Price";
            // 
            // quantityTE
            // 
            quantityTE.Location = new System.Drawing.Point(75, 316);
            quantityTE.Margin = new System.Windows.Forms.Padding(4);
            quantityTE.MenuManager = ribbon;
            quantityTE.Name = "quantityTE";
            quantityTE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(93, 93, 93);
            quantityTE.Properties.Appearance.BorderColor = System.Drawing.Color.White;
            quantityTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            quantityTE.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            quantityTE.Properties.Appearance.Options.UseBackColor = true;
            quantityTE.Properties.Appearance.Options.UseBorderColor = true;
            quantityTE.Properties.Appearance.Options.UseFont = true;
            quantityTE.Properties.Appearance.Options.UseForeColor = true;
            quantityTE.Properties.AutoHeight = false;
            quantityTE.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            quantityTE.Properties.MaskSettings.Set("mask", "d");
            quantityTE.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            quantityTE.Size = new System.Drawing.Size(362, 40);
            quantityTE.TabIndex = 30;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl4.Appearance.ForeColor = System.Drawing.Color.LightGray;
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Appearance.Options.UseForeColor = true;
            labelControl4.Location = new System.Drawing.Point(75, 359);
            labelControl4.Margin = new System.Windows.Forms.Padding(4);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(56, 16);
            labelControl4.TabIndex = 31;
            labelControl4.Text = "Quantity";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl5.Appearance.ForeColor = System.Drawing.Color.LightGray;
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Appearance.Options.UseForeColor = true;
            labelControl5.Location = new System.Drawing.Point(75, 438);
            labelControl5.Margin = new System.Windows.Forms.Padding(4);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(100, 16);
            labelControl5.TabIndex = 33;
            labelControl5.Text = "Low Stock Level";
            // 
            // lowstocklevelTE
            // 
            lowstocklevelTE.Location = new System.Drawing.Point(75, 395);
            lowstocklevelTE.Margin = new System.Windows.Forms.Padding(4);
            lowstocklevelTE.MenuManager = ribbon;
            lowstocklevelTE.Name = "lowstocklevelTE";
            lowstocklevelTE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(93, 93, 93);
            lowstocklevelTE.Properties.Appearance.BorderColor = System.Drawing.Color.White;
            lowstocklevelTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            lowstocklevelTE.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            lowstocklevelTE.Properties.Appearance.Options.UseBackColor = true;
            lowstocklevelTE.Properties.Appearance.Options.UseBorderColor = true;
            lowstocklevelTE.Properties.Appearance.Options.UseFont = true;
            lowstocklevelTE.Properties.Appearance.Options.UseForeColor = true;
            lowstocklevelTE.Properties.AutoHeight = false;
            lowstocklevelTE.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            lowstocklevelTE.Properties.MaskSettings.Set("mask", "d");
            lowstocklevelTE.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            lowstocklevelTE.Size = new System.Drawing.Size(362, 40);
            lowstocklevelTE.TabIndex = 32;
            // 
            // AddProductForm
            // 
            Appearance.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            Appearance.Options.UseFont = true;
            Appearance.Options.UseForeColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(516, 562);
            Controls.Add(labelControl5);
            Controls.Add(lowstocklevelTE);
            Controls.Add(labelControl4);
            Controls.Add(quantityTE);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Controls.Add(addproductBTN);
            Controls.Add(priceTE);
            Controls.Add(categoryCBE);
            Controls.Add(productnameTE);
            Controls.Add(ribbon);
            Font = new System.Drawing.Font("Century Gothic", 8.25F);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("AddProductForm.IconOptions.SvgImage");
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddProductForm";
            Ribbon = ribbon;
            RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)productnameTE.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryCBE.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceTE.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantityTE.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lowstocklevelTE.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.TextEdit productnameTE;
        private DevExpress.XtraEditors.ComboBoxEdit categoryCBE;
        private DevExpress.XtraEditors.TextEdit priceTE;
        private DevExpress.XtraEditors.SimpleButton addproductBTN;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit quantityTE;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit lowstocklevelTE;
    }
}