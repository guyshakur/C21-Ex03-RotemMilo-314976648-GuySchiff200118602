using System;

namespace FacebookWinFormsApp
{
    [Serializable]
    public sealed class AppSettings
    {
        private static readonly AppSettings sr_AppSettings = new AppSettings();
        private static readonly string sr_fileName = "Settings.txt";
        private bool m_RememberUser;
        private string m_LastAcsessToken;

        private AppSettings()
        {
        }

        public static AppSettings LoadFile()
        {
            return XmlFileUtils.LoadFile(AppSettings.FileName, sr_AppSettings) as AppSettings;
        }

        public bool RememberUser
        {
            get
            {
                return m_RememberUser;
            }
     
            set
            {
                m_RememberUser = value;
            }
        }

        public string LastAcsessToken
        {
            get
            {
                return m_LastAcsessToken;
            }

            set
            {
                m_LastAcsessToken = value;
            }
        }

        public static AppSettings AppSettingsInstance
        {
            get
            {
                return sr_AppSettings;
            }
        }

        public static string FileName
        {
            get
            {
                return sr_fileName;
            }
        }

        public void SaveToFile()
        {
            XmlFileUtils.SaveToFile(AppSettings.FileName, this);
        }
    }
}