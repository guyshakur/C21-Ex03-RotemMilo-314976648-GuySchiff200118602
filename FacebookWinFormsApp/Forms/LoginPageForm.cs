using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FacebookWinFormsApp.Observer.Proxy;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    public partial class LoginPageForm : FormTheme
    {
        
        public LoginFacade LoginFacade { get; set; }
       

        public LoginPageForm():base(new ColorScheme(Color.Black, Color.GhostWhite))
        {
            LoginFacade = new LoginFacade();
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(LoginFacade.Login(rememberMeChecked.Checked))
            {
                MainForm mainForm = new MainForm(LoginFacade.LoginUser);
                mainForm.AddListeners(enableOrDisableColorScheme);
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
    }
}