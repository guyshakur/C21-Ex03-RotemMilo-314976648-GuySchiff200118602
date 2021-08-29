using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    public partial class LoginPageForm : Form
    {
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
                Hide();
                Close();
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