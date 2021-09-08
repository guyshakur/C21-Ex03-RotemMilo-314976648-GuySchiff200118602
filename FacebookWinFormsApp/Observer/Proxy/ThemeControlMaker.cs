using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Observer.Proxy
{
    public class ThemeControlMaker: ThemeMaker
    {
        public ThemeControlMaker(IThemable i_ControlTheme) : base(i_ControlTheme)
        {
        }

        protected override void MakeTheme(ColorScheme i_ColorScheme)
        {
            Control control = m_ControlTheme as Control;
            control.BackColor = i_ColorScheme.BackColor;
            control.ForeColor = i_ColorScheme.ForeColor;
        }

        protected override void InitializeSpecificTheme()
        {
            Control control = m_ControlTheme as Control;
            OriginialColorScheme = new ColorScheme(control.BackColor, control.ForeColor);
        }

        protected override void ClearSpecificTheme()
        {
            Control meAsComponent = m_ControlTheme as Control;
            meAsComponent.BackColor = OriginialColorScheme.BackColor;
            meAsComponent.ForeColor = OriginialColorScheme.ForeColor;
            ColorScheme = new ColorScheme(OriginialColorScheme.BackColor, OriginialColorScheme.ForeColor);
        }
    }
}
