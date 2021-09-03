using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FacebookWinFormsApp.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    public partial class LoginPageForm : Form
    {
        private readonly Theme r_OriginalTheme = new Theme(Color.LightCyan, Color.Black, Color.DodgerBlue, Color.White);
        private readonly Theme r_DarkModeTheme = new Theme(Color.Black, Color.Aqua, Color.Pink, Color.White);
        public LoginFacade LoginFacade { get; set; }

        public LoginPageForm()
        {
            LoginFacade = new LoginFacade();
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(LoginFacade.Login(rememberMeChecked.Checked))
            {
                MainForm mainForm = new MainForm(LoginFacade.LoginUser);
                mainForm.DarkAction+= makeDarkLogin;
                Hide();
                //Close();
                mainForm.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show(LoginFacade.LoginResult.ErrorMessage, "Login Failed");
            }      
        }

        public void makeDarkLogin(bool i_Dark)
        {
            if (i_Dark)
            {
                r_DarkModeTheme.MakeOnlyFormTheme(this);
                r_DarkModeTheme.MakeThemeOnControls(Controls);
            }
            else
            {
                r_OriginalTheme.MakeOnlyFormTheme(this);
                r_OriginalTheme.MakeThemeOnControls(Controls);
            }
        }
    }
}