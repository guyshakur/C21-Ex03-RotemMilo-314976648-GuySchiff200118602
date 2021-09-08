using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Observer.Proxy
{
    public class CheckBoxTheme:CheckBox,IThemable
    {
        private readonly ThemeControlMaker r_ThemeControlMaker;
        public CheckBoxTheme()
        {
            r_ThemeControlMaker = new ThemeControlMaker(this);
        }
        ThemeMaker IThemable.ThemeMaker => r_ThemeControlMaker;
    }
}
