
using System.Drawing;

namespace FacebookWinFormsApp.Observer.Proxy
{
    public class ColorScheme
    {
        public ColorScheme(Color i_BackColor, Color i_ForeColor)
        {
            BackColor = i_BackColor;
            ForeColor = i_ForeColor;
        }
        public Color BackColor { get; set; }
        public Color ForeColor { get; set; }

        public override bool Equals(object i_ColorSchemeToCompare)
        {
            return this == i_ColorSchemeToCompare as ColorScheme;
        }

        public static bool operator ==(ColorScheme i_ColorScheme, ColorScheme i_ColorSchemeToCompareWith)
        {
            bool isEqual = false;
            if(i_ColorScheme is null && i_ColorSchemeToCompareWith is null)
            {
                isEqual = true;
            }
            else if(i_ColorScheme is null || i_ColorSchemeToCompareWith is null)
            {
                isEqual = false;
            }
            else
            {
                isEqual = i_ColorScheme.BackColor == i_ColorSchemeToCompareWith.BackColor && i_ColorScheme.ForeColor == i_ColorSchemeToCompareWith.ForeColor;
            }

            return isEqual;
        }

        public static bool operator !=(ColorScheme i_ColorSchemeToCompare, ColorScheme i_ColorSchemeToCompareWith)
        {
            return !(i_ColorSchemeToCompare == i_ColorSchemeToCompareWith);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}