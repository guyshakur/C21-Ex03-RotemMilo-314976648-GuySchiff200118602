using FacebookWinFormsApp.Stradegy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FacebookWinFormsApp.Utils
{
    public class XmlFileUtilsStradegy : IFileUtilsStradegy
    {
        public object LoadFile(string i_FileName, object i_SerializeInstance)
        {
            object obj = null;

            using (Stream stream = new FileStream(@".\" + i_FileName, FileMode.Open, FileAccess.ReadWrite))
            {
                XmlSerializer serlizer = new XmlSerializer(i_SerializeInstance.GetType());
                obj = serlizer.Deserialize(stream);
            }

            return obj;
        }

        public void SaveToFile(string i_FileName, object i_SerializeInstance)
        {
            if (File.Exists(@".\" + i_FileName))
            {
                createXmlFile(FileMode.Truncate, i_FileName, i_SerializeInstance);
            }
            else
            {
                createXmlFile(FileMode.Create, i_FileName, i_SerializeInstance);
            }
        }

        private static void createXmlFile(FileMode i_FileMode, string i_FileName, object i_SerializeInstance)
        {
            using (Stream stream = new FileStream(@".\" + i_FileName, i_FileMode))
            {
                XmlSerializer serializer = new XmlSerializer(i_SerializeInstance.GetType());
                serializer.Serialize(stream, i_SerializeInstance);
            }
        }
    }

    
}
