using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookWinFormsApp.Stradegy
{
    public interface IFileUtilsStradegy
    {
        void SaveToFile(string i_FileName, object i_SerializeInstance);
        object LoadFile(string i_FileName, object i_SerializeInstance);

    }
}
