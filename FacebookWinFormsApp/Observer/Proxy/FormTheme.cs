using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Observer.Proxy
{
    public delegate void ColorSchemeChangeModeDelegeate(bool i_Dark);

    public class FormTheme : Form, IThemable
    {
        private readonly ThemeComponentMaker r_ThemeComponentMaker;
        private const int k_ChildrenBrigthness = 20;
        protected readonly ColorScheme r_NewColorScheme;

        public FormTheme(ColorScheme i_ColorScheme)
        {
            r_NewColorScheme = i_ColorScheme;
            r_ThemeComponentMaker = new ThemeComponentMaker(this, k_ChildrenBrigthness);
        }

        public FormTheme()
        {
            r_NewColorScheme = new ColorScheme(Color.Blue, Color.White);
            r_ThemeComponentMaker = new ThemeComponentMaker(this, k_ChildrenBrigthness);
        }
        protected virtual void enableOrDisableColorScheme(bool i_Dark)
        {
            MakeColorSchemeOnForm(r_NewColorScheme, i_Dark);
        }

        protected override void OnLoad(EventArgs e)
        {
            r_ThemeComponentMaker.InitializeTheme();
        }

        protected virtual void MakeColorSchemeOnForm(ColorScheme i_ColorScheme, bool i_Dark)
        {
            if (i_Dark)
            {
                if(i_ColorScheme!=null)
                {
                    r_ThemeComponentMaker.ColorScheme = i_ColorScheme;
                }
                else
                {
                    throw new Exception(string.Format("ColorScheme is null, please enter ColorScheme or change the flag to {0}", !i_Dark));
                }
            }
            else
            {
                r_ThemeComponentMaker.ClearToOriginTheme();
            }
        }
        ThemeMaker IThemable.ThemeMaker => r_ThemeComponentMaker;
    }
}
