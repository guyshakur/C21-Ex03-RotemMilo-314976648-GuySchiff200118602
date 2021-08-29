using System;
using System.Windows.Forms;
using FacebookWinFormsApp.Stradegy;
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
                //loginFacade.AppSettings = AppSettings.LoadFile();
                loginFacade.Settings = Settings.LoadFile();
                //if (!string.IsNullOrEmpty(loginFacade.AppSettings.LastAcsessToken) && loginFacade.AppSettings.RememberUser)
                if (!string.IsNullOrEmpty(loginFacade.Settings.LastAcsessToken) && loginFacade.Settings.RemeberUser)
                {
                    try
                    {
                        //loginFacade.LoginResult = FacebookService.Connect(loginFacade.AppSettings.LastAcsessToken);
                        loginFacade.LoginResult = FacebookService.Connect(loginFacade.Settings.LastAcsessToken);
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