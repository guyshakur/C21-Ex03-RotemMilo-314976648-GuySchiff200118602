using FacebookWinFormsApp.Command;
using System;
using System.Collections.Generic;

namespace FacebookWinFormsApp.CostumText
{
    public class CustomText
    {
        private static readonly string sr_FileName = "CustomMessages.txt";
        private static readonly CustomText sr_CustomText = new CustomText();
        private List<string> m_TextMessage;

        private CustomText()
        {
            m_TextMessage = new List<string>();
        }

       
        public static CustomText LoadFile()
        {
            return XmlFileUtils.LoadFile(CustomText.sr_FileName, sr_CustomText) as CustomText;
        }

        public static CustomText CustomTextInstance
        {
            get
            {
                return sr_CustomText;
            }
        }

        public void createMessageAndAddToList(string i_message)
        {
            if (string.IsNullOrEmpty(i_message))
            {
                throw new Exception("can't create empty message");
            }

            m_TextMessage.Add(i_message);
        }

        public void ClearMessages()
        {
            m_TextMessage.Clear();
        }

        public void RemoveMessageFromList(int i_index)
        {
            m_TextMessage.RemoveAt(i_index);
        }

        public void SaveToFile()
        {
            XmlFileUtils.SaveToFile(CustomText.sr_FileName, this);
        }

        public List<string> TextMessage
        {
            get
            {
                return m_TextMessage;
            }

            set
            {
                m_TextMessage = value;
            }
        }           
    }
}