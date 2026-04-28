namespace MealPassCapstone.Desktop.Forms.Admin
{
    partial class EditEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEmployeeForm));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            resultcaptionLBL = new DevExpress.XtraEditors.LabelControl();
            resultLBL = new DevExpress.XtraEditors.LabelControl();
            middlenameTE = new DevExpress.XtraEditors.TextEdit();
            labelControl10 = new DevExpress.XtraEditors.LabelControl();
            firstnameTE = new DevExpress.XtraEditors.TextEdit();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            lastnameTE = new DevExpress.XtraEditors.TextEdit();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            extensionTE = new DevExpress.XtraEditors.TextEdit();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            contactTE = new DevExpress.XtraEditors.TextEdit();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            birthdateDE = new DevExpress.XtraEditors.DateEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            civilstatusCBE = new DevExpress.XtraEditors.ComboBoxEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            genderRG = new DevExpress.XtraEditors.RadioGroup();
            deleteBTN = new DevExpress.XtraEditors.SimpleButton();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            positionRG = new DevExpress.XtraEditors.RadioGroup();
            usernameTE = new DevExpress.XtraEditors.TextEdit();
            employeeRG = new DevExpress.XtraEditors.RadioGroup();
            labelControl12 = new DevExpress.XtraEditors.LabelControl();
            availabilityLC = new DevExpress.XtraEditors.LabelControl();
            accountTS = new DevExpress.XtraEditors.ToggleSwitch();
            labelControl11 = new DevExpress.XtraEditors.LabelControl();
            changepasswordHLBL = new DevExpress.XtraEditors.HyperlinkLabelControl();
            saveBTN = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)middlenameTE.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)firstnameTE.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lastnameTE.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)extensionTE.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contactTE.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)birthdateDE.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)birthdateDE.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)civilstatusCBE.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)genderRG.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)positionRG.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usernameTE.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeRG.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountTS.Properties).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem });
            ribbon.Location = new System.Drawing.Point(0, 0);
            ribbon.MaxItemId = 1;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.Size = new System.Drawing.Size(1017, 49);
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
            // resultcaptionLBL
            // 
            resultcaptionLBL.Location = new System.Drawing.Point(399, 247);
            resultcaptionLBL.Name = "resultcaptionLBL";
            resultcaptionLBL.Size = new System.Drawing.Size(0, 13);
            resultcaptionLBL.TabIndex = 85;
            // 
            // resultLBL
            // 
            resultLBL.Location = new System.Drawing.Point(399, 231);
            resultLBL.Name = "resultLBL";
            resultLBL.Size = new System.Drawing.Size(0, 13);
            resultLBL.TabIndex = 84;
            // 
            // middlenameTE
            // 
            middlenameTE.EditValue = "";
            middlenameTE.Location = new System.Drawing.Point(221, 75);
            middlenameTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            middlenameTE.Name = "middlenameTE";
            middlenameTE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(93, 93, 93);
            middlenameTE.Properties.Appearance.BorderColor = System.Drawing.Color.White;
            middlenameTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            middlenameTE.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            middlenameTE.Properties.Appearance.Options.UseBackColor = true;
            middlenameTE.Properties.Appearance.Options.UseBorderColor = true;
            middlenameTE.Properties.Appearance.Options.UseFont = true;
            middlenameTE.Properties.Appearance.Options.UseForeColor = true;
            middlenameTE.Properties.AutoHeight = false;
            middlenameTE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            middlenameTE.Size = new System.Drawing.Size(172, 28);
            middlenameTE.TabIndex = 62;
            // 
            // labelControl10
            // 
            labelControl10.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl10.Appearance.ForeColor = System.Drawing.Color.White;
            labelControl10.Appearance.Options.UseFont = true;
            labelControl10.Appearance.Options.UseForeColor = true;
            labelControl10.Location = new System.Drawing.Point(30, 265);
            labelControl10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labelControl10.Name = "labelControl10";
            labelControl10.Size = new System.Drawing.Size(64, 16);
            labelControl10.TabIndex = 82;
            labelControl10.Text = "Username";
            // 
            // firstnameTE
            // 
            firstnameTE.EditValue = "";
            firstnameTE.Location = new System.Drawing.Point(28, 75);
            firstnameTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            firstnameTE.Name = "firstnameTE";
            firstnameTE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(93, 93, 93);
            firstnameTE.Properties.Appearance.BorderColor = System.Drawing.Color.White;
            firstnameTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            firstnameTE.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            firstnameTE.Properties.Appearance.Options.UseBackColor = true;
            firstnameTE.Properties.Appearance.Options.UseBorderColor = true;
            firstnameTE.Properties.Appearance.Options.UseFont = true;
            firstnameTE.Properties.Appearance.Options.UseForeColor = true;
            firstnameTE.Properties.AutoHeight = false;
            firstnameTE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            firstnameTE.Size = new System.Drawing.Size(172, 28);
            firstnameTE.TabIndex = 61;
            // 
            // labelControl9
            // 
            labelControl9.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl9.Appearance.ForeColor = System.Drawing.Color.White;
            labelControl9.Appearance.Options.UseFont = true;
            labelControl9.Appearance.Options.UseForeColor = true;
            labelControl9.Location = new System.Drawing.Point(224, 188);
            labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new System.Drawing.Size(71, 16);
            labelControl9.TabIndex = 81;
            labelControl9.Text = "Civil Status";
            // 
            // lastnameTE
            // 
            lastnameTE.EditValue = "";
            lastnameTE.Location = new System.Drawing.Point(413, 75);
            lastnameTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            lastnameTE.Name = "lastnameTE";
            lastnameTE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(93, 93, 93);
            lastnameTE.Properties.Appearance.BorderColor = System.Drawing.Color.White;
            lastnameTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lastnameTE.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            lastnameTE.Properties.Appearance.Options.UseBackColor = true;
            lastnameTE.Properties.Appearance.Options.UseBorderColor = true;
            lastnameTE.Properties.Appearance.Options.UseFont = true;
            lastnameTE.Properties.Appearance.Options.UseForeColor = true;
            lastnameTE.Properties.AutoHeight = false;
            lastnameTE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            lastnameTE.Size = new System.Drawing.Size(172, 28);
            lastnameTE.TabIndex = 63;
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl8.Appearance.ForeColor = System.Drawing.Color.White;
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Appearance.Options.UseForeColor = true;
            labelControl8.Location = new System.Drawing.Point(30, 188);
            labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new System.Drawing.Size(59, 16);
            labelControl8.TabIndex = 80;
            labelControl8.Text = "Birthdate";
            // 
            // extensionTE
            // 
            extensionTE.EditValue = "";
            extensionTE.Location = new System.Drawing.Point(606, 75);
            extensionTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            extensionTE.Name = "extensionTE";
            extensionTE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(93, 93, 93);
            extensionTE.Properties.Appearance.BorderColor = System.Drawing.Color.White;
            extensionTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            extensionTE.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            extensionTE.Properties.Appearance.Options.UseBackColor = true;
            extensionTE.Properties.Appearance.Options.UseBorderColor = true;
            extensionTE.Properties.Appearance.Options.UseFont = true;
            extensionTE.Properties.Appearance.Options.UseForeColor = true;
            extensionTE.Properties.AutoHeight = false;
            extensionTE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            extensionTE.Size = new System.Drawing.Size(172, 28);
            extensionTE.TabIndex = 64;
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl7.Appearance.ForeColor = System.Drawing.Color.White;
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Appearance.Options.UseForeColor = true;
            labelControl7.Location = new System.Drawing.Point(803, 112);
            labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new System.Drawing.Size(77, 16);
            labelControl7.TabIndex = 79;
            labelControl7.Text = "Contact No.";
            // 
            // contactTE
            // 
            contactTE.EditValue = "";
            contactTE.Location = new System.Drawing.Point(799, 75);
            contactTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            contactTE.Name = "contactTE";
            contactTE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(93, 93, 93);
            contactTE.Properties.Appearance.BorderColor = System.Drawing.Color.White;
            contactTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            contactTE.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            contactTE.Properties.Appearance.Options.UseBackColor = true;
            contactTE.Properties.Appearance.Options.UseBorderColor = true;
            contactTE.Properties.Appearance.Options.UseFont = true;
            contactTE.Properties.Appearance.Options.UseForeColor = true;
            contactTE.Properties.AutoHeight = false;
            contactTE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            contactTE.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            contactTE.Properties.MaskSettings.Set("mask", "(000) 000-0000");
            contactTE.Size = new System.Drawing.Size(172, 28);
            contactTE.TabIndex = 65;
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Appearance.Options.UseForeColor = true;
            labelControl6.Location = new System.Drawing.Point(610, 112);
            labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new System.Drawing.Size(103, 16);
            labelControl6.TabIndex = 78;
            labelControl6.Text = "Name Extension";
            // 
            // birthdateDE
            // 
            birthdateDE.EditValue = null;
            birthdateDE.Location = new System.Drawing.Point(28, 150);
            birthdateDE.MenuManager = ribbon;
            birthdateDE.Name = "birthdateDE";
            birthdateDE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(93, 93, 93);
            birthdateDE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            birthdateDE.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            birthdateDE.Properties.Appearance.Options.UseBackColor = true;
            birthdateDE.Properties.Appearance.Options.UseFont = true;
            birthdateDE.Properties.Appearance.Options.UseForeColor = true;
            birthdateDE.Properties.AutoHeight = false;
            birthdateDE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            birthdateDE.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            birthdateDE.Size = new System.Drawing.Size(172, 28);
            birthdateDE.TabIndex = 66;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Appearance.Options.UseForeColor = true;
            labelControl5.Location = new System.Drawing.Point(416, 112);
            labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(62, 16);
            labelControl5.TabIndex = 77;
            labelControl5.Text = "Lastname";
            // 
            // civilstatusCBE
            // 
            civilstatusCBE.Location = new System.Drawing.Point(221, 150);
            civilstatusCBE.MenuManager = ribbon;
            civilstatusCBE.Name = "civilstatusCBE";
            civilstatusCBE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(93, 93, 93);
            civilstatusCBE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            civilstatusCBE.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            civilstatusCBE.Properties.Appearance.Options.UseBackColor = true;
            civilstatusCBE.Properties.Appearance.Options.UseFont = true;
            civilstatusCBE.Properties.Appearance.Options.UseForeColor = true;
            civilstatusCBE.Properties.AutoHeight = false;
            civilstatusCBE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            civilstatusCBE.Properties.Items.AddRange(new object[] { "Single", "Married", "Widowed", "Separated" });
            civilstatusCBE.Size = new System.Drawing.Size(172, 28);
            civilstatusCBE.TabIndex = 67;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new System.Drawing.Point(224, 112);
            labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(83, 16);
            labelControl2.TabIndex = 76;
            labelControl2.Text = "Middlename";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Appearance.Options.UseForeColor = true;
            labelControl4.Location = new System.Drawing.Point(416, 147);
            labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(49, 16);
            labelControl4.TabIndex = 68;
            labelControl4.Text = "Gender";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new System.Drawing.Point(30, 112);
            labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(62, 16);
            labelControl1.TabIndex = 75;
            labelControl1.Text = "Firstname";
            // 
            // genderRG
            // 
            genderRG.Location = new System.Drawing.Point(428, 174);
            genderRG.Name = "genderRG";
            genderRG.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            genderRG.Properties.Appearance.BorderColor = System.Drawing.Color.Transparent;
            genderRG.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            genderRG.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            genderRG.Properties.Appearance.Options.UseBackColor = true;
            genderRG.Properties.Appearance.Options.UseBorderColor = true;
            genderRG.Properties.Appearance.Options.UseFont = true;
            genderRG.Properties.Appearance.Options.UseForeColor = true;
            genderRG.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            genderRG.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            genderRG.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            genderRG.Properties.Columns = 2;
            genderRG.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] { new DevExpress.XtraEditors.Controls.RadioGroupItem("Male", "Male", true, "Male", "Male"), new DevExpress.XtraEditors.Controls.RadioGroupItem("Female", "Female", true, "Female", "Female") });
            genderRG.Size = new System.Drawing.Size(157, 30);
            genderRG.TabIndex = 69;
            // 
            // deleteBTN
            // 
            deleteBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(255, 87, 87);
            deleteBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            deleteBTN.Appearance.Options.UseBackColor = true;
            deleteBTN.Appearance.Options.UseFont = true;
            deleteBTN.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("addemployeeBTN.ImageOptions.Image");
            deleteBTN.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            deleteBTN.Location = new System.Drawing.Point(841, 253);
            deleteBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Padding = new System.Windows.Forms.Padding(2);
            deleteBTN.Size = new System.Drawing.Size(155, 44);
            deleteBTN.TabIndex = 74;
            deleteBTN.Text = "Delete Employee";
            deleteBTN.Click += deleteBTN_Click;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.Location = new System.Drawing.Point(610, 150);
            labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(49, 16);
            labelControl3.TabIndex = 71;
            labelControl3.Text = "Position";
            // 
            // positionRG
            // 
            positionRG.Location = new System.Drawing.Point(624, 174);
            positionRG.Name = "positionRG";
            positionRG.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            positionRG.Properties.Appearance.BorderColor = System.Drawing.Color.Transparent;
            positionRG.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            positionRG.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            positionRG.Properties.Appearance.Options.UseBackColor = true;
            positionRG.Properties.Appearance.Options.UseBorderColor = true;
            positionRG.Properties.Appearance.Options.UseFont = true;
            positionRG.Properties.Appearance.Options.UseForeColor = true;
            positionRG.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            positionRG.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            positionRG.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            positionRG.Properties.Columns = 2;
            positionRG.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] { new DevExpress.XtraEditors.Controls.RadioGroupItem((short)1, "Admin", true, "Admin", "Admin"), new DevExpress.XtraEditors.Controls.RadioGroupItem((short)2, "Staff", true, "Staff", "Staff") });
            positionRG.Size = new System.Drawing.Size(142, 30);
            positionRG.TabIndex = 70;
            // 
            // usernameTE
            // 
            usernameTE.EditValue = "";
            usernameTE.Location = new System.Drawing.Point(28, 231);
            usernameTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            usernameTE.Name = "usernameTE";
            usernameTE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(93, 93, 93);
            usernameTE.Properties.Appearance.BorderColor = System.Drawing.Color.White;
            usernameTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            usernameTE.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            usernameTE.Properties.Appearance.Options.UseBackColor = true;
            usernameTE.Properties.Appearance.Options.UseBorderColor = true;
            usernameTE.Properties.Appearance.Options.UseFont = true;
            usernameTE.Properties.Appearance.Options.UseForeColor = true;
            usernameTE.Properties.AutoHeight = false;
            usernameTE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            usernameTE.Size = new System.Drawing.Size(172, 28);
            usernameTE.TabIndex = 72;
            // 
            // employeeRG
            // 
            employeeRG.Location = new System.Drawing.Point(793, 175);
            employeeRG.Name = "employeeRG";
            employeeRG.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            employeeRG.Properties.Appearance.BorderColor = System.Drawing.Color.Transparent;
            employeeRG.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            employeeRG.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            employeeRG.Properties.Appearance.Options.UseBackColor = true;
            employeeRG.Properties.Appearance.Options.UseBorderColor = true;
            employeeRG.Properties.Appearance.Options.UseFont = true;
            employeeRG.Properties.Appearance.Options.UseForeColor = true;
            employeeRG.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            employeeRG.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            employeeRG.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            employeeRG.Properties.Columns = 2;
            employeeRG.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] { new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Active", true, "Active", "Active"), new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "In-Active", true, "In-Active", "In-Active") });
            employeeRG.Size = new System.Drawing.Size(168, 30);
            employeeRG.TabIndex = 87;
            // 
            // labelControl12
            // 
            labelControl12.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl12.Appearance.ForeColor = System.Drawing.Color.White;
            labelControl12.Appearance.Options.UseFont = true;
            labelControl12.Appearance.Options.UseForeColor = true;
            labelControl12.Location = new System.Drawing.Point(783, 151);
            labelControl12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labelControl12.Name = "labelControl12";
            labelControl12.Size = new System.Drawing.Size(106, 16);
            labelControl12.TabIndex = 86;
            labelControl12.Text = "Employee Status";
            // 
            // availabilityLC
            // 
            availabilityLC.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            availabilityLC.Appearance.ForeColor = System.Drawing.Color.White;
            availabilityLC.Appearance.Options.UseFont = true;
            availabilityLC.Appearance.Options.UseForeColor = true;
            availabilityLC.Location = new System.Drawing.Point(317, 239);
            availabilityLC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            availabilityLC.Name = "availabilityLC";
            availabilityLC.Size = new System.Drawing.Size(44, 16);
            availabilityLC.TabIndex = 89;
            availabilityLC.Text = "Locked";
            // 
            // accountTS
            // 
            accountTS.EditValue = true;
            accountTS.Location = new System.Drawing.Point(213, 229);
            accountTS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            accountTS.Name = "accountTS";
            accountTS.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            accountTS.Properties.Appearance.Options.UseFont = true;
            accountTS.Properties.AutoHeight = false;
            accountTS.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            accountTS.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(44, 89, 142);
            accountTS.Properties.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(255, 87, 87);
            accountTS.Properties.LookAndFeel.SkinName = "The Bezier";
            accountTS.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            accountTS.Properties.OffText = "Off";
            accountTS.Properties.OnText = "On";
            accountTS.Properties.ThumbWidth = 10;
            accountTS.Size = new System.Drawing.Size(105, 35);
            accountTS.TabIndex = 88;
            accountTS.Toggled += accountTS_Toggled;
            // 
            // labelControl11
            // 
            labelControl11.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl11.Appearance.ForeColor = System.Drawing.Color.White;
            labelControl11.Appearance.Options.UseFont = true;
            labelControl11.Appearance.Options.UseForeColor = true;
            labelControl11.Location = new System.Drawing.Point(487, 267);
            labelControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labelControl11.Name = "labelControl11";
            labelControl11.Size = new System.Drawing.Size(102, 16);
            labelControl11.TabIndex = 91;
            labelControl11.Text = "Forgot Password?";
            // 
            // changepasswordHLBL
            // 
            changepasswordHLBL.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            changepasswordHLBL.Appearance.ForeColor = System.Drawing.Color.FromArgb(0, 191, 99);
            changepasswordHLBL.Appearance.Options.UseFont = true;
            changepasswordHLBL.Appearance.Options.UseForeColor = true;
            changepasswordHLBL.Location = new System.Drawing.Point(595, 267);
            changepasswordHLBL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            changepasswordHLBL.Name = "changepasswordHLBL";
            changepasswordHLBL.Size = new System.Drawing.Size(64, 16);
            changepasswordHLBL.TabIndex = 90;
            changepasswordHLBL.Text = "Click Here!";
            changepasswordHLBL.Click += changepasswordHLBL_Click;
            // 
            // saveBTN
            // 
            saveBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(0, 151, 178);
            saveBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            saveBTN.Appearance.Options.UseBackColor = true;
            saveBTN.Appearance.Options.UseFont = true;
            saveBTN.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("saveBTN.ImageOptions.Image");
            saveBTN.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            saveBTN.Location = new System.Drawing.Point(675, 253);
            saveBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            saveBTN.Name = "saveBTN";
            saveBTN.Padding = new System.Windows.Forms.Padding(2);
            saveBTN.Size = new System.Drawing.Size(155, 44);
            saveBTN.TabIndex = 92;
            saveBTN.Text = "Save Changes";
            saveBTN.Click += saveBTN_Click;
            // 
            // EditEmployeeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1017, 314);
            Controls.Add(saveBTN);
            Controls.Add(labelControl11);
            Controls.Add(changepasswordHLBL);
            Controls.Add(availabilityLC);
            Controls.Add(accountTS);
            Controls.Add(employeeRG);
            Controls.Add(labelControl12);
            Controls.Add(resultcaptionLBL);
            Controls.Add(resultLBL);
            Controls.Add(middlenameTE);
            Controls.Add(labelControl10);
            Controls.Add(firstnameTE);
            Controls.Add(labelControl9);
            Controls.Add(lastnameTE);
            Controls.Add(labelControl8);
            Controls.Add(extensionTE);
            Controls.Add(labelControl7);
            Controls.Add(contactTE);
            Controls.Add(labelControl6);
            Controls.Add(birthdateDE);
            Controls.Add(labelControl5);
            Controls.Add(civilstatusCBE);
            Controls.Add(labelControl2);
            Controls.Add(labelControl4);
            Controls.Add(labelControl1);
            Controls.Add(genderRG);
            Controls.Add(deleteBTN);
            Controls.Add(labelControl3);
            Controls.Add(positionRG);
            Controls.Add(usernameTE);
            Controls.Add(ribbon);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("EditEmployeeForm.IconOptions.SvgImage");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditEmployeeForm";
            Ribbon = ribbon;
            RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Edit Employee";
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)middlenameTE.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)firstnameTE.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lastnameTE.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)extensionTE.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)contactTE.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)birthdateDE.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)birthdateDE.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)civilstatusCBE.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)genderRG.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)positionRG.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)usernameTE.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeRG.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountTS.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.LabelControl resultcaptionLBL;
        private DevExpress.XtraEditors.LabelControl resultLBL;
        public DevExpress.XtraEditors.TextEdit middlenameTE;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        public DevExpress.XtraEditors.TextEdit firstnameTE;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        public DevExpress.XtraEditors.TextEdit lastnameTE;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        public DevExpress.XtraEditors.TextEdit extensionTE;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        public DevExpress.XtraEditors.TextEdit contactTE;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit birthdateDE;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit civilstatusCBE;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.RadioGroup genderRG;
        private DevExpress.XtraEditors.SimpleButton deleteBTN;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.RadioGroup positionRG;
        public DevExpress.XtraEditors.TextEdit usernameTE;
        private DevExpress.XtraEditors.RadioGroup employeeRG;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl availabilityLC;
        private DevExpress.XtraEditors.ToggleSwitch accountTS;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.HyperlinkLabelControl changepasswordHLBL;
        private DevExpress.XtraEditors.SimpleButton saveBTN;
    }
}