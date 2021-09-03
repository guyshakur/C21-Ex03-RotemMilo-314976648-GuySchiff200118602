using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Forms
{
    public struct Theme
    {
        public Color BackColor { get; }
        public Color ForeColor { get; }
        public Color BackColorButton { get; }
        public Color ForeColorButton { get; }

        public Theme(Color i_BackColor, Color i_ForeColor, Color i_BackColorButton, Color i_ForeColorButton)
        {
            BackColor = i_BackColor;
            ForeColor = i_ForeColor;
            BackColorButton = i_BackColorButton;
            ForeColorButton = i_ForeColorButton;
        }

        public void MakeOnlyFormTheme(Form i_Form)
        {
            i_Form.BackColor = BackColor;
            i_Form.ForeColor = ForeColor;
        }

        public void MakeThemeOnControls(Control.ControlCollection i_ControlsCollections)
        {
            foreach (Control control in i_ControlsCollections)
            {
                control.BackColor = BackColor;
                control.ForeColor = ForeColor;
                iterateChildrenControls(control);
            }
        }

        private void iterateChildrenControls(Control i_Component)
        {
            foreach (Control control in i_Component.Controls)
            {
                control.BackColor = BackColor;
                control.ForeColor = ForeColor;
                if (control.Controls.Count != 0)
                {
                    iterateChildrenControls(control);
                }
                else if (control is Button)
                {
                    control.BackColor = BackColorButton;
                    control.ForeColor = ForeColorButton;
                }
            }
        }
    }
}