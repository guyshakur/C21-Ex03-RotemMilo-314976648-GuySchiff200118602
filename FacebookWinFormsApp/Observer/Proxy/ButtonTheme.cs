using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Observer.Proxy
{
    public class ButtonTheme:Button,IThemable
    {
        private readonly ThemeControlMaker r_ThemeControlMaker;
        public ButtonTheme()
        {
            r_ThemeControlMaker = new ThemeControlMaker(this);
        }
        ThemeMaker IThemable.ThemeMaker => r_ThemeControlMaker;
    }
}
