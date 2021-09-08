using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookWinFormsApp.Stradegy
{
    public sealed class Settings
    {
        private static readonly Settings sr_Settings = new Settings();
        private static readonly string sr_fileName = "Settings.txt";
        private static IFileStradegy sr_IFileStradegy;
        public bool RemeberUser { get; set; }
        public string LastAcsessToken { get; set; }
        private Settings()
        {

        }

        public static Settings SettingsInstance(IFileStradegy i_FileStradegy)
        {
            sr_IFileStradegy = i_FileStradegy;
            return sr_Settings;
        }

        public void SaveToFile()
        {
            sr_IFileStradegy.SaveToFile(sr_fileName, this);
        }

        public static Settings LoadFile()
        {
            return sr_IFileStradegy.LoadFile(sr_fileName, sr_Settings) as Settings;
        }

    }
}
