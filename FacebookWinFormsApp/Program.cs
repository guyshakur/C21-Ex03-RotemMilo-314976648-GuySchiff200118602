using System;
using System.Windows.Forms;
using FacebookWrapper;

namespace FacebookWinFormsApp
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            StartBasicFeatureFacebookApp();
        }

        private static void StartBasicFeatureFacebookApp()
        {
            FacebookService.s_UseForamttedToStrings = true;
            Clipboard.SetText("design.patterns.c21");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //bb
            LoginPageForm formLoginPage = new LoginPageForm();
            LoginFacade loginFacade = new LoginFacade();
            try
            {
                loginFacade.AppSettings = AppSettings.LoadFile();
                if (!string.IsNullOrEmpty(loginFacade.AppSettings.LastAcsessToken) && loginFacade.AppSettings.RememberUser)
                {
                    try
                    {
                        loginFacade.LoginResult = FacebookService.Connect(loginFacade.AppSettings.LastAcsessToken);
                        MainForm mainForm = new MainForm(loginFacade.LoginResult.LoggedInUser);
                        mainForm.ShowDialog();
                    }
                    catch (Exception)
                    {
                        formLoginPage.ShowDialog();
                    }
                }
                else
                {
                    formLoginPage.ShowDialog();
                }
            }
            catch (Exception)
            {
                formLoginPage.ShowDialog();
            }
        }
    }
}