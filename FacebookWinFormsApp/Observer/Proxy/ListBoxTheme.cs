using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Observer.Proxy
{
    public class ListBoxTheme:ListBox,IThemable
    {
        private readonly ThemeControlMaker r_ThemeControlMaker;
        public ListBoxTheme()
        {
            r_ThemeControlMaker = new ThemeControlMaker(this);
        }
        ThemeMaker IThemable.ThemeMaker => r_ThemeControlMaker;
    }
}
