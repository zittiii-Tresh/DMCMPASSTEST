namespace MealPassCapstone.Desktop.Forms.Admin
{
    partial class EditPasswordForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPasswordForm));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            imageCollection1 = new DevExpress.Utils.ImageCollection(components);
            lblConfirmPasswordCaption = new DevExpress.XtraEditors.LabelControl();
            saveBTN = new DevExpress.XtraEditors.SimpleButton();
            resultLBL = new DevExpress.XtraEditors.LabelControl();
            resultcaptionLBL = new DevExpress.XtraEditors.LabelControl();
            passwordBE = new DevExpress.XtraEditors.ButtonEdit();
            confirmpassBE = new DevExpress.XtraEditors.ButtonEdit();
            labelControl11 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageCollection1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordBE.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)confirmpassBE.Properties).BeginInit();
            SuspendLayout();
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
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem });
            ribbon.Location = new System.Drawing.Point(0, 0);
            ribbon.MaxItemId = 1;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.Size = new System.Drawing.Size(506, 49);
            // 
            // imageCollection1
            // 
            imageCollection1.ImageStream = (DevExpress.Utils.ImageCollectionStreamer)resources.GetObject("imageCollection1.ImageStream");
            imageCollection1.Images.SetKeyName(0, "eyeclose.png");
            imageCollection1.Images.SetKeyName(1, "eyeopen.png");
            // 
            // lblConfirmPasswordCaption
            // 
            lblConfirmPasswordCaption.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblConfirmPasswordCaption.Appearance.ForeColor = System.Drawing.Color.FromArgb(255, 128, 128);
            lblConfirmPasswordCaption.Appearance.Options.UseFont = true;
            lblConfirmPasswordCaption.Appearance.Options.UseForeColor = true;
            lblConfirmPasswordCaption.Location = new System.Drawing.Point(282, 127);
            lblConfirmPasswordCaption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            lblConfirmPasswordCaption.Name = "lblConfirmPasswordCaption";
            lblConfirmPasswordCaption.Size = new System.Drawing.Size(0, 15);
            lblConfirmPasswordCaption.TabIndex = 43;
            // 
            // saveBTN
            // 
            saveBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(0, 191, 99);
            saveBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            saveBTN.Appearance.Options.UseBackColor = true;
            saveBTN.Appearance.Options.UseFont = true;
            saveBTN.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("saveBTN.ImageOptions.Image");
            saveBTN.Location = new System.Drawing.Point(148, 186);
            saveBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            saveBTN.Name = "saveBTN";
            saveBTN.Size = new System.Drawing.Size(199, 35);
            saveBTN.TabIndex = 42;
            saveBTN.Text = "Save New Password";
            saveBTN.Click += saveBTN_Click;
            // 
            // resultLBL
            // 
            resultLBL.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            resultLBL.Appearance.ForeColor = System.Drawing.Color.FromArgb(255, 128, 128);
            resultLBL.Appearance.Options.UseFont = true;
            resultLBL.Appearance.Options.UseForeColor = true;
            resultLBL.Location = new System.Drawing.Point(47, 130);
            resultLBL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            resultLBL.Name = "resultLBL";
            resultLBL.Size = new System.Drawing.Size(0, 15);
            resultLBL.TabIndex = 41;
            // 
            // resultcaptionLBL
            // 
            resultcaptionLBL.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            resultcaptionLBL.Appearance.ForeColor = System.Drawing.Color.FromArgb(255, 128, 128);
            resultcaptionLBL.Appearance.Options.UseFont = true;
            resultcaptionLBL.Appearance.Options.UseForeColor = true;
            resultcaptionLBL.Location = new System.Drawing.Point(47, 131);
            resultcaptionLBL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            resultcaptionLBL.Name = "resultcaptionLBL";
            resultcaptionLBL.Size = new System.Drawing.Size(0, 15);
            resultcaptionLBL.TabIndex = 40;
            // 
            // passwordBE
            // 
            passwordBE.EditValue = "";
            passwordBE.Location = new System.Drawing.Point(43, 74);
            passwordBE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            passwordBE.Name = "passwordBE";
            passwordBE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(93, 93, 93);
            passwordBE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            passwordBE.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            passwordBE.Properties.Appearance.Options.UseBackColor = true;
            passwordBE.Properties.Appearance.Options.UseFont = true;
            passwordBE.Properties.Appearance.Options.UseForeColor = true;
            passwordBE.Properties.AutoHeight = false;
            editorButtonImageOptions1.Image = (System.Drawing.Image)resources.GetObject("editorButtonImageOptions1.Image");
            passwordBE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            passwordBE.Size = new System.Drawing.Size(172, 28);
            passwordBE.TabIndex = 46;
            passwordBE.Tag = "close";
            passwordBE.ButtonPressed += passwordBE_ButtonPressed;
            passwordBE.EditValueChanged += passwordBE_EditValueChanged;
            // 
            // confirmpassBE
            // 
            confirmpassBE.EditValue = "";
            confirmpassBE.Location = new System.Drawing.Point(277, 74);
            confirmpassBE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            confirmpassBE.Name = "confirmpassBE";
            confirmpassBE.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(93, 93, 93);
            confirmpassBE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            confirmpassBE.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            confirmpassBE.Properties.Appearance.Options.UseBackColor = true;
            confirmpassBE.Properties.Appearance.Options.UseFont = true;
            confirmpassBE.Properties.Appearance.Options.UseForeColor = true;
            confirmpassBE.Properties.AutoHeight = false;
            editorButtonImageOptions2.Image = (System.Drawing.Image)resources.GetObject("editorButtonImageOptions2.Image");
            confirmpassBE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            confirmpassBE.Size = new System.Drawing.Size(172, 28);
            confirmpassBE.TabIndex = 47;
            confirmpassBE.Tag = "close";
            confirmpassBE.ButtonPressed += confirmpassBE_ButtonPressed;
            confirmpassBE.EditValueChanged += confirmpassBE_EditValueChanged;
            // 
            // labelControl11
            // 
            labelControl11.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl11.Appearance.ForeColor = System.Drawing.Color.White;
            labelControl11.Appearance.Options.UseFont = true;
            labelControl11.Appearance.Options.UseForeColor = true;
            labelControl11.Location = new System.Drawing.Point(45, 107);
            labelControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labelControl11.Name = "labelControl11";
            labelControl11.Size = new System.Drawing.Size(92, 16);
            labelControl11.TabIndex = 57;
            labelControl11.Text = "New Password";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new System.Drawing.Point(279, 108);
            labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(115, 16);
            labelControl1.TabIndex = 58;
            labelControl1.Text = "Confirm Password";
            // 
            // EditPasswordForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(506, 244);
            Controls.Add(labelControl1);
            Controls.Add(labelControl11);
            Controls.Add(confirmpassBE);
            Controls.Add(passwordBE);
            Controls.Add(lblConfirmPasswordCaption);
            Controls.Add(saveBTN);
            Controls.Add(resultLBL);
            Controls.Add(resultcaptionLBL);
            Controls.Add(ribbon);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("EditPasswordForm.IconOptions.SvgImage");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditPasswordForm";
            Ribbon = ribbon;
            RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Edit Password";
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageCollection1).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordBE.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)confirmpassBE.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.LabelControl lblConfirmPasswordCaption;
        private DevExpress.XtraEditors.SimpleButton saveBTN;
        private DevExpress.XtraEditors.LabelControl resultLBL;
        private DevExpress.XtraEditors.LabelControl resultcaptionLBL;
        private DevExpress.XtraEditors.ButtonEdit passwordBE;
        private DevExpress.XtraEditors.ButtonEdit confirmpassBE;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}