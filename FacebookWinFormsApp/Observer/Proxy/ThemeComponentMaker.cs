using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Observer.Proxy
{
    public class ThemeComponentMaker : ThemeMaker
    {
        public ColorScheme ChildrenColorScheme { get; private set; }
        public int ChildrenColorBrightness { get; private set; }

        public ThemeComponentMaker(IThemable i_ControlTheme, int i_ChildrenColorBrightness) :base(i_ControlTheme)
        {
            ChildrenColorBrightness = i_ChildrenColorBrightness;
           // ChildrenColorScheme = getChildrenColorInBrightness(OriginialColorScheme);
        }
        private ColorScheme getColorInBrightness(ColorScheme i_ColorScheme)
        {      
            Color backColorChildren = i_ColorScheme.BackColor, foreColorChildren = i_ColorScheme.ForeColor;

            backColorChildren = Color.FromArgb(backColorChildren.R, backColorChildren.G, Math.Abs(backColorChildren.B - ChildrenColorBrightness));
            foreColorChildren = Color.FromArgb(foreColorChildren.R, foreColorChildren.G, Math.Abs(foreColorChildren.B - ChildrenColorBrightness));
            return new ColorScheme(backColorChildren, foreColorChildren);
        }
        protected override void MakeTheme(ColorScheme i_ColorScheme)
        {
            Control component = m_ControlTheme as Control;
            component.BackColor = i_ColorScheme.BackColor;
            component.ForeColor = i_ColorScheme.ForeColor;
            iterateChildrenControls(m_ControlTheme, getColorInBrightness(i_ColorScheme));
        }

        private void iterateChildrenControls(IThemable i_ComponentRoot,ColorScheme i_ColorChildrenScheme)
        {
            Control component = i_ComponentRoot as Control;

            foreach (Control controlChild in component.Controls)
            {
                IThemable componentChild = controlChild as IThemable;
                if (componentChild != null)
                {
                    componentChild.ThemeMaker.ColorScheme = i_ColorChildrenScheme;
                }
            }
        }

        protected override void InitializeSpecificTheme()
        {
            Control meAsControl = m_ControlTheme as Control;
            if(meAsControl!=null)
            {
                Control control = m_ControlTheme as Control;
                OriginialColorScheme = new ColorScheme(control.BackColor, control.ForeColor);
                foreach (Control controlChild in meAsControl.Controls)
                {
                    IThemable componentChild = controlChild as IThemable;
                    if (componentChild != null)
                    {
                        componentChild.ThemeMaker.InitializeTheme();
                    }
                }
            }
        }
        protected override void ClearSpecificTheme()
        {
            Control meAsComponent = m_ControlTheme as Control;    
            if (meAsComponent != null)
            {
                meAsComponent.BackColor = OriginialColorScheme.BackColor;
                meAsComponent.ForeColor = OriginialColorScheme.ForeColor;
                ColorScheme = new ColorScheme(OriginialColorScheme.BackColor, OriginialColorScheme.ForeColor);

                foreach (Control controlChild in meAsComponent.Controls)
                {
                    IThemable componentChild = controlChild as IThemable;
                    if (componentChild != null)
                    {
                        componentChild.ThemeMaker.ClearToOriginTheme();
                    }
                }
            }
        }
    }
}
