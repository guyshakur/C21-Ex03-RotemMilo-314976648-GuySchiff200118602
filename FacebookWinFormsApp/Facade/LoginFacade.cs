using System;
using System.Collections.Generic;
using FacebookWinFormsApp.Stradegy;
using FacebookWinFormsApp.Utils;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    public class LoginFacade
    {
        public Settings Settings { get; set; }

        public User LoginUser { get; set; }

        public LoginResult LoginResult { get; set; }

        public LoginFacade()
        {
            //AppSettings = AppSettings.AppSettingsInstance;
            Settings = Settings.SettingsInstance(new XmlFileUtilsStradegy());
            FacebookService.s_CollectionLimit = 100;
        }

        public bool Login(bool i_RememberedUser)
        {
            LoginResult = FacebookService.Login(
                    "226428995869586",
                    "email",
                    "user_posts",
                    "user_friends",
                    "user_likes",
                    "user_photos",
                    "user_events",
                    "user_birthday",
                    "user_location",
                    "user_gender",
                    "groups_access_member_info");
            if (i_RememberedUser)
            {
                //AppSettings.RememberUser = true;
                Settings.RemeberUser = true;
                setLastAccessToken();
            }

            //AppSettings.SaveToFile();
            Settings.SaveToFile();
            LoginUser = LoginResult.LoggedInUser;
            return LoginResult.AccessToken != null;
        }

        private void setLastAccessToken()
        {
            //AppSettings.LastAcsessToken = LoginResult.AccessToken;
            Settings.LastAcsessToken = LoginResult.AccessToken;
        }

        public void LogOut()
        {
            FacebookService.Logout();
            //AppSettings.LastAcsessToken = string.Empty;
            //AppSettings.RememberUser = false;
            // AppSettings.SaveToFile();
            Settings.LastAcsessToken = string.Empty;
            Settings.RemeberUser = false;
            Settings.SaveToFile();
            LoginResult = null;
        }
    }
}
