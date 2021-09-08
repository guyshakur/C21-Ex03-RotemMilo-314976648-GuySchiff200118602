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
            this.buttonLogin = new FacebookWinFormsApp.Observer.Proxy.ButtonTheme();
            this.PictureLogoBox = new System.Windows.Forms.PictureBox();
            this.rememberMeChecked = new System.Windows.Forms.CheckBox();
            this.labelLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLogin.BackgroundImage")));
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogin.Location = new System.Drawing.Point(32, 225);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(389, 146);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // PictureLogoBox
            // 
            this.PictureLogoBox.BackgroundImage = global::FacebookWinFormsApp.Properties.Resources.logo;
            this.PictureLogoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureLogoBox.Location = new System.Drawing.Point(76, 46);
            this.PictureLogoBox.Margin = new System.Windows.Forms.Padding(4);
            this.PictureLogoBox.Name = "PictureLogoBox";
            this.PictureLogoBox.Size = new System.Drawing.Size(299, 138);
            this.PictureLogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureLogoBox.TabIndex = 53;
            this.PictureLogoBox.TabStop = false;
            // 
            // rememberMeChecked
            // 
            this.rememberMeChecked.AutoSize = true;
            this.rememberMeChecked.Location = new System.Drawing.Point(32, 197);
            this.rememberMeChecked.Margin = new System.Windows.Forms.Padding(4);
            this.rememberMeChecked.Name = "rememberMeChecked";
            this.rememberMeChecked.Size = new System.Drawing.Size(122, 21);
            this.rememberMeChecked.TabIndex = 54;
            this.rememberMeChecked.Text = "Remember Me";
            this.rememberMeChecked.UseVisualStyleBackColor = true;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(185, 5);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(0, 17);
            this.labelLogin.TabIndex = 55;
            // 
            // LoginPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(445, 399);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.rememberMeChecked);
            this.Controls.Add(this.PictureLogoBox);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginPageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private         FacebookWinFormsApp.Observer.Proxy.ButtonTheme buttonLogin;
        private System.Windows.Forms.PictureBox PictureLogoBox;
        private System.Windows.Forms.CheckBox rememberMeChecked;
        private System.Windows.Forms.Label labelLogin;
    }
}
