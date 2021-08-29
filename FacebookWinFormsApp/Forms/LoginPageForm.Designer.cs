using System.Drawing;

namespace FacebookWinFormsApp
{
    public partial class LoginPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPageForm));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.PictureLogoBox = new System.Windows.Forms.PictureBox();
            this.rememberMeChecked = new System.Windows.Forms.CheckBox();
            this.labelLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLogin.BackgroundImage")));
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogin.Location = new System.Drawing.Point(24, 183);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(292, 119);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);

            // 
            // PictureLogoBox
            // 
            this.PictureLogoBox.BackgroundImage = global::FacebookWinFormsApp.Properties.Resources.logo;
            this.PictureLogoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureLogoBox.Location = new System.Drawing.Point(57, 37);
            this.PictureLogoBox.Name = "PictureLogoBox";
            this.PictureLogoBox.Size = new System.Drawing.Size(224, 112);
            this.PictureLogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureLogoBox.TabIndex = 53;
            this.PictureLogoBox.TabStop = false;
            // 
            // rememberMeChecked
            // 
            this.rememberMeChecked.AutoSize = true;
            this.rememberMeChecked.Location = new System.Drawing.Point(24, 160);
            this.rememberMeChecked.Name = "rememberMeChecked";
            this.rememberMeChecked.Size = new System.Drawing.Size(95, 17);
            this.rememberMeChecked.TabIndex = 54;
            this.rememberMeChecked.Text = "Remember Me";
            this.rememberMeChecked.UseVisualStyleBackColor = true;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(139, 4);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(0, 13);
            this.labelLogin.TabIndex = 55;
            // 
            // FormLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 324);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.rememberMeChecked);
            this.Controls.Add(this.PictureLogoBox);
            this.Controls.Add(this.buttonLogin);
            this.Name = "FormLoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox PictureLogoBox;
        private System.Windows.Forms.CheckBox rememberMeChecked;
        private System.Windows.Forms.Label labelLogin;
    }
}
