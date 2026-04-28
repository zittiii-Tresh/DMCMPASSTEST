namespace MealPassCapstone.Desktop.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            directXFormContainerControl1 = new DevExpress.XtraEditors.DirectXFormContainerControl();
            passwordTE = new DevExpress.XtraEditors.TextEdit();
            usernameTE = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(components);
            showCE = new DevExpress.XtraEditors.CheckEdit();
            loginBTN = new DevExpress.XtraEditors.SimpleButton();
            directXFormContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passwordTE.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usernameTE.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollection1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showCE.Properties).BeginInit();
            SuspendLayout();
            // 
            // directXFormContainerControl1
            // 
            directXFormContainerControl1.Controls.Add(passwordTE);
            directXFormContainerControl1.Controls.Add(usernameTE);
            directXFormContainerControl1.Controls.Add(labelControl1);
            directXFormContainerControl1.Location = new System.Drawing.Point(113, 169);
            directXFormContainerControl1.Name = "directXFormContainerControl1";
            directXFormContainerControl1.Size = new System.Drawing.Size(723, 254);
            directXFormContainerControl1.TabIndex = 0;
            // 
            // passwordTE
            // 
            passwordTE.EditValue = "Password";
            passwordTE.Location = new System.Drawing.Point(177, 208);
            passwordTE.Name = "passwordTE";
            passwordTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            passwordTE.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            passwordTE.Properties.Appearance.Options.UseFont = true;
            passwordTE.Properties.Appearance.Options.UseForeColor = true;
            passwordTE.Properties.AutoHeight = false;
            passwordTE.Size = new System.Drawing.Size(376, 36);
            passwordTE.TabIndex = 2;
            // 
            // usernameTE
            // 
            usernameTE.EditValue = "Username";
            usernameTE.Location = new System.Drawing.Point(177, 154);
            usernameTE.Name = "usernameTE";
            usernameTE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            usernameTE.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            usernameTE.Properties.Appearance.Options.UseFont = true;
            usernameTE.Properties.Appearance.Options.UseForeColor = true;
            usernameTE.Properties.AutoHeight = false;
            usernameTE.Size = new System.Drawing.Size(376, 36);
            usernameTE.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(56, 107, 60);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new System.Drawing.Point(256, 100);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(212, 32);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Let's get started!";
            // 
            // svgImageCollection1
            // 
            svgImageCollection1.Add("closebutton", "image://svgimages/richedit/clearheaderandfooter.svg");
            svgImageCollection1.Add("mis-logo", (DevExpress.Utils.Svg.SvgImage)resources.GetObject("svgImageCollection1.mis-logo"));
            svgImageCollection1.Add("mp-logo", (DevExpress.Utils.Svg.SvgImage)resources.GetObject("svgImageCollection1.mp-logo"));
            // 
            // showCE
            // 
            showCE.Location = new System.Drawing.Point(608, 421);
            showCE.Name = "showCE";
            showCE.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            showCE.Properties.Appearance.ForeColor = System.Drawing.Color.Green;
            showCE.Properties.Appearance.Options.UseFont = true;
            showCE.Properties.Appearance.Options.UseForeColor = true;
            showCE.Properties.Caption = "Show";
            showCE.Size = new System.Drawing.Size(65, 22);
            showCE.TabIndex = 1;
            showCE.CheckedChanged += showCE_CheckedChanged;
            // 
            // loginBTN
            // 
            loginBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(56, 107, 60);
            loginBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            loginBTN.Appearance.Options.UseBackColor = true;
            loginBTN.Appearance.Options.UseFont = true;
            loginBTN.Location = new System.Drawing.Point(412, 455);
            loginBTN.Name = "loginBTN";
            loginBTN.Size = new System.Drawing.Size(132, 35);
            loginBTN.TabIndex = 2;
            loginBTN.Text = "Login";
            loginBTN.Click += loginBTN_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ChildControls.Add(directXFormContainerControl1);
            ChildControls.Add(showCE);
            ChildControls.Add(loginBTN);
            ClientSize = new System.Drawing.Size(857, 586);
            HtmlImages = svgImageCollection1;
            HtmlTemplate.Styles = resources.GetString("LoginForm.HtmlTemplate.Styles");
            HtmlTemplate.Template = resources.GetString("LoginForm.HtmlTemplate.Template");
            IconOptions.Image = (System.Drawing.Image)resources.GetObject("LoginForm.IconOptions.Image");
            Name = "LoginForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "LoginForm";
            directXFormContainerControl1.ResumeLayout(false);
            directXFormContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)passwordTE.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)usernameTE.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)svgImageCollection1).EndInit();
            ((System.ComponentModel.ISupportInitialize)showCE.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.DirectXFormContainerControl directXFormContainerControl1;
        public DevExpress.Utils.SvgImageCollection svgImageCollection1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit passwordTE;
        private DevExpress.XtraEditors.TextEdit usernameTE;
        private DevExpress.XtraEditors.CheckEdit showCE;
        private DevExpress.XtraEditors.SimpleButton loginBTN;
    }
}