using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Observer.Proxy
{
    public class TextBoxTheme:TextBox,IThemable
    {
        private readonly ThemeControlMaker r_ThemeControlMaker;
        public TextBoxTheme()
        {
            r_ThemeControlMaker = new ThemeControlMaker(this);
        }
        ThemeMaker IThemable.ThemeMaker => r_ThemeControlMaker;
    }
}
